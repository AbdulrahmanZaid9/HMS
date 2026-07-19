using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Utilities;

namespace HMS.Customers
{
    public partial class FrmAddUpdateCustomers : Form
    {
        private enum EnMode
        {
            AddNew,
            Update
        }
        private EnMode _mode;
        private ClsCustomers _customer;
        private int _customerId;

        // Initializes the form in "add new customer" mode.
        public FrmAddUpdateCustomers()
        {
            InitializeComponent();

            _mode = EnMode.AddNew;
        }

        // Initializes the form in "update customer" mode for a specific customer ID.
        public FrmAddUpdateCustomers(int customerId)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _customerId = customerId;
        }

        // Sets up default control values, populates the nationality dropdown, and configures the form title/labels based on mode.
        private void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            dtpDOB.MaxDate = DateTime.Today.AddYears(-18);
            dtpDOB.MinDate = DateTime.Today.AddYears(-150);


            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbGender.SelectedIndex = 0;

            if (_mode == EnMode.AddNew)
            {
                this.Text = "Add Customer — Grand Palace HMS";
                lblTitle.Text = "Add New Customer";
                lblSubtitle.Text = "Fill in the details below to register a new customer";

                _customer = new ClsCustomers();
            }
            else
            {
                this.Text = "Update Customer — Grand Palace HMS";
                lblTitle.Text = "Update Customer";
                lblSubtitle.Text = "Update and manage existing customer details";
            }


        }

        // Loads an existing customer's data by ID and populates the form fields.
        private void _LoadData()
        {
            try
            {
                _customer = ClsCustomers.FindCustomerById(_customerId);

                if (_customer == null)
                {
                    MessageBox.Show(
                        "Customer not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.Close();
                    return;
                }


                if (_customer.Person == null)
                {
                    MessageBox.Show(
                        "Person details not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.Close();
                    return;
                }


                txtFullName.Text = _customer.Person.FullName;
                txtEmail.Text = _customer.Person.Email;
                txtPhone.Text = _customer.Person.Phone;
                txtPassport.Text = _customer.Person.PassportNumber;
                txtAddress.Text = _customer.Person.Address;

                txtNotes.Text = _customer.Person.Notes == null
                    ? string.Empty
                    : _customer.Person.Notes;

                dtpDOB.Value = _customer.Person.DateOfBirth;

                cmbGender.SelectedIndex =
                    _customer.Person.Gender == false ? 0 : 1;

                cmbNationality.SelectedValue =
                    _customer.Person.NationalityId;

                lblCustomerID.Text =
                    _customer.CustomerId.ToString();

                lblPersonID.Text =
                    _customer.PersonId.ToString();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    $"Error while loading customer data. Customer ID: {_customerId}"
                );

                MessageBox.Show(
                    "An unexpected error occurred while loading customer data.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Loads all nationalities into the nationality combo box.
        private void _FillCountriesInComboBox()
        {
            try
            {
                DataTable allCountries = ClsNationality.GetAllNationalities();
                if (allCountries == null || allCountries.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No nationalities were found.",
                        "Loading Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                cmbNationality.DataSource = allCountries;

                cmbNationality.DisplayMember = "country_name";
                cmbNationality.ValueMember = "country_id";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    "Error while loading countries into nationality ComboBox"
                );

                MessageBox.Show(
                    "Unable to load countries. Please try again later.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Closes the form without saving.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handles the form's Load event, resetting defaults and loading existing data if in update mode.
        private void Add_UpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_mode == EnMode.Update)
                _LoadData();
        }

        // Validates the form, checks for duplicate passport (when adding), and saves the customer.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show(
                        "Please correct the highlighted errors.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (_mode == EnMode.AddNew)
                {
                    if (ClsCustomers.IsCustomerExistsByPassport(txtPassport.Text))
                    {
                        MessageBox.Show(
                            "A customer with this passport number already exists. Please enter a different passport number.",
                            "Customer Already Exists",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtPassport.Focus();
                        return;
                    }
                }


                _customer.Person.FullName = txtFullName.Text;
                _customer.Person.Email = txtEmail.Text;
                _customer.Person.Phone = txtPhone.Text;
                _customer.Person.PassportNumber = txtPassport.Text;
                _customer.Person.Address = txtAddress.Text;
                _customer.Person.DateOfBirth = dtpDOB.Value;

                _customer.Person.Gender =
                    cmbGender.SelectedItem.ToString() == "Male"
                        ? false
                        : true;

                _customer.Person.Notes =
                    string.IsNullOrEmpty(txtNotes.Text)
                        ? null
                        : txtNotes.Text;

                _customer.Person.NationalityId =
                    Convert.ToByte(cmbNationality.SelectedValue);



                if (_customer.Save())
                {
                    if (lblCustomerID.Text == "??" &&
                        lblPersonID.Text == "??")
                    {
                        lblCustomerID.Text =
                            _customer.CustomerId.ToString();

                        lblPersonID.Text =
                            _customer.PersonId.ToString();
                    }


                    clsLogger.LogInformation(
                        $"Customer saved successfully. Customer ID: {_customer.CustomerId}"
                    );


                    MessageBox.Show(
                        "Customer details saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    clsLogger.LogWarning(
                        $"Failed to save customer. Customer ID: {_customer.CustomerId}"
                    );


                    MessageBox.Show(
                        "An error occurred while saving customer details.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    $"Error while saving customer. Customer ID: {_customerId}"
                );


                MessageBox.Show(
                    "An unexpected error occurred while saving customer details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validates that the full name field is not empty.
        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full Name is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);

            }
        }

        // Restricts keystrokes in the full name field to letters, single spaces, and backspace.
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidString(e.KeyChar, txtFullName.Text);
        }

        // Validates that the email field contains a properly formatted, non-empty email address.
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (!ClsValidation.ValidateEmail(txtEmail.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email is not in correct format");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);

            }
        }

        // Validates that the passport field is not empty.
        private void txtPassport_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassport.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassport, "Passport is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassport, null);

            }
        }

        // Validates that the address field is not empty.
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "Address is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);

            }
        }

        // Validates that the phone field matches a valid phone number format.
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!ClsValidation.IsValidPhoneNumber((txtPhone.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Phone number is not in correct format");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);

            }
        }

        // Restricts keystrokes in the phone field to digits and a leading '+' sign.
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '+' && ((TextBox)sender).SelectionStart == 0)
                return;

            e.Handled = true;
        }
    }
}