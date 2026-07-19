using HMS.Customers;
using HMS.Global_Classes;
using HMS.Rooms;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.reservations
{
    public partial class FrmReservationsManagment : Form
    {
        private static DataTable _allReservations;
        string FilterColumn = "";

        // Initializes the form and its designer-generated components.
        public FrmReservationsManagment()
        {
            InitializeComponent();
        }

        // Sets header text, column widths, and number formatting for the reservations grid.
        private void _FormatGrid()
        {
            if (dgvReservations.Columns.Count == 0) return;

            dgvReservations.Columns[0].HeaderText = "Reservation ID";
            dgvReservations.Columns[1].HeaderText = "Customer ID";
            dgvReservations.Columns[2].HeaderText = "Room ID";
            dgvReservations.Columns[3].HeaderText = "Check In Date";
            dgvReservations.Columns[4].HeaderText = "Check Out Date";
            dgvReservations.Columns[5].HeaderText = "Actual Check Out";
            dgvReservations.Columns[6].HeaderText = "Actual Check In";
            dgvReservations.Columns[7].HeaderText = "Nights";
            dgvReservations.Columns[8].HeaderText = "Total Price";
            dgvReservations.Columns[9].HeaderText = "Status";
            dgvReservations.Columns[10].HeaderText = "Notes";

            dgvReservations.Columns[0].Width = 120;
            dgvReservations.Columns[1].Width = 100;
            dgvReservations.Columns[2].Width = 80;
            dgvReservations.Columns[3].Width = 140;
            dgvReservations.Columns[4].Width = 140;
            dgvReservations.Columns[5].Width = 150;
            dgvReservations.Columns[6].Width = 150;
            dgvReservations.Columns[7].Width = 70;
            dgvReservations.Columns[8].Width = 100;
            dgvReservations.Columns[9].Width = 100;
            dgvReservations.Columns[10].Width = 220;

            dgvReservations.Columns[8].DefaultCellStyle.Format = "N2";
        }

        // Reloads all reservations, rebinds the grid, reapplies filters, and updates the subtitle count.
        private void _RefreshList()
        {
            try
            {
                _allReservations = ClsReservations.GetAllReservations();

                if (_allReservations == null || _allReservations.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load reservations data.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();

                    return;
                }

                dgvReservations.DataSource = _allReservations;

                _FormatGrid();

                _ApplyFilters();

                lblSubtitle.Text = $"{dgvReservations.Rows.Count} of {_allReservations.Rows.Count} reservations";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing reservations list.");

                MessageBox.Show(
                    "An unexpected error occurred while loading reservations.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads initial reservation data, sets default filter selections, and populates the grid on form load.
        private void FrmReservationsManagment_Load(object sender, EventArgs e)
        {
            try
            {
                _allReservations = ClsReservations.GetAllReservations();

                if (_allReservations == null || _allReservations.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load reservations data.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();

                    return;
                }
                cmbSearchFilter.SelectedIndex = 0;

                cmbStatusFilter.SelectedIndex = 0;

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading reservations management form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening reservations management.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Clears the search box on focus if its content isn't a valid number.
        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !ClsValidation.IsNumber(txtSearch.Text))
            {
                txtSearch.Text = "";
            }
        }

        // Restores the placeholder text in the search box when it loses focus and is empty.
        private void txtSearch_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search Customer ID, Room ID ....";
            }
        }

        // Determines the active filter column based on the selected search filter and refreshes the list.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchFilter.Text)
            {
                case "Customer ID":
                    FilterColumn = "customer_id";
                    break;
                case "Room ID":
                    FilterColumn = "room_id";
                    break;
                case "Reservations ID":
                    FilterColumn = "reservation_id";
                    break;
                default:
                    FilterColumn = "full_name";
                    break;
            }

            _RefreshList();

        }

        // Refreshes the list when the status filter selection changes.
        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshList();
        }

        // Builds and applies a combined status/search row filter to the reservations data view.
        private void _ApplyFilters()
        {
            List<string> filters = new List<string>();

            // Status filter
            if (cmbStatusFilter.Text != "All Status")
            {
                filters.Add(string.Format(
                    "StatusText LIKE '%{0}%'", (cmbStatusFilter.Text.Trim())
                ));
            }

            // Search filter
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (int.TryParse(txtSearch.Text.Trim(), out int value))
                {
                    filters.Add(string.Format("{0} = '{1}'", FilterColumn, txtSearch.Text.Trim().Replace("'", "''")));
                }
            }
            // Combine filters
            if (_allReservations != null && _allReservations.Rows.Count > 0)
            {
                _allReservations.DefaultView.RowFilter = string.Join(" AND ", filters);
            }
        }

        // Restricts keyboard input in the search box to valid integer characters.
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
        }

        // Opens the room view/history form for the selected reservation's room.
        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservations.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Please select a reservation first.",
                        "No Selection",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                short roomId = Convert.ToInt16(dgvReservations.CurrentRow.Cells["room_id"].Value);


                FrmViewRoom viewRoomForm = new FrmViewRoom(roomId);

                viewRoomForm.ShowDialog();


                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening room details from reservations.");

                MessageBox.Show(
                    "An unexpected error occurred while opening room details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Enables/disables context menu items based on the selected reservation's current status.
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            editToolStripMenuItem.Enabled = true;
            reservationStatusToolStripMenuItem.Enabled = true;
            addServiceToolStripMenuItem.Enabled = true;
            checkInToolStripMenuItem.Enabled = true;
            checkOutToolStripMenuItem.Enabled = true;

            if (dgvReservations.CurrentRow.Cells["StatusText"].Value.ToString() == ClsReservations.GetReservationStatus(ClsReservations.EnReservationStatus.Cancelled))
            {
                editToolStripMenuItem.Enabled = false;
                reservationStatusToolStripMenuItem.Enabled = false;
                addServiceToolStripMenuItem.Enabled = false;
                checkInToolStripMenuItem.Enabled = false;
                checkOutToolStripMenuItem.Enabled = false;
            }
            else if (dgvReservations.CurrentRow.Cells["StatusText"].Value.ToString() == ClsReservations.GetReservationStatus(ClsReservations.EnReservationStatus.CheckedIn))
            {
                checkInToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;

            }
            else if (dgvReservations.CurrentRow.Cells["StatusText"].Value.ToString() == ClsReservations.GetReservationStatus(ClsReservations.EnReservationStatus.Confirmed))
            {
                checkOutToolStripMenuItem.Enabled = false;
                addServiceToolStripMenuItem.Enabled = false;

            }
            else if (dgvReservations.CurrentRow.Cells["StatusText"].Value.ToString() == ClsReservations.GetReservationStatus(ClsReservations.EnReservationStatus.CheckedOut))
            {
                reservationStatusToolStripMenuItem.Enabled = false;
                addServiceToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                checkInToolStripMenuItem.Enabled = false;
            }
        }

        // Opens the selected reservation's customer profile view.
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["customer_id"].Value);

                FrmViewCustomerInfo customerInfoForm = new FrmViewCustomerInfo(customerId);

                customerInfoForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening customer profile from reservations.");

                MessageBox.Show(
                    "An unexpected error occurred while opening customer information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the form to create a new reservation and refreshes the list afterward.
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateReservations addUpdateReservationForm = new FrmAddUpdateReservations();

                addUpdateReservationForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening add reservation form.");

                MessageBox.Show(
                    "An unexpected error occurred while creating a reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the edit form for the selected reservation and refreshes the list afterward.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);


                FrmAddUpdateReservations addUpdateReservationForm =
                    new FrmAddUpdateReservations(reservationId);


                addUpdateReservationForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening edit reservation form.");

                MessageBox.Show(
                    "An unexpected error occurred while editing reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the current reservation details view for the selected reservation and refreshes the list afterward.
        private void currentReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);


                FrmCurrentReservation currentReservationForm =
                    new FrmCurrentReservation(reservationId);


                currentReservationForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening current reservation.");

                MessageBox.Show(
                    "An unexpected error occurred while opening current reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the check-in details form for the selected reservation and refreshes the list afterward.
        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);


                FrmReservationDetailsCheckIn reservationDetailsForm =
                    new FrmReservationDetailsCheckIn(reservationId);


                reservationDetailsForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening check-in reservation details.");

                MessageBox.Show(
                    "An unexpected error occurred while opening check-in details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms with the user and, if accepted, permanently deletes the selected reservation and refreshes the list.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Reservation With ID {dgvReservations.CurrentRow.Cells[0].Value}?\n\nThis action is permanent.",
                    "Delete Reservation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    if (ClsReservations.DeleteReservationById(Convert.ToInt16(dgvReservations.CurrentRow.Cells["reservation_id"].Value)))
                    {
                        clsLogger.LogInformation("Reservation deleted successfully.");

                        MessageBox.Show(
                            "Reservation deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        _RefreshList();
                    }
                    else
                    {
                        clsLogger.LogWarning("Failed to delete reservation.");

                        MessageBox.Show(
                            "Failed to delete reservation.\n\nPlease try again or contact support.",
                            "Delete Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while deleting reservation.");

                MessageBox.Show(
                    "An unexpected error occurred while deleting reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms with the user and, if accepted, cancels the selected reservation and refreshes the list.
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to cancel Reservation With ID {dgvReservations.CurrentRow.Cells[0].Value}?\n\nThis action is permanent.",
                    "Cancel Reservation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    if (ClsReservations.ChangeReservationStatus(
                        ClsReservations.EnReservationStatus.Cancelled,
                        Convert.ToInt32(dgvReservations.CurrentRow.Cells["reservation_id"].Value)))
                    {
                        clsLogger.LogInformation("Reservation cancelled successfully.");

                        MessageBox.Show(
                            "Reservation canceled successfully.",
                            "Canceled",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        _RefreshList();
                    }
                    else
                    {
                        clsLogger.LogWarning("Failed to cancel reservation.");

                        MessageBox.Show(
                            "Failed to cancel reservation.\n\nPlease try again or contact support.",
                            "Cancel Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while cancelling reservation.");

                MessageBox.Show(
                    "An unexpected error occurred while cancelling reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the checkout details form for the selected reservation and refreshes the list afterward.
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);


                FrmReservationDetailsCheckOut checkOutForm =
                    new FrmReservationDetailsCheckOut(reservationId);


                checkOutForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening checkout form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening checkout.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the add-service-to-bill form for the selected reservation's bill.
        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);


                int billId = ClsBills.GetBillIdByReservationId(reservationId);


                FrmAddServicetoBill serviceToBill =
                    new FrmAddServicetoBill(reservationId, billId);


                serviceToBill.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening add service to bill form.");

                MessageBox.Show(
                    "An unexpected error occurred while adding service.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the bill summary view for the selected reservation.
        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["reservation_id"].Value);

                int billId = ClsBills.GetBillIdByReservationId(reservationId);

                int customerId = Convert.ToInt32(
                    dgvReservations.CurrentRow.Cells["customer_id"].Value);

                byte roomId = Convert.ToByte(
                    dgvReservations.CurrentRow.Cells["room_id"].Value);


                FrmBillSummaryView bill =
                    new FrmBillSummaryView(reservationId, billId, roomId, customerId);


                bill.ShowDialog();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening bill summary.");

                MessageBox.Show(
                    "An unexpected error occurred while opening bill.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}