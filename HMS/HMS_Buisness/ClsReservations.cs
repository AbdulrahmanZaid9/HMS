using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HMS_Buisness.ClsRooms;

namespace HMS_Buisness
{
    public class ClsReservations
    {
        enum EnMode
        {
            AddNew = 1,
            Update = 2,
        }
        EnMode _mode = EnMode.AddNew;
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public short RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ActualCheckOut { get; set; }
        public DateTime ActualCheckIn { get; set; }
        public enum EnReservationStatus
        {
            Confirmed = 1,
            CheckedIn = 2,
            CheckedOut = 3,
            Cancelled = 4
        }

        public EnReservationStatus ReservationStatus { get; set; }

        public string Notes { get; set; }

        public ClsCustomers Customer { get; set; }
        public ClsRooms Room { get; set; }

        // Returns the display-friendly string form of the current reservation status.
        public string ReservationStatusString
        {
            get
            {
                switch (ReservationStatus)
                {
                    case EnReservationStatus.Confirmed:
                        return "Confirmed";
                    case EnReservationStatus.CheckedIn:
                        return "Checked_In";
                    case EnReservationStatus.CheckedOut:
                        return "Checked_Out";
                    case EnReservationStatus.Cancelled:
                        return "Cancelled";
                    default:
                        return "Unknown";
                }
            }
        }

        // Creates a new, unsaved reservation in "add" mode with default values.
        public ClsReservations()
        {
            this.ReservationId = 0;
            this.CustomerId = 0;
            this.RoomId = 0;
            this.CheckInDate = DateTime.MinValue;
            this.CheckOutDate = DateTime.MinValue;
            this.ActualCheckOut = DateTime.MinValue;
            this.ActualCheckIn = DateTime.MinValue;
            this.ReservationStatus = EnReservationStatus.Confirmed;
            this.Notes = string.Empty;

            this.Customer = ClsCustomers.FindCustomerById(this.CustomerId);
            this.Room = ClsRooms.FindRoomById(this.RoomId);

            _mode = EnMode.AddNew;

        }

        // Creates a reservation object from existing data, loading its linked customer and room, and puts it in "update" mode.
        public ClsReservations(int reservationId, int customerId, short roomId, DateTime checkInDate, DateTime checkOutDate, DateTime actualCheckOut, EnReservationStatus reservationStatus, string notes, DateTime actualCheckIn)
        {
            this.ReservationId = reservationId;
            this.CustomerId = customerId;
            this.RoomId = roomId;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.ActualCheckOut = actualCheckOut;
            this.ActualCheckIn = actualCheckIn;
            this.ReservationStatus = reservationStatus;
            this.Notes = notes;

            this.Customer = ClsCustomers.FindCustomerById(customerId);
            this.Room = ClsRooms.FindRoomById(roomId);

            _mode = EnMode.Update;
        }

        // Changes a reservation's status, also updating the actual check-in/check-out timestamp when relevant.
        public static bool ChangeReservationStatus(EnReservationStatus newStatus, int reservationId)
        {
            if (newStatus == EnReservationStatus.Cancelled)
            {
                return ClsReservationsData.ChangeReservationStatus(reservationId, (byte)newStatus);

            }
            else if (newStatus == EnReservationStatus.CheckedIn)
            {
                return _UpdateActualCheckInDate(reservationId) && ClsReservationsData.ChangeReservationStatus(reservationId, (byte)newStatus);
            }
            else
            {
                return _UpdateActualCheckOutDate(reservationId) && ClsReservationsData.ChangeReservationStatus(reservationId, (byte)newStatus);
            }
        }

        // Sets a reservation's actual check-out date/time to now.
        private static bool _UpdateActualCheckOutDate(int reservationId)
        {
            return ClsReservationsData.UpdateActualCheckOutDate(reservationId);
        }

        // Sets a reservation's actual check-in date/time to now.
        private static bool _UpdateActualCheckInDate(int reservationId)
        {
            return ClsReservationsData.UpdateActualCheckInDate(reservationId);
        }

        // Deletes a reservation record by its reservation ID.
        public static bool DeleteReservationById(int reservationId)
        {
            return ClsReservationsData.DeleteReservationById(reservationId);
        }

        // Calculates and returns the total room charges for a reservation.
        public static List<(string, decimal)> GetRoomChargesByReservationId(int reservationId)
        {
            return ClsReservationsData.GetRoomChargesByReservationId(reservationId);
        }

        // Retrieves a reservation by ID and returns it as a ClsReservations object, or null if not found.
        public static ClsReservations FindReservationById(int reservationId)
        {

            int customerId = -1;
            short roomId = -1;
            DateTime checkInDate = DateTime.MinValue;
            DateTime checkOutDate = DateTime.MinValue;
            DateTime actualCheckOut = DateTime.MinValue; ;
            DateTime actualCheckIn = DateTime.MinValue;
            byte reservationStatus = 0;
            string notes = string.Empty;
            if (ClsReservationsData.FindReservationById(reservationId, ref customerId, ref roomId, ref checkInDate, ref checkOutDate, ref actualCheckOut, ref reservationStatus, ref notes, ref actualCheckIn))
            {
                return new ClsReservations(
                    reservationId,
                    customerId,
                    roomId,
                    checkInDate,
                    checkOutDate,
                    actualCheckOut,
                    (ClsReservations.EnReservationStatus)reservationStatus,
                    notes,
                    actualCheckIn
                    );
            }
            else
                return null;
        }

        // Persists changes to an existing reservation in the database.
        private bool _UpdateReservation()
        {
            return ClsReservationsData.UpdateReservation(this.ReservationId, this.CustomerId, this.RoomId, this.CheckInDate, this.CheckOutDate, this.ActualCheckOut, (byte)this.ReservationStatus, this.Notes, this.ActualCheckIn);
        }

        // Inserts this reservation as a new record and stores the generated reservation ID.
        private bool _AddNewReservation()
        {
            this.ReservationId = ClsReservationsData.AddNewReservation(this.CustomerId, this.RoomId, this.CheckInDate, this.CheckOutDate, this.ActualCheckOut, (byte)this.ReservationStatus, this.Notes, this.ActualCheckIn);
            return this.ReservationId > 0;
        }

        // Saves the reservation, inserting it if new or updating it if it already exists.
        public bool Save()
        {

            switch (this._mode)
            {
                case EnMode.AddNew:
                    if (_AddNewReservation())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateReservation();
            }
            return false;
        }

        // Retrieves all reservations.
        public static DataTable GetAllReservations()
        {
            return ClsReservationsData.GetAllReservations();
        }

        // Retrieves all reservations belonging to a specific customer.
        public static DataTable GetAllReservationsForCustomer(int customer_id)
        {
            return ClsReservationsData.GetAllReservationsForCustomer(customer_id);
        }

        // Converts a reservation status enum value into its display-friendly string form.
        public static string GetReservationStatus(EnReservationStatus status)
        {
            switch (status)
            {
                case EnReservationStatus.Confirmed:
                    return "Confirmed";
                case EnReservationStatus.CheckedIn:
                    return "Checked_In";
                case EnReservationStatus.CheckedOut:
                    return "Checked_Out";
                case EnReservationStatus.Cancelled:
                    return "Cancelled";
                default:
                    return "Unknown";
            }
        }

        // Retrieves the active or pending reservation ID for a given customer.
        public static int GetReservationIdByCustomerId(int CustomerID)
        {
            return ClsReservationsData.GetReservationIdByCustomerId(CustomerID);
        }
    }

}