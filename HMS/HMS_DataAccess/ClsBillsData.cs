using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsBillsData
    {
        // Updates an existing bill's reservation, timestamps, and status in the database.
        public static bool UpdateBill(int billId, int reservationId, DateTime createdAt, DateTime paidAt, byte status)
        {
            string query = @"Update Bills set reservation_id = @reservation_id, CreatedAt = @CreatedAt, PaidAt = @PaidAt, status = @status where bill_id = @bill_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@reservation_id", reservationId),
                new SqlParameter("@CreatedAt", createdAt),
                new SqlParameter("@PaidAt", paidAt),
                new SqlParameter("@status", status),
                new SqlParameter("@bill_id", billId)
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Inserts a new bill for a reservation and returns the newly generated bill ID.
        public static int AddNewBill(int reservationId, byte status)
        {
            string query = @"
                            INSERT INTO bills 
          (                 reservation_id, status, CreatedAt, PaidAt)
                            values (@reservation_id, @status, @created_at, @paid_at)
                            SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters =
     {
                new SqlParameter("@reservation_id", reservationId),
                new SqlParameter("@created_at", DateTime.Now),
                new SqlParameter("@paid_at", DBNull.Value),
                new SqlParameter("@status", status),
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return 0;
            return Convert.ToInt32(result);

        }

        // Marks a bill as paid by setting its PaidAt timestamp to the current date/time.
        public static bool UpdatePaitAtBill(int billId)
        {
            string query = "update bills set PaidAt = GETDATE() where bill_id = @bill_id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@bill_id", billId),
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Checks whether a given bill has already been paid.
        public static bool IsBillPaid(int billId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@bill_id", billId),
            };
            string query = @"SELECT 1
                     FROM bills
                     WHERE bill_id = @bill_id
                     AND PaidAt IS NOT NULL";

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return false;

            return true;
        }

        // Retrieves the list of service names and prices booked under a given reservation.
        public static List<(string, decimal)> GetBillSummaryByReservationID(int reservationId)
        {
            List<(string, decimal)> billSummary = new List<(string, decimal)>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = "select S.service_name,S.price from service_bookings SB inner join services S on SB.service_id = S.service_id where SB.reservation_id = @reservation_id";

            SqlCommand command = new SqlCommand(Query, connection);
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
                        string serviceName = reader["service_name"].ToString();
                        decimal price = Convert.ToDecimal(reader["price"]);
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

        // Looks up a bill by its ID and populates the reservation, dates, and status via ref parameters.
        public static bool FindBillById(int billId, ref int reservationId, ref DateTime createdAt, ref DateTime paidAt, ref byte status)
        {
            string query =
                "select * from bills where bill_id = @bill_id";


            SqlParameter[] parameters =
            {
        new SqlParameter("@bill_id", billId)
    };

            DataTable table =
                clsDataAccessHelper.ExecuteDataTable(query, parameters);


            if (table.Rows.Count == 0)
                return false;


            DataRow row = table.Rows[0];


            reservationId =
                Convert.ToInt32(row["reservation_id"]);


            createdAt =
                Convert.ToDateTime(row["CreatedAt"]);


            paidAt =
                row["PaidAt"] == DBNull.Value
                ? DateTime.MinValue
                : Convert.ToDateTime(row["PaidAt"]);


            status =
                Convert.ToByte(row["Status"]);


            return true;

        }

        // Retrieves the bill ID associated with a given reservation.
        public static int GetBillIdByReservationId(int reservationId)
        {
            string query = "select bill_id from bills where reservation_id = @reservation_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@reservation_id", reservationId),
            };
            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Retrieves the creation date/time of a given bill, or null if not found.
        public static DateTime? GetCreatedAtBill(int billId)
        {
            string query = @"
        SELECT CreatedAt
        FROM bills
        WHERE bill_id = @bill_id";


            SqlParameter[] parameters =
            {
        new SqlParameter("@bill_id", billId)
    };

            object result =
                clsDataAccessHelper.ExecuteScalar(query, parameters);


            if (result != null && result != DBNull.Value)
                return Convert.ToDateTime(result);

            return null;
        }

        // Retrieves the paid-at date/time of a given bill, or null if not paid/not found.
        public static DateTime? GetPaidAtBill(int billId)
        {
            string query = @"
        SELECT PaidAt
        FROM bills
        WHERE bill_id = @bill_id";


            SqlParameter[] parameters =
            {
        new SqlParameter("@bill_id", billId)
    };


            object result =
                clsDataAccessHelper.ExecuteScalar(query, parameters);


            if (result != null && result != DBNull.Value)
                return Convert.ToDateTime(result);


            return null;
        }
    }
}