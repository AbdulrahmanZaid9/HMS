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

namespace HMS.Reports
{
    public partial class FrmReports : Form
    {
        // Initializes the reports form, centers it on screen, and sets the grid to auto-fill columns.
        public FrmReports()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Populates the report type dropdown with all available report options.
        private void FrmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Add("Daily Revenue Report");
            cmbReportType.Items.Add("Monthly Revenue Report");
            cmbReportType.Items.Add("Yearly Revenue Report");
            cmbReportType.Items.Add("Revenue By Room Type");
            cmbReportType.Items.Add("Customer Revenue Report");
            cmbReportType.Items.Add("Customer Stay Report");
            cmbReportType.Items.Add("Outstanding Bills Report");
            cmbReportType.Items.Add("Revenue By Room");
            cmbReportType.Items.Add("Revenue By Active Room Type");

            cmbReportType.SelectedIndex = 0;

        }

        // Loads and displays the report data corresponding to the currently selected report type.
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = null;

                switch (cmbReportType.Text)
                {
                    case "Daily Revenue Report":
                        dt = ClsReports.GetDailyRevenueReport();
                        break;

                    case "Monthly Revenue Report":
                        dt = ClsReports.GetMonthlyRevenueReport();
                        break;

                    case "Yearly Revenue Report":
                        dt = ClsReports.GetYearlyRevenueReport();
                        break;

                    case "Revenue By Room Type":
                        dt = ClsReports.GetRevenueByRoomType();
                        break;

                    case "Customer Revenue Report":
                        dt = ClsReports.GetCustomerRevenueReport();
                        break;

                    case "Customer Stay Report":
                        dt = ClsReports.GetCustomerStayReport();
                        break;

                    case "Outstanding Bills Report":
                        dt = ClsReports.GetOutstandingBillsReport();
                        break;

                    case "Revenue By Room":
                        dt = ClsReports.GetRevenueByRoom();
                        break;

                    case "Revenue By Active Room Type":
                        dt = ClsReports.GetRevenueByActiveRoomType();
                        break;
                }

                if (dt == null)
                {
                    clsLogger.LogWarning($"No data returned for report type: {cmbReportType.Text}");

                    dgvReports.DataSource = null;
                    return;
                }

                dgvReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading report: {cmbReportType.Text}");

                MessageBox.Show(
                    "An unexpected error occurred while loading the report.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}