using HMS.Global_Classes;
using HMS.reservations;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS.Customers
{
    public partial class FrmCustomersMangement : Form
    {
        private static DataTable _allCustomers;

        private static DataTable _allCustomersView;

        // Initializes the customers management form and its designer-generated components.
        public FrmCustomersMangement()
        {
            InitializeComponent();
        }

        // Loads all customers into the grid when the form first loads.
        private void FrmCustomersMangement_Load(object sender, EventArgs e)
        {
            try
            {
                _allCustomers = ClsCustomers.GetAllCustomers();

                if (_allCustomers == null || _allCustomers.Rows.Count == 0)
                {
                    clsLogger.LogWarning("GetAllCustomers returned null in FrmCustomersMangement_Load");

                    MessageBox.Show(
                        "Unable to load customers.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _allCustomersView = _allCustomers.DefaultView.ToTable(false, "customer_id", "full_name", "country_name", "passport_number", "email", "notes", "phone", "date_of_birth", "Gender");

                cmbFilter.SelectedIndex = 0;

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading customers management form");

                MessageBox.Show(
                    "An unexpected error occurred while loading customers.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Sets the header text and column widths for the customers grid.
        private void _FormatGrid()
        {
            if (dgvCustomers.Columns.Count == 0) return;

            dgvCustomers.Columns[0].HeaderText = "Customer ID";
            dgvCustomers.Columns[1].HeaderText = "Full Name";
            dgvCustomers.Columns[2].HeaderText = "Country";
            dgvCustomers.Columns[3].HeaderText = "Passport Number";
            dgvCustomers.Columns[4].HeaderText = "Email";
            dgvCustomers.Columns[5].HeaderText = "Notes";
            dgvCustomers.Columns[6].HeaderText = "Phone";
            dgvCustomers.Columns[7].HeaderText = "Date Of Birth";
            dgvCustomers.Columns[8].HeaderText = "Gender";

            dgvCustomers.Columns[0].Width = 90;
            dgvCustomers.Columns[1].Width = 150;
            dgvCustomers.Columns[2].Width = 120;
            dgvCustomers.Columns[3].Width = 160;
            dgvCustomers.Columns[4].Width = 200;
            dgvCustomers.Columns[5].Width = 180;
            dgvCustomers.Columns[6].Width = 120;
            dgvCustomers.Columns[7].Width = 140;
            dgvCustomers.Columns[8].Width = 80;
        }

        // Reloads all customers from the database and rebinds them to the grid.
        private void _RefreshList()
        {
            try
            {
                _allCustomers = ClsCustomers.GetAllCustomers();

                if (_allCustomers == null || _allCustomers.Rows.Count == 0)
                {
                    clsLogger.LogWarning("GetAllCustomers returned null in FrmCustomersMangement_Load");

                    MessageBox.Show(
                        "Unable to load customers.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _allCustomersView = _allCustomers.DefaultView.ToTable(false, "customer_id", "full_name", "country_name", "passport_number", "email", "notes", "phone", "date_of_birth", "Gender");

                dgvCustomers.DataSource = _allCustomersView;

                lblSubtitle.Text = $"{_allCustomersView.Rows.Count} of {_allCustomers.Rows.Count} customers";

                _FormatGrid();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing customers list");

                MessageBox.Show(
                    "An unexpected error occurred while refreshing customers list.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Clears the search box placeholder text when it's non-numeric and the field gains focus.
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !ClsValidation.IsNumber(txtSearch.Text))
            {
                txtSearch.Text = "";
            }
        }

        // Restores the search box placeholder text if left empty.
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search by name, ID, passport...";
            }

        }

        // Applies a row filter to the customers view based on the search text and selected filter column.
        private void _ApplyFilters(string filterColumn)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Search by name, ID, passport...")
                {
                    if (filterColumn == "customer_id")
                    {
                        _allCustomersView.DefaultView.RowFilter = string.Format("{0} = '{1}'", filterColumn, txtSearch.Text.Trim().Replace("'", "''"));
                    }
                    else
                    {
                        _allCustomersView.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", filterColumn, txtSearch.Text.Trim().Replace("'", "''"));
                    }
                }
                else
                {
                    _allCustomersView.DefaultView.RowFilter = string.Empty;
                }

                lblSubtitle.Text = $"{_allCustomersView.DefaultView.Count} of {_allCustomers.Rows.Count} customers";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while applying customer filters. Filter column: {filterColumn}");

                MessageBox.Show(
                    "An unexpected error occurred while filtering customers.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Determines the target filter column based on the selected filter dropdown and applies the filter.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            switch (cmbFilter.Text)
            {
                case "Customer ID":
                    filterColumn = "customer_id";
                    break;
                case "Full Name":
                    filterColumn = "full_name";
                    break;
                case "Country":
                    filterColumn = "country_name";
                    break;
                case "Passport Number":
                    filterColumn = "passport_number";
                    break;
                case "Email":
                    filterColumn = "email";
                    break;
                case "Phone":
                    filterColumn = "phone";
                    break;
                default:
                    filterColumn = "full_name";
                    break;
            }

            _ApplyFilters(filterColumn);


        }

        // Restricts keystrokes in the search box depending on which filter column is currently selected.
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Customer ID" || cmbFilter.Text == "Phone")
            {
                e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
            }
            else if (cmbFilter.Text == "Full Name")
            {
                e.Handled = !ClsValidation.IsValidString(e.KeyChar, txtSearch.Text);

            }

        }

        // Opens the Add Customer form and refreshes the list afterward.
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateCustomers addUpdateCustomersForm = new FrmAddUpdateCustomers();
                addUpdateCustomersForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening add customer form");

                MessageBox.Show(
                    "An unexpected error occurred while adding a customer.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the Edit Customer form for the currently selected row and refreshes the list afterward.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("Edit customer attempted without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);

                FrmAddUpdateCustomers updateCustomerForm = new FrmAddUpdateCustomers(customerId);
                updateCustomerForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening edit customer form");

                MessageBox.Show(
                    "An unexpected error occurred while editing customer.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the profile view form for the currently selected customer.
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("View customer profile attempted without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);

                FrmViewCustomerInfo customerInfoForm = new FrmViewCustomerInfo(customerId);
                customerInfoForm.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening customer profile form");

                MessageBox.Show(
                    "An unexpected error occurred while viewing customer profile.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms and deletes the currently selected customer, then refreshes the list.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("Delete customer attempted without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete {dgvCustomers.CurrentRow.Cells[1].Value}?\n\nThis action is permanent.",
                    "Delete Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    int personId = ClsCustomers.GetPersonIdByCustomerId(customerId);

                    if (ClsCustomers.DeleteCusomterById(customerId, personId))
                    {
                        clsLogger.LogInformation($"Customer deleted successfully. Customer ID: {customerId}");

                        MessageBox.Show(
                            "Customer deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        _RefreshList();
                    }
                    else
                    {
                        clsLogger.LogWarning($"Failed to delete customer. Customer ID: {customerId}");

                        MessageBox.Show(
                            "Failed to delete customer.\n\nPlease try again or contact support.",
                            "Delete Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while deleting customer");

                MessageBox.Show(
                    "An unexpected error occurred while deleting customer.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the currently selected customer's active reservation, if one exists.
        private void currentReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("Opening current reservation without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);

                int reservationId = ClsReservations.GetReservationIdByCustomerId(customerId);

                if (reservationId <= 0)
                {
                    MessageBox.Show(
                        "The selected customer does not have an active reservation.",
                        "No Active Reservation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    FrmCurrentReservation currentReservation = new FrmCurrentReservation(reservationId);
                    currentReservation.ShowDialog();

                    _RefreshList();
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening current reservation");

                MessageBox.Show(
                    "An unexpected error occurred while opening the current reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Marks the currently selected customer as inactive after confirmation.
        private void activeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("Updating customer status without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                DialogResult result = MessageBox.Show(
                    "Are you sure you want to mark this customer as inactive?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);

                    if (ClsCustomers.UpdateStatusByCustomerID(customerId, true))
                    {
                        clsLogger.LogInformation($"Customer marked as inactive. Customer ID: {customerId}");

                        MessageBox.Show(
                            "The customer has been marked as inactive successfully.",
                            "Operation Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        clsLogger.LogWarning($"Failed to update customer status. Customer ID: {customerId}");

                        MessageBox.Show(
                            "Failed to update the customer's status. Please try again.",
                            "Operation Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while updating customer status");

                MessageBox.Show(
                    "An unexpected error occurred while updating customer status.",
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the reservation history form for the currently selected customer.
        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow == null)
                {
                    clsLogger.LogWarning("Opening reservation history without selecting a customer");

                    MessageBox.Show(
                        "Please select a customer first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["customer_id"].Value);
                string fullName = dgvCustomers.CurrentRow.Cells["full_name"].Value.ToString();

                FrmReservationHistory reservationHistoryForm = new FrmReservationHistory(customerId, fullName);
                reservationHistoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening reservation history");

                MessageBox.Show(
                    "An unexpected error occurred while opening reservation history.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}