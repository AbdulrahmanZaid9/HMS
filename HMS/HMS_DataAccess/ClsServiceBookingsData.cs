using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsServiceBookingsData
    {
        // Looks up a service booking by booking ID and populates its details via ref parameters.
        public static bool FindServiceBookingById(byte serviceId, ref int reservationId, ref int billId, ref int bookingId, ref DateTime serviceDate)
        {
            string query = @"
        SELECT *
        FROM service_bookings
        WHERE booking_id = @booking_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@booking_id", bookingId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            serviceId = Convert.ToByte(row["service_id"]);
            reservationId = Convert.ToInt32(row["reservation_id"]);
            billId = Convert.ToInt32(row["bill_id"]);
            bookingId = Convert.ToInt32(row["booking_id"]);
            serviceDate = Convert.ToDateTime(row["service_date"]);

            return true;
        }

        // Inserts a new service booking linked to a reservation and bill, and returns the new booking ID.
        public static int AddServiceBooking(int reservationId, byte serviceId, int billId)
        {
            string query = @"
        INSERT INTO service_bookings
        (
            reservation_id,
            service_id,
            service_date,
            bill_id
        )
        VALUES
        (
            @reservation_id,
            @service_id,
            GETDATE(),
            @bill_id
        );

        SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId),
        new SqlParameter("@service_id", serviceId),
        new SqlParameter("@bill_id", billId)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Retrieves all service bookings for customers with an active or pending status, joined with customer, room, and service details.
        public static DataTable GetAllActiveServiceBookings()
        {
            string query = @"
        SELECT 
            SB.booking_id,
            P.full_name,
            RO.room_number,
            S.service_name,
            S.description,
            S.price,
            SB.service_date,
            SB.reservation_id,
            SB.service_id,
            SB.bill_id,
            R.customer_id,
            R.room_id
        FROM service_bookings SB
        INNER JOIN services S 
            ON SB.service_id = S.service_id
        INNER JOIN reservations R 
            ON SB.reservation_id = R.reservation_id
        INNER JOIN customers C 
            ON R.customer_id = C.customer_id
        INNER JOIN persons P 
            ON C.person_id = P.person_id
        INNER JOIN rooms RO 
            ON R.room_id = RO.room_id
        WHERE C.status IN (1,2);";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Deletes a service booking record by its booking ID.
        public static bool DeleteBookingById(int bookingId)
        {
            string query = @"
        DELETE FROM service_bookings
        WHERE booking_id = @booking_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@booking_id", bookingId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Calculates the total charge of all services booked under a given reservation.
        public static decimal GetServicesChargeByReservationId(int reservationId)
        {
            string query = @"
        SELECT ISNULL(SUM(S.price), 0)
        FROM service_bookings SB
        INNER JOIN services S
            ON SB.service_id = S.service_id
        WHERE SB.reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToDecimal(result);
        }

        // Updates the service associated with an existing service booking.
        public static bool UpdateBookingById(int bookingId, byte serviceId)
        {
            string query = @"
        UPDATE service_bookings
        SET service_id = @service_id
        WHERE booking_id = @booking_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@booking_id", bookingId),
        new SqlParameter("@service_id", serviceId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}