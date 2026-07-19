using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsReservationsData
    {
        // Retrieves all reservations from the reservation details view.
        public static DataTable GetAllReservations()
        {
            string query = "SELECT * FROM vw_ReservationDetails;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Retrieves all reservations belonging to a specific customer.
        public static DataTable GetAllReservationsForCustomer(int customerId)
        {
            string query = @"
        SELECT *
        FROM vw_ReservationDetails
        WHERE customer_id = @customer_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@customer_id", customerId)
    };

            return clsDataAccessHelper.ExecuteDataTable(query, parameters);
        }

        // Retrieves the active or pending reservation ID for a given customer.
        public static int GetReservationIdByCustomerId(int customerId)
        {
            string query = @"
        SELECT reservation_id
        FROM reservations
        WHERE customer_id = @customer_id
          AND status IN (1,2);";

            SqlParameter[] parameters =
            {
        new SqlParameter("@customer_id", customerId)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Calculates and returns the total room charges for a reservation based on nights stayed.
        public static List<(string, decimal)> GetRoomChargesByReservationId(int reservationId)
        {
            List<(string, decimal)> billSummary = new List<(string, decimal)>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select 'Room Charges' as RoomCharges,R.price_per_night *DATEDIFF(DAY, RS.check_in_date, RS.check_out_date) as total from reservations RS inner join rooms R on RS.room_id = R.room_id where RS.reservation_id = @reservation_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@reservation_id", reservationId);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string serviceName = reader["RoomCharges"].ToString();
                        decimal price = Convert.ToDecimal(reader["total"]);
                        billSummary.Add((serviceName, price));
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                connection.Close();
            }

            return billSummary;
        }

        // Updates the status of a reservation (e.g. confirmed, checked-in, cancelled).
        public static bool ChangeReservationStatus(int reservationId, byte newStatus)
        {
            string query = @"
        UPDATE reservations
        SET status = @status
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@status", newStatus),
        new SqlParameter("@reservation_id", reservationId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Sets the actual check-in date/time of a reservation to now.
        public static bool UpdateActualCheckInDate(int reservationId)
        {
            string query = @"
        UPDATE reservations
        SET actual_check_in = GETDATE()
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Sets the actual check-out date/time of a reservation to now.
        public static bool UpdateActualCheckOutDate(int reservationId)
        {
            string query = @"
        UPDATE reservations
        SET actual_check_out = GETDATE()
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Deletes a reservation record by its reservation ID.
        public static bool DeleteReservationById(int reservationId)
        {
            string query = @"
        DELETE FROM reservations
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Looks up a reservation by ID and populates its full details via ref parameters.
        public static bool FindReservationById(
           int reservationId,
           ref int customerId,
           ref short roomId,
           ref DateTime checkInDate,
           ref DateTime checkOutDate,
           ref DateTime actualCheckOut,
           ref byte reservationStatus,
           ref string notes,
           ref DateTime actualCheckIn)
        {
            string query = @"
        SELECT *
        FROM reservations
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@reservation_id", reservationId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            customerId = Convert.ToInt32(row["customer_id"]);
            roomId = Convert.ToInt16(row["room_id"]);
            checkInDate = Convert.ToDateTime(row["check_in_date"]);
            checkOutDate = Convert.ToDateTime(row["check_out_date"]);

            actualCheckIn = row["actual_check_in"] == DBNull.Value
                ? DateTime.MinValue
                : Convert.ToDateTime(row["actual_check_in"]);

            actualCheckOut = row["actual_check_out"] == DBNull.Value
                ? DateTime.MinValue
                : Convert.ToDateTime(row["actual_check_out"]);

            reservationStatus = Convert.ToByte(row["status"]);

            notes = row["notes"] == DBNull.Value
                ? string.Empty
                : row["notes"].ToString();

            return true;
        }

        // Inserts a new reservation record and returns the newly generated reservation ID.
        public static int AddNewReservation(
    int customerId,
    short roomId,
    DateTime checkInDate,
    DateTime checkOutDate,
    DateTime actualCheckOut,
    byte reservationStatus,
    string notes,
    DateTime actualCheckIn)
        {
            string query = @"
        INSERT INTO reservations
        (
            customer_id,
            room_id,
            check_in_date,
            check_out_date,
            actual_check_out,
            status,
            notes,
            actual_check_in
        )
        VALUES
        (
            @customer_id,
            @room_id,
            @check_in_date,
            @check_out_date,
            @actual_check_out,
            @status,
            @notes,
            @actual_check_in
        );

        SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
        new SqlParameter("@customer_id", customerId),
        new SqlParameter("@room_id", roomId),
        new SqlParameter("@check_in_date", checkInDate),
        new SqlParameter("@check_out_date", checkOutDate),
        new SqlParameter("@actual_check_out",
            actualCheckOut == DateTime.MinValue ? (object)DBNull.Value : actualCheckOut),
        new SqlParameter("@status", reservationStatus),
        new SqlParameter("@notes",
            string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes),
        new SqlParameter("@actual_check_in",
            actualCheckIn == DateTime.MinValue ? (object)DBNull.Value : actualCheckIn)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);


            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Updates an existing reservation's room, dates, status, and notes.
        public static bool UpdateReservation(int reservationId, int customerId, short roomId, DateTime checkInDate, DateTime checkOutDate, DateTime actualCheckOut, byte reservationStatus, string notes, DateTime actualCheckIn)
        {
            string query = @"
        UPDATE reservations
        SET 
            customer_id = @customer_id,
            room_id = @room_id,
            check_in_date = @check_in_date,
            check_out_date = @check_out_date,
            actual_check_out = @actual_check_out,
            status = @status,
            notes = @notes,
            actual_check_in = @actual_check_in
        WHERE reservation_id = @reservation_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@customer_id", customerId),
        new SqlParameter("@room_id", roomId),
        new SqlParameter("@check_in_date", checkInDate),
        new SqlParameter("@check_out_date", checkOutDate),
        new SqlParameter("@actual_check_out",
            actualCheckOut == DateTime.MinValue ? (object)DBNull.Value : actualCheckOut),
        new SqlParameter("@status", reservationStatus),
        new SqlParameter("@notes",
            string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes),
        new SqlParameter("@actual_check_in",
            actualCheckIn == DateTime.MinValue ? (object)DBNull.Value : actualCheckIn),
        new SqlParameter("@reservation_id", reservationId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}