using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsCustomersData
    {
        // Retrieves all customers joined with their person and nationality details.
        public static DataTable GetAllCustomers()
        {
            string query = "select C.customer_id,C.person_id,C.status," +
                "CASE " +
                "WHEN P.Gender = 0 THEN 'Male' ELSE 'Female'" +
                "END AS Gender,P.full_name,P.email,P.phone,P.date_of_birth,P.address,N.country_name,P.notes,P.passport_number," +
                "P.created_at,P.updated_at  from customers C inner join persons P on C.person_id = P.person_id inner join nationalities N on P.nationality_id = N.country_id;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Retrieves the person ID linked to a given customer ID.
        public static int GetPersonIdByCustomerId(int customerId)
        {
            string query = @"select person_id from customers where customer_id = @customer_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@customer_id", customerId),
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;
            return Convert.ToInt32(result);

        }

        // Checks whether a person with the given passport number already exists.
        public static bool IsCustomerExistsByPassport(string passportNumber)
        {
            string query = @"select 1 as IsExist from persons where passport_number = @passport_number";

            SqlParameter[] parameters =
               {
                new SqlParameter("@passport_number", passportNumber),
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return false;

            return Convert.ToInt32(result) > 0;
        }

        // Updates a customer's active/inactive status if it differs from the current value.
        public static bool UpdateStatusByCustomerID(int customerId, bool status)
        {
            string query = @"UPDATE Customers
            SET Status = @status
            WHERE customer_id = @customer_id
              AND Status <> @status;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@customer_id", customerId),
                new SqlParameter("@status", status)
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves all customers filtered by active or inactive status.
        public static DataTable GetActiveOrInactiveCustomers(bool isActive)
        {
            string query = "select C.customer_id,C.person_id,C.status,CASE WHEN P.Gender = 0 THEN 'Male' ELSE 'Female' END AS Gender," +
                "P.full_name,P.email,P.phone,P.date_of_birth,P.address,N.country_name,P.notes,P.passport_number,P.created_at," +
                "P.updated_at from customers C inner join persons P on C.person_id = P.person_id inner join nationalities N on P.nationality_id = N.country_id where C.status =@IsActive ";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IsActive", isActive)
            };

            return clsDataAccessHelper.ExecuteDataTable(query, parameters);

        }

        // Inserts a new customer record linked to a person and returns the new customer ID.
        public static int AddNewCustomer(int personId)
        {
            string query = "insert into customers (person_id,status)" +
                " values (@person_id,@status); SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters =
            {
                new SqlParameter("@person_id", personId),
                new SqlParameter("@status", true)
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        // Looks up a customer by ID and populates the person ID and active status via ref parameters.
        public static bool FindCustomerById(int customerId, ref int personId, ref bool isActive)
        {
            string query = "select * from customers where customer_id = @customer_id;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@customer_id", customerId)
            };

            DataTable table =
                clsDataAccessHelper.ExecuteDataTable(query, parameters);


            if (table.Rows.Count == 0)
                return false;


            DataRow row = table.Rows[0];


            personId =
                Convert.ToInt32(row["person_id"]);


            isActive =
                Convert.ToBoolean(row["status"]);

            return true;
        }

        // Deletes a customer record by its customer ID.
        public static bool DeleteCusomterById(int customerId)
        {
            string query = @"Delete customers 
                                where customer_id = @customer_id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@customer_id", customerId),
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

    }
}