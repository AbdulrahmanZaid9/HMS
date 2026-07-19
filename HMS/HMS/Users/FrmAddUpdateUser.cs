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
using Utilities;

namespace HMS.Users
{
    public partial class FrmAddUpdateUser : Form
    {
        private enum EnMode
        {
            AddNew,
            Update
        }
        private EnMode _mode;

        private ClsUsers _user;

        private int _userId;

        // Initializes the form in "add new user" mode.
        public FrmAddUpdateUser()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        // Initializes the form in "update user" mode for the given user ID.
        public FrmAddUpdateUser(int userId)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _userId = userId;
        }

        // Populates countries, date-of-birth bounds, and gender options, and sets the form title/subtitle based on add or update mode.
        private void _ResetDefualtValues()
        {
            try
            {
                _FillCountriesInComoboBox();

                dtpDOB.MaxDate = DateTime.Today.AddYears(-18);
                dtpDOB.MinDate = DateTime.Today.AddYears(-150);


                cmbGender.Items.Add("Male");
                cmbGender.Items.Add("Female");

                cmbGender.SelectedIndex = 0;


                if (_mode == EnMode.AddNew)
                {
                    this.Text = "Add User — Grand Palace HMS";
                    lblTitle.Text = "Add New User";
                    lblSubtitle.Text = "Fill in the details below to register a new User";

                    _user = new ClsUsers();
                }
                else
                {
                    this.Text = "Update User — Grand Palace HMS";
                    lblTitle.Text = "Update User";
                    lblSubtitle.Text = "Update and manage existing User details";

                    txtPassword.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while resetting default values in Add/Update User form.");

                MessageBox.Show(
                    "An unexpected error occurred while preparing the form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the user being updated (with person details) and populates all form fields.
        private void _LoadData()
        {
            try
            {
                _user = ClsUsers.FindUserByUserId(_userId);

                if (_user == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }


                if (_user.Person == null)
                {
                    MessageBox.Show("Person details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }


                txtUsername.Text = _user.UserName;

                txtFullName.Text = _user.Person.FullName;
                txtEmail.Text = _user.Person.Email;
                txtPhone.Text = _user.Person.Phone;
                txtPassport.Text = _user.Person.PassportNumber;
                txtAddress.Text = _user.Person.Address;

                txtNotes.Text = _user.Person.Notes == null ? string.Empty : _user.Person.Notes;

                if (_user.Person.DateOfBirth >= dtpDOB.MinDate &&
                    _user.Person.DateOfBirth <= dtpDOB.MaxDate)
                {
                    dtpDOB.Value = _user.Person.DateOfBirth;
                }

                cmbGender.SelectedIndex = _user.Person.Gender == false ? 0 : 1;

                if (cmbNationality.DataSource != null)
                {
                    cmbNationality.SelectedValue = _user.Person.NationalityId;
                }

                lblUserID.Text = _user.UserId.ToString();
                lblPersonID.Text = _user.Person.PersonId.ToString();

                txtPassword.Text = _user.Password;
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading user data.");

                MessageBox.Show(
                    "An unexpected error occurred while loading user information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads all nationalities into the nationality combo box.
        private void _FillCountriesInComoboBox()
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
                clsLogger.LogError(ex, "Error while loading nationalities into ComboBox.");

                MessageBox.Show(
                    "An unexpected error occurred while loading nationalities.",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Handles form load: resets defaults and, in update mode, loads the existing user's data.
        private void FrmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_mode == EnMode.Update)
                _LoadData();

        }

        // Validates that the username is provided and (for new/changed usernames) available.
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "Username is required");
                    return;
                }

                if (_mode == EnMode.Update && _user.UserName == txtUsername.Text)
                {
                    return;
                }

                if (!ClsUsers.IsUsernameAvailable(txtUsername.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "This username is already taken. Please choose another one.");
                    return;
                }

                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(
                    $"An error occurred while checking the username.\n\nDetails: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validates that a password has been entered.
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);

            }
        }

        // Validates that a full name has been entered.
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

        // Validates that a passport number has been entered.
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

        // Validates that the email is provided and correctly formatted.
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

        // Validates that the phone number is correctly formatted.
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

        // Validates that an address has been entered.
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

        // Restricts keyboard input in the phone field to digits and a leading plus sign.
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

        // Restricts keyboard input in the full name field to valid string characters.
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidString(e.KeyChar, txtFullName.Text);
        }

        // Closes the form without saving.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates input, saves the user (create or update) with their person details, and closes the form.
        private void btnSave_Click(object sender, EventArgs e)
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

            try
            {
                if (_user == null || _user.Person == null)
                {
                    MessageBox.Show(
                        "User information is not loaded correctly.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                _user.Person.FullName = txtFullName.Text;
                _user.Person.Email = txtEmail.Text;
                _user.Person.Phone = txtPhone.Text;
                _user.Person.PassportNumber = txtPassport.Text;
                _user.Person.Address = txtAddress.Text;
                _user.Person.DateOfBirth = dtpDOB.Value;

                _user.Person.Gender = cmbGender.SelectedItem?.ToString() == "Male"
                    ? false
                    : true;

                _user.Person.Notes = string.IsNullOrEmpty(txtNotes.Text)
                    ? null
                    : txtNotes.Text;


                if (cmbNationality.SelectedValue != null)
                {
                    _user.Person.NationalityId = Convert.ToByte(cmbNationality.SelectedValue);
                }


                _user.UserName = txtUsername.Text;
                _user.Password = txtPassword.Text;
                _user.LastLogin = null;
                _user.IsActive = true;


                if (_user.Save())
                {
                    if (lblUserID.Text == "??" && lblPersonID.Text == "??")
                    {
                        lblUserID.Text = _user.UserId.ToString();
                        lblPersonID.Text = _user.PersonId.ToString();
                    }

                    MessageBox.Show(
                        "User details saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An error occurred while saving User details.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while saving user details.");

                MessageBox.Show(
                    "An unexpected error occurred while saving user details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}