using HMS_DataAccess;
using System;
using System.Data;
using Utilities;
namespace HMS_Buisness
{
    public class ClsUsers
    {
        public enum EnMode { AddNew = 1, Update = 2 }
        public EnMode _mode = EnMode.AddNew;

        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }

        public ClsPersons Person { get; set; }

        // Creates a new, unsaved user in "add" mode with a fresh associated person.
        public ClsUsers()
        {
            this.UserId = -1;
            this.PersonId = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.LastLogin = DateTime.MinValue;
            this.IsActive = true;
            this.Person = new ClsPersons();

            this._mode = EnMode.AddNew;
        }

        // Creates a user object from existing data, loading its linked person, and puts it in "update" mode.
        public ClsUsers(int userId, int personId, string userName, string password, DateTime? lastLogin, bool isActive)
        {
            this.UserId = userId;
            this.PersonId = personId;
            this.UserName = userName;
            this.Password = password;
            this.LastLogin = lastLogin;
            this.IsActive = isActive;
            this.Person = ClsPersons.FindPersonById(personId);
            this._mode = EnMode.Update;
        }

        // Authenticates a user by username and password (hashed) and returns the matching ClsUsers object, or null if not found.
        public static ClsUsers FindByUsernameAndPassword(string userName, string password)
        {
            bool isFound = false;
            int userId = -1;
            int personId = -1;
            bool isActive = true;
            DateTime? lastLogin = DateTime.MinValue;

            isFound = ClsUsersData.GetUserInfoByUsernameAndPassword(userName, SecurityHelper.HashSHA256(password), ref userId, ref personId, ref isActive, ref lastLogin);

            if (isFound)
            {
                return new ClsUsers(userId, personId, userName, password, lastLogin, isActive);
            }

            return null;

        }

        // Updates a user's active/inactive status.
        public static bool UpdateStatusByUserId(int userId, bool isActive)
        {
            return ClsUsersData.UpdateStatusByUserId(userId, isActive);
        }

        // Saves the linked person first, then inserts a new user record with a hashed password.
        private bool _AddNewUser()
        {
            if (this.Person.Save())
            {
                int userId = ClsUsersData.AddNewUser(this.Person.PersonId, this.UserName, SecurityHelper.HashSHA256(this.Password), this.LastLogin, this.IsActive);
                if (userId > 0)
                {
                    this.PersonId = this.Person.PersonId;
                    this.UserId = userId;
                }
                else
                    return false;
            }
            else
                return false;

            return true;
        }

        // Deletes a user and their linked person record.
        public static bool DeleteUserById(int userId, int personId)
        {

            if (ClsUsersData.DeleteUserById(userId))
            {
                if (ClsPersons.DeletePersonById(personId))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Saves the linked person, then updates the user's username.
        private bool _UpdateUser()
        {
            if (this.Person.Save())
            {
                return ClsUsersData.UpdateUser(this.UserId, this.UserName);
            }
            return false;
        }

        // Saves the user, inserting it if new or updating it if it already exists.
        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (_AddNewUser())
                    {
                        this._mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        // Retrieves all users joined with their linked person details.
        public static DataTable GetAllUsers()
        {
            return ClsUsersData.GetAllUsers();
        }

        // Retrieves a user by ID and returns it as a ClsUsers object, or null if not found.
        public static ClsUsers FindUserByUserId(int userId)
        {
            DataTable dt = ClsUsersData.FindUserByUserId(userId);

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dt.Rows[0];

            return new ClsUsers(
                        Convert.ToInt32(row["user_id"]),
                        Convert.ToInt32(row["person_id"]),
                        row["username"].ToString(),
                        row["password_hash"].ToString(),
                        row["last_login"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["last_login"]),
                        Convert.ToBoolean(row["is_active"])
            );
        }

        // Checks whether a given username is not already taken.
        public static bool IsUsernameAvailable(string userName)
        {
            return ClsUsersData.IsUsernameAvailable(userName);
        }

        // Updates this user's last login timestamp to now.
        public bool UpdateLastLogin()
        {
            return ClsUsersData.UpdateLastLogin(this.UserId, DateTime.Now);
        }

        // Retrieves the person ID linked to a given user ID.
        public static int GetPersonIDByUserID(int userId)
        {
            return ClsUsersData.GetPersonIdByUserId(userId);
        }

        // Checks whether the given password (hashed) matches the stored password for a user.
        public static bool IsPasswordCorrect(int userId, string password)
        {
            return ClsUsersData.IsPasswordCorrect(userId, SecurityHelper.HashSHA256(password));
        }

        // Updates a user's password, storing it as a hashed value.
        public static bool UpdatePassword(int userId, string password)
        {
            return ClsUsersData.UpdatePassword(userId, SecurityHelper.HashSHA256(password));
        }
    }
}