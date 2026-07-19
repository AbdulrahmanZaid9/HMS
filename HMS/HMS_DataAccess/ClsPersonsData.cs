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
    public class ClsPersonsData
    {

        // Retrieves all person records.
        public static DataTable GetAllPersons()
        {
            string query = "select * from persons";
            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Looks up a person by ID and populates their full details via ref parameters.
        public static bool FindPersonById(int personId, ref string fullName, ref string phone, ref string email, ref DateTime dateOfBirth, ref string address,
    ref byte nationalityId, ref string notes, ref string passportNumber, ref bool gender, ref DateTime createdAt, ref DateTime updatedAt)
        {
            string query = "SELECT full_name, phone, email, date_of_birth, address, nationality_id, notes, passport_number, gender,created_at,updated_at FROM persons WHERE person_id = @person_id;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@person_id", personId)
            };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            fullName = row["full_name"].ToString();
            phone = row["phone"].ToString();
            email = row["email"].ToString();
            dateOfBirth = Convert.ToDateTime(row["date_of_birth"]);
            address = row["address"].ToString();
            nationalityId = Convert.ToByte(row["nationality_id"]);
            notes = row["notes"].ToString();
            passportNumber = row["passport_number"].ToString();
            gender = Convert.ToBoolean(row["gender"]);
            createdAt = Convert.ToDateTime(row["created_at"]);
            updatedAt = Convert.ToDateTime(row["updated_at"]);

            return true;
        }

        // Inserts a new person record and returns the newly generated person ID.
        public static int AddNewPerson(string fullName, string email, string phone, DateTime dateOfBirth, string address, byte nationalityId, string notes, string passportNumber, bool gender)
        {
            string query = "insert into persons (full_name,email,phone,date_of_birth,address,nationality_id,notes,passport_number,created_at,updated_at,Gender)" +
                " values (@full_name,@email,@phone,@date_of_birth,@address,@nationality_id,@notes,@passport_number,GETDATE(),GETDATE(),@Gender); SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@full_name", fullName),
                new SqlParameter("@email", email),
                new SqlParameter("@phone", phone),
                new SqlParameter("@date_of_birth", dateOfBirth),
                new SqlParameter("@address", address),
                new SqlParameter("@nationality_id", nationalityId),
                new SqlParameter("@notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes),
                new SqlParameter("@passport_number", passportNumber),
                new SqlParameter("@Gender", gender)
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);

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

        // Updates an existing person's personal details.
        public static bool UpdatePerson(
            int personId,
            string fullName,
            string email,
            string phone,
            DateTime dateOfBirth,
            string address,
            byte nationalityId,
            string notes,
            string passportNumber,
            bool gender)
        {
            string query = @"
        UPDATE persons
        SET
            full_name = @full_name,
            email = @email,
            phone = @phone,
            date_of_birth = @date_of_birth,
            address = @address,
            nationality_id = @nationality_id,
            notes = @notes,
            passport_number = @passport_number,
            updated_at = GETDATE(),
            Gender = @Gender
        WHERE person_id = @person_id;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@full_name", fullName),
                new SqlParameter("@email", email),
                new SqlParameter("@phone", phone),
                new SqlParameter("@date_of_birth", dateOfBirth),
                new SqlParameter("@address", address),
                new SqlParameter("@nationality_id", nationalityId),
                new SqlParameter("@notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes),
                new SqlParameter("@passport_number", passportNumber),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@person_id", personId)
            };
            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Deletes a person record by its person ID.
        public static bool DeletePersonById(int personId)
        {
            string query = @"
        DELETE FROM persons
        WHERE person_id = @person_id;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@person_id", personId)
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}