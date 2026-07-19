using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace HMS.reservations.Controls
{
    public partial class CtrlAddServiceToBill : UserControl
    {
        private static DataTable _allServices;
        private readonly HashSet<int> _selectedServiceIds = new HashSet<int>();

        // Initializes the user control and its designer-generated components.
        public CtrlAddServiceToBill()
        {
            InitializeComponent();
        }

        // Sets up the category filter, grid event handlers, and displays the given reservation/bill IDs.
        public void LoadInfo(int reservationId, int billId)
        {
            _FillCatagoriesInComboBox();
            dgvServices.CurrentCellDirtyStateChanged += dgvServices_CurrentCellDirtyStateChanged;
            dgvServices.CellValueChanged += dgvServices_CellValueChanged;

            BillID.Text = billId.ToString();
            ResverstaionID.Text = reservationId.ToString();
        }

        // Sets the header text, widths, and formatting for the services grid columns.
        private void _FormatGrid()
        {
            if (dgvServices.Columns.Count == 0) return;

            dgvServices.Columns[1].HeaderText = "ID";
            dgvServices.Columns[2].HeaderText = "Service Name";
            dgvServices.Columns[3].HeaderText = "Category";
            dgvServices.Columns[4].HeaderText = "Price";
            dgvServices.Columns[5].HeaderText = "Description";

            dgvServices.Columns[1].Width = 50;
            dgvServices.Columns[2].Width = 190;
            dgvServices.Columns[3].Width = 100;
            dgvServices.Columns[4].Width = 90;
            dgvServices.Columns[5].Width = 360;

            dgvServices.Columns[3].DefaultCellStyle.Format = "N2";
        }

        // Loads all service categories into the category filter combo box, adding an "All" option.
        private void _FillCatagoriesInComboBox()
        {
            try
            {
                DataTable getAllServicesCategories = ClsServiceCategories.GetAllServiceCategories();

                if (getAllServicesCategories == null || getAllServicesCategories.Rows.Count == 0)
                {
                    clsLogger.LogWarning("GetAllServiceCategories returned null while filling category ComboBox");

                    MessageBox.Show(
                        "Unable to load service categories.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                DataRow row = getAllServicesCategories.NewRow();
                row["category_id"] = 0;
                row["category_name"] = "All";

                getAllServicesCategories.Rows.InsertAt(row, 0);


                cmbCategoryFilter.DataSource = getAllServicesCategories;
                cmbCategoryFilter.DisplayMember = "category_name";
                cmbCategoryFilter.ValueMember = "category_id";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading service categories into ComboBox");

                MessageBox.Show(
                    "An unexpected error occurred while loading service categories.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Reloads all services, reapplies filters, and restores previous selections and totals in the grid.
        private void _RefreshList()
        {
            try
            {
                _allServices = ClsServices.GetAllServices();

                if (_allServices == null)
                {
                    dgvServices.DataSource = null;
                    return;
                }

                dgvServices.DataSource = _allServices;

                _FormatGrid();

                _ApplyFilters();

                _RestoreSelections();

                _UpdateSelectionSummary();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing services list.");

                MessageBox.Show(
                    "An unexpected error occurred while loading services.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Applies category and search-text row filters to the services list.
        private void _ApplyFilters()
        {
            try
            {
                List<string> filters = new List<string>();

                if (cmbCategoryFilter.Text != "All")
                {
                    filters.Add(string.Format(
                        "category_name LIKE '%{0}%'",
                        cmbCategoryFilter.Text.Trim().Replace("'", "''")
                    ));
                }


                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    if (txtSearch.Text != "Search by name ...")
                    {
                        filters.Add(string.Format(
                            "{0} LIKE '%{1}%'",
                            "service_name",
                            txtSearch.Text.Trim().Replace("'", "''")
                        ));
                    }
                }


                if (_allServices != null && _allServices.Rows.Count > 0)
                {
                    _allServices.DefaultView.RowFilter = string.Join(" AND ", filters);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while applying service filters");

                MessageBox.Show(
                    "An unexpected error occurred while filtering services.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Commits checkbox cell edits immediately so CellValueChanged fires without losing focus first.
        private void dgvServices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvServices.IsCurrentCellDirty && dgvServices.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvServices.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Tracks which service IDs are checked/unchecked in the grid and updates the selection summary.
        private void dgvServices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvServices.Columns[e.ColumnIndex].Name != "colSelect") return;

            DataGridViewRow row = dgvServices.Rows[e.RowIndex];
            if (row.Cells["service_id"].Value == null) return;

            int serviceId = Convert.ToInt32(row.Cells["service_id"].Value);
            bool isChecked = Convert.ToBoolean(row.Cells["colSelect"].Value ?? false);

            if (isChecked)
                _selectedServiceIds.Add(serviceId);
            else
                _selectedServiceIds.Remove(serviceId);

            _UpdateSelectionSummary();
        }

        // Re-checks the checkboxes in the grid for services that were previously selected (e.g. after a filter refresh).
        private void _RestoreSelections()
        {
            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (row.Cells["service_id"].Value == null) continue;

                int serviceId = Convert.ToInt32(row.Cells["service_id"].Value);
                row.Cells["colSelect"].Value = _selectedServiceIds.Contains(serviceId);
            }
        }

        // Recalculates and displays the count and total price of currently selected services.
        private void _UpdateSelectionSummary()
        {
            decimal total = 0m;

            foreach (int id in _selectedServiceIds)
            {
                DataRow[] found = _allServices.Select($"service_id = {id}");
                if (found.Length > 0)
                    total += Convert.ToDecimal(found[0]["price"]);
            }

            lblSelectedServices.Text = $"{_selectedServiceIds.Count} Service(s)";
            lblTotalSelectedPrice.Text = total.ToString("C2");
            lblSelectedCountBadge.Text = $"{_selectedServiceIds.Count} Selected";
        }

        // Loads all services and refreshes the grid when the control first loads.
        private void CtrlAddServiceToBill_Load(object sender, EventArgs e)
        {
            try
            {
                _allServices = ClsServices.GetAllServices();

                if (_allServices == null)
                {
                    clsLogger.LogWarning("GetAllServices returned null while loading Add Service To Bill control");

                    MessageBox.Show(
                        "Unable to load services.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading Add Service To Bill control");

                MessageBox.Show(
                    "An unexpected error occurred while loading services.",
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

        // Books all currently selected services against the current bill and reservation, then closes the form.
        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedServiceIds.Count == 0)
                {
                    MessageBox.Show(
                        "Please select at least one service before continuing.",
                        "No Services Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                foreach (byte serviceId in _selectedServiceIds)
                {
                    ClsServiceBookings serviceBookings = new ClsServiceBookings();

                    serviceBookings.BillId = Convert.ToInt32(BillID.Text);
                    serviceBookings.ServiceDate = DateTime.Today;
                    serviceBookings.ReservationId = Convert.ToInt32(ResverstaionID.Text);
                    serviceBookings.ServiceId = serviceId;


                    if (!serviceBookings.AddService())
                    {
                        clsLogger.LogWarning($"Failed to save service booking. Service ID: {serviceId}, Bill ID: {BillID.Text}");

                        MessageBox.Show(
                            "Failed to save the selected service. Please try again.",
                            "Save Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }
                }


                clsLogger.LogInformation($"Services added successfully. Count: {_selectedServiceIds.Count}, Bill ID: {BillID.Text}");


                MessageBox.Show(
                    "All selected services have been saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                this.FindForm().Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while saving selected services. Bill ID: {BillID.Text}");

                MessageBox.Show(
                    "An unexpected error occurred while saving selected services.",
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Refreshes the services list whenever the search text changes.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _RefreshList();
        }

        // Refreshes the services list whenever the category filter selection changes.
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshList();
        }

        // Restores the search box placeholder text if left empty.
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search by name ...";
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
    }
}