using HMS.Customers;
using HMS.Global_Classes;
using HMS.reservations;
using HMS.Rooms;
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

namespace HMS.ServicesBooking
{
    public partial class FrmServicesBookingManagment : Form
    {

        private static DataTable _allServicesBooking;
        string filterColumn;

        // Initializes the form, configures its window style/position, and defaults the status filter selection.
        public FrmServicesBookingManagment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            cmbStatusFilter.SelectedIndex = 0;

        }

        // Sets header text and column widths for the service bookings grid.
        private void _FormatGrid()
        {
            if (dgvServices.Columns.Count == 0) return;

            dgvServices.Columns[0].HeaderText = "Booking ID";
            dgvServices.Columns[1].HeaderText = "Customer Name";
            dgvServices.Columns[2].HeaderText = "Room No.";
            dgvServices.Columns[3].HeaderText = "Service";
            dgvServices.Columns[4].HeaderText = "Description";
            dgvServices.Columns[5].HeaderText = "Price";
            dgvServices.Columns[6].HeaderText = "Service Date";
            dgvServices.Columns[7].HeaderText = "Reservation ID";
            dgvServices.Columns[8].HeaderText = "Service ID";
            dgvServices.Columns[9].HeaderText = "Bill ID";
            dgvServices.Columns[10].HeaderText = "Customer ID";
            dgvServices.Columns[11].HeaderText = "Room ID";

            dgvServices.Columns[0].Width = 90;
            dgvServices.Columns[1].Width = 180;
            dgvServices.Columns[2].Width = 80;
            dgvServices.Columns[3].Width = 150;
            dgvServices.Columns[4].Width = 250;
            dgvServices.Columns[5].Width = 90;
            dgvServices.Columns[6].Width = 140;
            dgvServices.Columns[7].Width = 110;
            dgvServices.Columns[8].Width = 90;
            dgvServices.Columns[9].Width = 80;
            dgvServices.Columns[10].Width = 100;
            dgvServices.Columns[11].Width = 80;

            dgvServices.Columns[5].DefaultCellStyle.Format = "N2";
        }

        // Reloads all active service bookings, rebinds the grid, reapplies filters, and updates the subtitle count.
        private void _RefreshList()
        {
            try
            {
                _allServicesBooking = ClsServiceBookings.GetAllActiveServiceBookings();

                if (_allServicesBooking == null || _allServicesBooking.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load service bookings.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                dgvServices.DataSource = _allServicesBooking;

                _FormatGrid();

                _ApplyFilters();

                lblSubtitle.Text = $"{dgvServices.Rows.Count} of {_allServicesBooking.Rows.Count} Booking";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing service bookings list.");

                MessageBox.Show(
                    "An unexpected error occurred while loading service bookings.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Builds and applies a search-based row filter (by name, room number, or service name) to the bookings data view.
        private void _ApplyFilters()
        {
            try
            {
                if (_allServicesBooking == null)
                    return;

                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(txtSearch.Text) &&
                    txtSearch.Text != "Search Customer Name, Room Number ....")
                {
                    if (filterColumn == "room_number")
                    {
                        filters.Add(
                            string.Format("{0} = '{1}'",
                            filterColumn,
                            txtSearch.Text.Trim().Replace("'", "''")));
                    }
                    else if (filterColumn == "full_name" || filterColumn == "service_name")
                    {
                        filters.Add(
                            string.Format("{0} LIKE '%{1}%'",
                            filterColumn,
                            txtSearch.Text.Trim().Replace("'", "''")));
                    }
                }

                _allServicesBooking.DefaultView.RowFilter = string.Join(" AND ", filters);
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while applying service booking filters.");
            }
        }

        // Restores the placeholder text in the search box when it loses focus and is empty.
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search Customer Name, Room Number ....";
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

        // Restricts keyboard input in the search box based on the selected filter type (integer for room number, string otherwise).
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbStatusFilter.Text == "Room Number")
            {
                e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
            }
            else
            {
                e.Handled = !ClsValidation.IsValidString(e.KeyChar, txtSearch.Text);

            }
        }

        // Determines the active filter column based on the selected search filter and refreshes the list.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbStatusFilter.Text)
            {
                case "Customer Name":
                    filterColumn = "full_name";
                    break;
                case "Room Number":
                    filterColumn = "room_number";
                    break;
                case "Service Name":
                    filterColumn = "service_name";
                    break;
                default:
                    filterColumn = "full_name";
                    break;
            }

            _RefreshList();
        }

        // Opens the customer profile view for the selected booking's customer.
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmViewCustomerInfo customerInfoForm = new FrmViewCustomerInfo(
                    Convert.ToInt32(dgvServices.CurrentRow.Cells["customer_id"].Value));

                customerInfoForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening customer profile from service bookings.");

                MessageBox.Show(
                    "An unexpected error occurred while opening customer profile.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the current reservation view for the selected booking's reservation.
        private void currentReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCurrentReservation currentReservationForm = new FrmCurrentReservation(
                    Convert.ToInt32(dgvServices.CurrentRow.Cells["reservation_id"].Value));

                currentReservationForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening current reservation.");

                MessageBox.Show(
                    "An unexpected error occurred while opening reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the room view for the selected booking's room.
        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmViewRoom viewRoomForm = new FrmViewRoom(
                    Convert.ToInt16(dgvServices.CurrentRow.Cells["room_id"].Value));

                viewRoomForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening room details.");

                MessageBox.Show(
                    "An unexpected error occurred while opening room details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Confirms with the user and, if accepted, permanently deletes the selected service booking and refreshes the list.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Booking With ID {dgvServices.CurrentRow.Cells[0].Value}?\n\nThis action is permanent.",
                    "Delete Booking",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;


                if (ClsServiceBookings.DeleteBookingById(
                    Convert.ToInt32(dgvServices.CurrentRow.Cells["booking_id"].Value)))
                {
                    MessageBox.Show(
                        "Booking deleted successfully.",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _RefreshList();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to delete Booking.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while deleting service booking.");

                MessageBox.Show(
                    "An unexpected error occurred while deleting the booking.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the edit form for the selected service booking and refreshes the list afterward.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditServiceBooking editService = new FrmEditServiceBooking(
                    dgvServices.CurrentRow.Cells["full_name"].Value.ToString(),
                    Convert.ToInt32(dgvServices.CurrentRow.Cells["booking_id"].Value));

                editService.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening edit service booking form.");

                MessageBox.Show(
                    "An unexpected error occurred while editing the booking.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens the new reservation/bill entry form and refreshes the list afterward.
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReservationBillEntry frm = new FrmReservationBillEntry();

                frm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening new reservation form.");

                MessageBox.Show(
                    "An unexpected error occurred while creating a reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads all active service bookings, binds the grid, and formats/filters it when the form loads.
        private void FrmServicesBookingManagment_Load(object sender, EventArgs e)
        {
            try
            {
                _allServicesBooking = ClsServiceBookings.GetAllActiveServiceBookings();

                if (_allServicesBooking == null || _allServicesBooking.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load service bookings.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                dgvServices.DataSource = _allServicesBooking;

                _FormatGrid();

                _ApplyFilters();

                lblSubtitle.Text = $"{dgvServices.Rows.Count} of {_allServicesBooking.Rows.Count} Booking";

            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading service bookings.");

                MessageBox.Show(
                    "An unexpected error occurred while loading service bookings.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}