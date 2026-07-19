using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsServiceBookings
    {
        public int ReservationId { get; set; }
        public byte ServiceId { get; set; }
        public int BillId { get; set; }
        public int BookingId { get; set; }
        public DateTime ServiceDate { get; set; }

        public ClsBills Bill { get; set; }
        public ClsReservations Reservation { get; set; }
        public ClsServices Service { get; set; }

        // Creates a new, unsaved service booking with default values and empty linked records.
        public ClsServiceBookings()
        {
            this.ReservationId = 0;
            this.ServiceId = 0;
            this.BillId = 0;
            this.BookingId = 0;
            this.ServiceDate = DateTime.Now;
            this.Bill = ClsBills.FindBillById(this.BillId);
            this.Reservation = ClsReservations.FindReservationById(this.ReservationId);
            this.Service = ClsServices.FindServiceById(this.ServiceId);
        }

        // Creates a service booking object from existing data, loading its linked bill, reservation, and service.
        public ClsServiceBookings(int reservationId, byte serviceId, int billId, int bookingId, DateTime serviceDate)
        {
            this.ReservationId = reservationId;
            this.ServiceId = serviceId;
            this.BillId = billId;
            this.BookingId = bookingId;
            this.ServiceDate = serviceDate;

            this.Bill = ClsBills.FindBillById(billId);
            this.Reservation = ClsReservations.FindReservationById(reservationId);
            this.Service = ClsServices.FindServiceById(serviceId);
        }

        // Retrieves a service booking by ID and returns it as a ClsServiceBookings object, or null if not found.
        public static ClsServiceBookings FindServiceBookingById(byte serviceId)
        {

            int reservationId = -1;
            int billId = 0;
            int bookingId = 0;
            DateTime serviceDate = DateTime.MinValue;
            if (ClsServiceBookingsData.FindServiceBookingById(serviceId, ref reservationId, ref billId, ref bookingId, ref serviceDate))
            {
                return new ClsServiceBookings(
                    reservationId,
                    serviceId,
                    billId,
                    bookingId,
                    serviceDate
                    );
            }
            else
                return null;
        }

        // Inserts this service booking as a new record and stores the generated booking ID.
        public bool AddService()
        {
            this.BookingId = ClsServiceBookingsData.AddServiceBooking(this.ReservationId, this.ServiceId, this.BillId);

            return this.BookingId > 0;
        }

        // Retrieves all active service bookings.
        public static DataTable GetAllActiveServiceBookings()
        {
            return ClsServiceBookingsData.GetAllActiveServiceBookings();
        }

        // Deletes a service booking record by its booking ID.
        public static bool DeleteBookingById(int bookingId)
        {
            return ClsServiceBookingsData.DeleteBookingById(bookingId);
        }

        // Updates the service associated with an existing service booking.
        public static bool UpdateBookingById(int bookingId, byte serviceId)
        {
            return ClsServiceBookingsData.UpdateBookingById(bookingId, serviceId);
        }

        // Calculates the total charge of all services booked under a given reservation.
        public static decimal GetServicesChargeByReservationId(int reservationId)
        {
            return ClsServiceBookingsData.GetServicesChargeByReservationId(reservationId);
        }
    }
}