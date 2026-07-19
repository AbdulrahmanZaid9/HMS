using System;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsUsersData
    {
        // Checks whether a given username is not already taken.
        public static bool IsUsernameAvailable(string username)
        {
            string query = @"
        SELECT 1
        FROM users
        WHERE username = @Username;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Username", username)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            return result == null;
        }

        // Deletes a user record by its user ID.
        public static bool DeleteUserById(int userId)
        {
            string query = @"
        DELETE FROM Users
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@user_id", userId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Updates a user's active/inactive status if it differs from the current value.
        public static bool UpdateStatusByUserId(int userId, bool isActive)
        {
            string query = @"
        UPDATE users
        SET is_active = @is_active
        WHERE user_id = @user_id
          AND is_active <> @is_active;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@user_id", userId),
                new SqlParameter("@is_active", isActive)
            };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves the person ID linked to a given user ID.
        public static int GetPersonIdByUserId(int userId)
        {
            string query = @"
        SELECT person_id
        FROM users
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@user_id", userId)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;


            return Convert.ToInt32(result);
        }

        // Updates a user's username.
        public static bool UpdateUser(int userId, string username)
        {
            string query = @"
        UPDATE Users
        SET username = @username
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@username", username),
        new SqlParameter("@user_id", userId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Checks whether the given password matches the stored password hash for a user.
        public static bool IsPasswordCorrect(int userId, string password)
        {
            string query = @"
        SELECT 1
        FROM users
        WHERE user_id = @user_id
          AND password_hash = @password_hash;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@user_id", userId),
        new SqlParameter("@password_hash", password)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            return result != null;
        }

        // Updates a user's stored password hash.
        public static bool UpdatePassword(int userId, string password)
        {
            string query = @"
        UPDATE Users
        SET password_hash = @password_hash
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@user_id", userId),
        new SqlParameter("@password_hash", password)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Authenticates a user by username and password, and populates their user details via ref parameters.
        public static bool GetUserInfoByUsernameAndPassword(string username, string password, ref int userId, ref int personId, ref bool isActive, ref DateTime? lastLogin)
        {
            string query = @"
        SELECT *
        FROM users
        WHERE username = @Username
          AND password_hash = @Password;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", password)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            userId = Convert.ToInt32(row["user_id"]);
            personId = Convert.ToInt32(row["person_id"]);
            isActive = Convert.ToBoolean(row["is_active"]);

            lastLogin = row["last_login"] != DBNull.Value
                ? Convert.ToDateTime(row["last_login"])
                : (DateTime?)null;

            return true;
        }

        // Retrieves all users joined with their linked person details.
        public static DataTable GetAllUsers()
        {
            string query = @"
        SELECT 
            U.user_id,
            U.username,
            P.full_name,
            P.email,
            P.phone,
            P.passport_number,
            CASE 
                WHEN P.Gender = 0 THEN 'Male' 
                ELSE 'Female' 
            END AS Gender
        FROM users U
        INNER JOIN persons P 
            ON U.person_id = P.person_id;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Updates a user's last login timestamp.
        public static bool UpdateLastLogin(int userId, DateTime lastLogin)
        {
            string query = @"
        UPDATE Users
        SET last_login = @last_login
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@last_login", lastLogin),
        new SqlParameter("@user_id", userId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves a user record by its user ID.
        public static DataTable FindUserByUserId(int userId)
        {
            string query = @"
        SELECT *
        FROM users
        WHERE user_id = @user_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@user_id", userId)
    };

            return clsDataAccessHelper.ExecuteDataTable(query, parameters);
        }

        // Inserts a new user record and returns the newly generated user ID.
        public static int AddNewUser(int personId, string username, string password, DateTime? lastLogin, bool isActive)
        {
            string query = @"
        INSERT INTO users
        (
            person_id,
            username,
            password_hash,
            last_login,
            is_active
        )
        VALUES
        (
            @person_id,
            @username,
            @password_hash,
            @last_login,
            @is_active
        );

        SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
        new SqlParameter("@person_id", personId),
        new SqlParameter("@username", username),
        new SqlParameter("@password_hash", password),
        new SqlParameter("@last_login",
            lastLogin.HasValue ? (object)lastLogin.Value : DBNull.Value),
        new SqlParameter("@is_active", isActive)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }
    }
}