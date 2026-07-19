using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HMS_Buisness.ClsRooms;

namespace HMS_Buisness
{
    public class ClsBills
    {
        public enum EnBillStatus
        {
            Unpaid = 1,
            Paid = 2,
            Cancelled = 3,
        }
        public EnBillStatus BillStatus = EnBillStatus.Unpaid;
        public int BillId { get; set; }
        public int ReservationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PaidAt { get; set; }

        public ClsReservations Reservation { get; set; }

        enum EnMode
        {
            AddNew = 1,
            Update = 2,
        }
        EnMode _mode = EnMode.AddNew;

        // Creates a new, unsaved bill in "add" mode with default values.
        public ClsBills()
        {
            this.BillId = 0;
            this.ReservationId = 0;
            this.CreatedAt = DateTime.Now;
            this.PaidAt = DateTime.MinValue;
            this.BillStatus = EnBillStatus.Unpaid;

            this.Reservation = ClsReservations.FindReservationById(this.ReservationId);

            _mode = EnMode.AddNew;
        }

        // Creates a bill object from existing data and puts it in "update" mode.
        public ClsBills(int billId, int reservationId, DateTime createdAt, DateTime paidAt, EnBillStatus billStatus)
        {
            this.BillId = billId;
            this.ReservationId = reservationId;
            this.CreatedAt = createdAt;
            this.PaidAt = paidAt;
            this.BillStatus = billStatus;
            this.Reservation = ClsReservations.FindReservationById(this.ReservationId);
            _mode = EnMode.Update;
        }

        // Persists changes to an existing bill in the database.
        private bool _UpdateBill()
        {
            return ClsBillsData.UpdateBill(this.BillId, this.ReservationId, this.CreatedAt, this.PaidAt, (byte)this.BillStatus);
        }

        // Inserts this bill as a new record and stores the generated bill ID.
        private bool _AddNewBill()
        {
            this.BillId = ClsBillsData.AddNewBill(this.ReservationId, (byte)this.BillStatus);

            return this.BillId > 0;
        }

        // Saves the bill, inserting it if new or updating it if it already exists.
        public bool Save()
        {

            switch (_mode)
            {
                case EnMode.AddNew:
                    if (_AddNewBill())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateBill();
            }
            return false;
        }

        // Retrieves a bill by its ID and returns it as a ClsBills object, or null if not found.
        public static ClsBills FindBillById(int billId)
        {
            int reservationId = 0;
            DateTime createdAt = DateTime.MinValue;
            DateTime paidAt = DateTime.MinValue;
            byte billStatus = (byte)EnBillStatus.Unpaid;

            if (ClsBillsData.FindBillById(billId, ref reservationId, ref createdAt, ref paidAt, ref billStatus))
            {
                return new ClsBills(billId, reservationId, createdAt, paidAt, (EnBillStatus)billStatus);
            }
            else
                return null;
        }

        // Retrieves the bill ID associated with a given reservation.
        public static int GetBillIdByReservationId(int reservationId)
        {
            return ClsBillsData.GetBillIdByReservationId(reservationId);
        }

        // Retrieves the list of service names and prices booked under a given reservation.
        public static List<(string, decimal)> GetBillSummaryByReservationID(int reservationId)
        {
            return ClsBillsData.GetBillSummaryByReservationID(reservationId);
        }

        // Marks a bill as paid by setting its PaidAt timestamp to now.
        public static bool UpdatePaitAtBill(int billId)
        {
            return ClsBillsData.UpdatePaitAtBill(billId);
        }

        // Checks whether a given bill has already been paid.
        public static bool IsBillPaid(int billId)
        {
            return ClsBillsData.IsBillPaid(billId);
        }

        // Retrieves the creation date/time of a given bill.
        public static DateTime? GetCreatedAtBill(int billId)
        {
            return ClsBillsData.GetCreatedAtBill(billId);

        }

        // Retrieves the paid-at date/time of a given bill.
        public static DateTime? GetPaidAtBill(int billId)
        {
            return ClsBillsData.GetPaidAtBill(billId);
        }

    }
}