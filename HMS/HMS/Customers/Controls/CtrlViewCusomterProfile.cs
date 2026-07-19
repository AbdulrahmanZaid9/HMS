using HMS.Global_Classes;
using HMS.reservations;
using HMS_Buisness;
using Serilog;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utilities;
namespace HMS.Customers.Controls
{
    public partial class CtrlViewCusomterProfile : UserControl
    {
        private ClsCustomers _customer;

        // Initializes the user control and its designer-generated components.
        public CtrlViewCusomterProfile()
        {
            InitializeComponent();
        }

        // Loads a customer's data by ID and populates all profile labels/tooltips in the UI.
        public void LoadCustomerProfile(int customerId)
        {
            try
            {
                _customer = ClsCustomers.FindCustomerById(customerId);

                if (_customer == null)
                {
                    MessageBox.Show(
                        $"No customer was found with ID #{customerId}.\n\n" +
                        "Please verify the ID and try again.",
                        "Customer Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                lblName.Text = _customer.Person.FullName;
                lblCustIdBadge.Text = $"CUST #{customerId}";
                lblPersonIdBadge.Text = $"PERSON #{_customer.PersonId}";

                lblStatusBadge.Text = _customer.IsActive ? "Active" : "Inactive";

                lblStatusBadge.BackColor = _customer.IsActive
                    ? Color.FromArgb(22, 101, 52)
                    : Color.FromArgb(127, 29, 29);

                lblStatusBadge.ForeColor = _customer.IsActive
                    ? Color.FromArgb(187, 247, 208)
                    : Color.FromArgb(254, 202, 202);

                lblEmail.Text = string.IsNullOrWhiteSpace(_customer.Person.Email)
                    ? "—"
                    : _customer.Person.Email;

                lblPhone.Text = string.IsNullOrWhiteSpace(_customer.Person.Phone)
                    ? "—"
                    : _customer.Person.Phone;

                lblAddress.Text = string.IsNullOrWhiteSpace(_customer.Person.Address)
                    ? "—"
                    : _customer.Person.Address;

                lblDOB.Text = string.IsNullOrWhiteSpace(
                    clsUtil.FormatDate(_customer.Person.DateOfBirth))
                        ? "—"
                        : clsUtil.FormatDate(_customer.Person.DateOfBirth);

                lblGender.Text = _customer.Person.Gender == false
                    ? "Male"
                    : "Female";

                lblNationality.Text =
                    string.IsNullOrWhiteSpace(_customer.Person.Nationality.CountryName)
                        ? "—"
                        : _customer.Person.Nationality.CountryName;

                lblPassport.Text =
                    string.IsNullOrWhiteSpace(_customer.Person.PassportNumber)
                        ? "—"
                        : _customer.Person.PassportNumber;

                lblNotes.Text =
                    string.IsNullOrWhiteSpace(_customer.Person.Notes)
                        ? "—"
                        : _customer.Person.Notes;

                lblTimestamps.Text =
                    $"Created {_customer.Person.CreatedAt}  ·  Last updated {_customer.Person.UpdatedAt}";

                toolTip1.SetToolTip(lblAddress, _customer.Person.Address);
                toolTip1.SetToolTip(lblEmail, _customer.Person.Email);

                if (lblNotes.Text == "—")
                    toolTip1.SetToolTip(lblNotes, "No Notes");
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    $"Error while loading customer profile. Customer ID: {customerId}"
                );

                MessageBox.Show(
                    "An unexpected error occurred while loading customer profile.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Opens the Add/Update Customer form pre-loaded with the currently displayed customer.
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateCustomers frm = new FrmAddUpdateCustomers(_customer.CustomerId);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening the Add/Update Customer form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the customer details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Closes the parent form containing this control.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}