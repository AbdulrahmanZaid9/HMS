using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class clsDataAccessHelper
    {
        // Executes a query and returns a single scalar value (e.g. count, ID, or single column result).
        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection connection =
                   new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();

                    result = command.ExecuteScalar();
                }
            }

            return result;
        }

        // Executes a non-query command (insert/update/delete) and returns the number of affected rows.
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;

            using (SqlConnection connection =
                  new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        // Executes a query and returns the results as a populated DataTable.
        public static DataTable ExecuteDataTable(string query, SqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection =
                  new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(table);
                }
            }

            return table;
        }
    }
}