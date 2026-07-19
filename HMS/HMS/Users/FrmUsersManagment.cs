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
    public partial class FrmUsersManagment : Form
    {
        private static DataTable _allUsers;

        // Initializes the form and centers it on screen.
        public FrmUsersManagment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        // Restores the placeholder text in the search box when it loses focus and is empty.
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search by name, ID, passport...";
            }
        }

        // Clears the search box on focus if its content isn't a valid number.
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !ClsValidation.IsNumber(txtSearch.Text))
            {
                txtSearch.Text = "";
            }
        }

        // Sets header text and column widths for the users grid.
        private void _FormatGrid()
        {
            if (dgvUsers.Columns.Count == 0)
                return;

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[1].HeaderText = "Username";
            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[3].HeaderText = "Email";
            dgvUsers.Columns[4].HeaderText = "Phone";
            dgvUsers.Columns[5].HeaderText = "Passport Number";
            dgvUsers.Columns[6].HeaderText = "Gender";

            dgvUsers.Columns[0].Width = 80;
            dgvUsers.Columns[1].Width = 140;
            dgvUsers.Columns[2].Width = 180;
            dgvUsers.Columns[3].Width = 220;
            dgvUsers.Columns[4].Width = 130;
            dgvUsers.Columns[5].Width = 150;
            dgvUsers.Columns[6].Width = 80;
        }

        // Reloads all users, rebinds the grid, and updates the subtitle count.
        private void _RefreshList()
        {
            try
            {
                _allUsers = ClsUsers.GetAllUsers();

                if (_allUsers == null || _allUsers.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No users data was returned.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();

                    return;
                }

                dgvUsers.DataSource = _allUsers;

                lblSubtitle.Text = $"{_allUsers.Rows.Count} of {_allUsers.Rows.Count} users";

                _FormatGrid();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading users list.");

                MessageBox.Show(
                    "An unexpected error occurred while loading users.",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Applies a search row filter to the users data view based on the given column, and updates the subtitle count.
        private void _ApplyFilters(string filterColumn)
        {
            if (_allUsers == null)
                return;

            if (!string.IsNullOrEmpty(txtSearch.Text) &&
                txtSearch.Text != "Search by name, ID, passport...")
            {
                if (filterColumn == "user_id")
                {
                    _allUsers.DefaultView.RowFilter = string.Format(
                        "{0} = '{1}'",
                        filterColumn,
                        txtSearch.Text.Trim().Replace("'", "''"));
                }
                else
                {
                    _allUsers.DefaultView.RowFilter = string.Format(
                        "{0} LIKE '%{1}%'",
                        filterColumn,
                        txtSearch.Text.Trim().Replace("'", "''"));
                }
            }
            else
            {
                _allUsers.DefaultView.RowFilter = string.Empty;
            }

            lblSubtitle.Text = $"{dgvUsers.Rows.Count} of {_allUsers.Rows.Count} Users";
        }

        // Sets the default filter selection and loads the users list when the form loads.
        private void FrmUsersManagment_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            _RefreshList();
        }

        // Determines the active filter column based on the selected search filter and applies it.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            switch (cmbFilter.Text)
            {
                case "User ID":
                    filterColumn = "user_id";
                    break;
                case "Username":
                    filterColumn = "username";
                    break;
                case "Full Name":
                    filterColumn = "full_name";
                    break;
                case "Phone":
                    filterColumn = "phone";
                    break;
                case "Email":
                    filterColumn = "email";
                    break;
                case "Passport Number":
                    filterColumn = "passport_number";
                    break;
                case "Gender":
                    filterColumn = "Gender";
                    break;
                default:
                    filterColumn = "full_name";
                    break;
            }

            _ApplyFilters(filterColumn);
        }

        // Restricts keyboard input in the search box based on the selected filter type.
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "User ID" || cmbFilter.Text == "Phone")
            {
                e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
            }
            else if (cmbFilter.Text == "Full Name")
            {
                e.Handled = !ClsValidation.IsValidString(e.KeyChar, txtSearch.Text);

            }
        }

        // Opens the form to add a new user and refreshes the list afterward.
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateUser addUpdateUserForm = new FrmAddUpdateUser();
                addUpdateUserForm.ShowDialog();
                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening Add User form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the Add User form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the profile view for the selected user and refreshes the list afterward.
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                FrmViewProfile viewProfileForm = new FrmViewProfile(
                    Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value));

                viewProfileForm.ShowDialog();
                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening user profile.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the user profile.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the form to add a new user (via a different menu entry point) and refreshes the list afterward.
        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateUser addUpdateUserForm = new FrmAddUpdateUser();
                addUpdateUserForm.ShowDialog();
                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening Add User form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the Add User form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the edit form for the selected user and refreshes the list afterward.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                FrmAddUpdateUser addUpdateUserForm = new FrmAddUpdateUser(
                    Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value));

                addUpdateUserForm.ShowDialog();
                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening Update User form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the Update User form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms with the user and, if accepted, permanently deletes the selected user and refreshes the list.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {dgvUsers.CurrentRow.Cells[1].Value}?\n\nThis action is permanent.",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                if (ClsUsers.DeleteUserById(
                        Convert.ToInt16(dgvUsers.CurrentRow.Cells["user_id"].Value),
                        ClsUsers.GetPersonIDByUserID(Convert.ToInt16(dgvUsers.CurrentRow.Cells["user_id"].Value))))
                {
                    MessageBox.Show(
                        "User deleted successfully.",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _RefreshList();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to delete the user.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while deleting user.");

                MessageBox.Show(
                    "An unexpected error occurred while deleting the user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms with the user and, if accepted, marks the selected user as active.
        private void activeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
"Are you sure you want to mark this user as active?",
"Confirm Action",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ClsUsers.UpdateStatusByUserId(
                            Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value), true))
                    {
                        MessageBox.Show(
                            "The user has been marked as inactive successfully.",
                            "Operation Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to update the user's status. Please try again.",
                            "Operation Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsLogger.LogError(ex, "Error while updating user status.");

                    MessageBox.Show(
                        "An unexpected error occurred while updating the user's status.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Opens the password verification form for the selected user.
        private void currentReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVerifyPassword verifyPasswordForm =
                    new FrmVerifyPassword(
                        Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value),
                        dgvUsers.CurrentRow.Cells["full_name"].Value.ToString());

                verifyPasswordForm.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening password verification form.");

                MessageBox.Show(
                    "Unable to open the password verification window.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}