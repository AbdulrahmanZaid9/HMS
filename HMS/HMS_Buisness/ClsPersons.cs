using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsPersons
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        public byte NationalityId { get; set; }
        public string Notes { get; set; }
        public string PassportNumber { get; set; }
        public ClsNationality Nationality { get; set; }

        public enum EnMode
        {
            Add = 1,
            Update = 2,
        }
        public EnMode _mode = EnMode.Add;

        // Creates a new, unsaved person in "add" mode with default values.
        public ClsPersons()
        {
            this.PersonId = 0;
            this.FullName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.DateOfBirth = DateTime.MinValue;
            this.Address = string.Empty;
            this.NationalityId = 0;
            this.Notes = string.Empty;
            this.PassportNumber = string.Empty;
            this.Nationality = new ClsNationality();
            this.Gender = true;
            _mode = EnMode.Add;
        }

        // Creates a person object from existing data, loading its linked nationality, and puts it in "update" mode.
        public ClsPersons(int personId, string fullName, string email, string phone, DateTime dateOfBirth,
    string address, byte nationalityId, string notes, string passportNumber
    , bool gender, DateTime createdAt, DateTime updatedAt)
        {
            this.PersonId = personId;
            this.FullName = fullName;
            this.Email = email;
            this.Phone = phone;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.NationalityId = nationalityId;
            this.Notes = notes;
            this.PassportNumber = passportNumber;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Nationality = ClsNationality.FindNationalityById(nationalityId);
            _mode = EnMode.Update;

        }

        // Persists changes to an existing person in the database.
        private bool _UpdatePerson()
        {
            return ClsPersonsData.UpdatePerson(this.PersonId, this.FullName, this.Email, this.Phone, this.DateOfBirth, this.Address, this.NationalityId, this.Notes, this.PassportNumber, this.Gender);
        }

        // Inserts this person as a new record and stores the generated person ID.
        private bool _AddNewPerson()
        {
            int newPersonId = ClsPersonsData.AddNewPerson(this.FullName, this.Email, this.Phone, this.DateOfBirth, this.Address, this.NationalityId, this.Notes, this.PassportNumber, this.Gender);
            if (newPersonId > 0)
            {
                this.PersonId = newPersonId;
                return true;
            }
            return false;
        }

        // Saves the person, inserting it if new or updating it if it already exists.
        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.Add:
                    if (_AddNewPerson())
                    {
                        this._mode = EnMode.Update;
                        return true;
                    }
                    else
                        return false;
                case EnMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        // Retrieves all person records.
        public static DataTable GetAllPersons()
        {
            return ClsPersonsData.GetAllPersons();
        }

        // Retrieves a person by ID and returns it as a ClsPersons object, or null if not found.
        public static ClsPersons FindPersonById(int personId)
        {
            string fullName = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            DateTime dateOfBirth = DateTime.MinValue;
            string address = string.Empty;
            byte nationalityId = 0;
            string notes = string.Empty;
            string passportNumber = string.Empty;
            bool gender = false;
            DateTime createdAt = DateTime.MinValue;
            DateTime updatedAt = DateTime.MinValue;

            if (ClsPersonsData.FindPersonById(personId, ref fullName, ref phone, ref email, ref dateOfBirth, ref address, ref nationalityId, ref notes, ref passportNumber, ref gender, ref createdAt, ref updatedAt))
            {
                return new ClsPersons(personId, fullName, email, phone, dateOfBirth, address, nationalityId, notes, passportNumber, gender, createdAt, updatedAt);
            }
            else
                return null;

        }

        // Deletes a person record by its person ID.
        public static bool DeletePersonById(int personId)
        {
            return ClsPersonsData.DeletePersonById(personId);
        }
    }
}