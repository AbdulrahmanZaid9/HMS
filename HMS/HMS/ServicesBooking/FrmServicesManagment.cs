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

namespace HMS.ServicesBooking
{
    public partial class FrmServicesManagment : Form
    {
        private static DataTable _allServices;

        // Initializes the form and immediately loads the services list.
        public FrmServicesManagment()
        {
            InitializeComponent();
            _RefreshList();
        }

        // Sets header text, column widths, and price formatting for the services grid.
        private void _FormatGrid()
        {
            if (dgvServices.Columns.Count == 0) return;
            dgvServices.Columns[0].HeaderText = "ID";
            dgvServices.Columns[1].HeaderText = "Service Name";
            dgvServices.Columns[2].HeaderText = "Category";
            dgvServices.Columns[3].HeaderText = "Price";
            dgvServices.Columns[4].HeaderText = "Description";

            dgvServices.Columns[0].Width = 50;
            dgvServices.Columns[1].Width = 190;
            dgvServices.Columns[2].Width = 100;
            dgvServices.Columns[3].Width = 90;
            dgvServices.Columns[4].Width = 360;

            dgvServices.Columns[3].DefaultCellStyle.Format = "N2";

        }

        // Reloads all services, rebinds the grid, and updates the subtitle count.
        private void _RefreshList()
        {
            try
            {
                _allServices = ClsServices.GetAllServices();

                if (_allServices == null || _allServices.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load services.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();

                    return;
                }

                dgvServices.DataSource = _allServices;

                _FormatGrid();

                lblSubtitle.Text = $"{dgvServices.Rows.Count} Services";
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

        // Opens the update price form for the selected service and refreshes the list afterward.
        private void updatePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdatePrice updatePriceForm = new FrmUpdatePrice(
                    Convert.ToByte(dgvServices.CurrentRow.Cells["service_id"].Value),
                    Convert.ToDecimal(dgvServices.CurrentRow.Cells["price"].Value)
                );

                updatePriceForm.ShowDialog();

                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening update service price form.");

                MessageBox.Show(
                    "An unexpected error occurred while updating service price.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the services list when the form loads.
        private void FrmServicesManagment_Load(object sender, EventArgs e)
        {
            try
            {
                _RefreshList();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading services management form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening services management.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}