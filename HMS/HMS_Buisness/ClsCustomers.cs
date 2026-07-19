using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsCustomers
    {
        public enum EnMode
        {
            Add = 1,
            Update = 2,
        }
        public EnMode mode = EnMode.Add;
        public int CustomerId { get; set; }
        public int PersonId { get; set; }
        public bool IsActive { get; set; }
        public ClsPersons Person { get; set; }

        // Creates a new, unsaved customer in "add" mode with a fresh associated person.
        public ClsCustomers()
        {
            this.CustomerId = -1;
            this.PersonId = -1;
            this.IsActive = true;
            this.Person = new ClsPersons();
            mode = EnMode.Add;
        }

        // Creates a customer object from existing data, loading its linked person, and puts it in "update" mode.
        public ClsCustomers(int customerId, int personId, bool isActive)
        {
            this.CustomerId = customerId;
            this.PersonId = personId;
            this.IsActive = isActive;
            this.Person = ClsPersons.FindPersonById(personId);
            mode = EnMode.Update;
        }

        // Persists changes to the customer's linked person record.
        private bool _UpdateCustomer()
        {
            return this.Person.Save();
        }

        // Saves the linked person first, then inserts a new customer record tied to it.
        private bool _AddNewCustomer()
        {
            if (this.Person.Save())
            {
                int newPersonID = ClsCustomersData.AddNewCustomer(this.Person.PersonId);
                if (newPersonID > 0)
                {
                    this.PersonId = this.Person.PersonId;
                    this.CustomerId = newPersonID;
                    this.IsActive = true;
                }
                else
                    return false;
            }
            else
                return false;

            return true;
        }

        // Saves the customer, inserting it if new or updating it if it already exists.
        public bool Save()
        {
            switch (mode)
            {
                case EnMode.Add:
                    if (_AddNewCustomer())
                    {
                        this.mode = EnMode.Update;
                        return true;
                    }
                    else
                        return false;
                case EnMode.Update:
                    return _UpdateCustomer();
            }
            return false;
        }

        // Retrieves all customers.
        public static DataTable GetAllCustomers()
        {
            return ClsCustomersData.GetAllCustomers();
        }

        // Retrieves all customers filtered by active or inactive status.
        public static DataTable GetActiveOrInactiveCustomers(bool IsActive)
        {
            return ClsCustomersData.GetActiveOrInactiveCustomers(IsActive);
        }

        // Retrieves a customer by ID and returns it as a ClsCustomers object, or null if not found.
        public static ClsCustomers FindCustomerById(int customer_id)
        {

            int person_id = -1;
            bool is_active = false;
            if (ClsCustomersData.FindCustomerById(customer_id, ref person_id, ref is_active))
            {
                return new ClsCustomers(
                    customer_id,
                    person_id,
                    is_active
                    );
            }
            else
                return null;
        }

        // Deletes a customer and their linked person record.
        public static bool DeleteCusomterById(int customer_id, int PersonID)
        {

            if (ClsCustomersData.DeleteCusomterById(customer_id))
            {
                if (ClsPersons.DeletePersonById(PersonID))
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

        // Updates a customer's active/inactive status.
        public static bool UpdateStatusByCustomerID(int customer_id, bool Status)
        {
            return ClsCustomersData.UpdateStatusByCustomerID(customer_id, Status);
        }

        // Checks whether a customer already exists with the given passport number.
        public static bool IsCustomerExistsByPassport(string Passport)
        {
            return ClsCustomersData.IsCustomerExistsByPassport(Passport);
        }

        // Retrieves the person ID linked to a given customer ID.
        public static int GetPersonIdByCustomerId(int customer_id)
        {
            return ClsCustomersData.GetPersonIdByCustomerId(customer_id);
        }
    }
}