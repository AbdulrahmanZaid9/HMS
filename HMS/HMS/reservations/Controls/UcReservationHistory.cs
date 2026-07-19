using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HMS.reservations
{
    public partial class UcReservationHistory : UserControl
    {
        // Initializes the control and its designer-generated components.
        public UcReservationHistory()
        {
            InitializeComponent();
        }
        DataTable _allReservations = new DataTable();

        // Sets the subtitle text with customer info and record count, or closes the form if there are no reservations.
        public void SetCustomer(string customerName, string customerId)
        {
            if (_allReservations.Rows.Count > 0)
            {
                lblSubtitle.Text = $"Customer: {customerName}  •  ID: {customerId}  •  {_allReservations.Rows.Count} record(s)";
            }
            else
            {
                MessageBox.Show(
                    "No reservations were found for the selected customer.",
                    "No Reservations Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.FindForm().Close();
                return;

            }
        }

        // Loads a customer's full reservation history, updates the subtitle/summary, and binds it to the grid.
        public void LoadResverstaionsInfo(int customerId, string FullName)
        {
            try
            {
                _allReservations = ClsReservations.GetAllReservationsForCustomer(customerId);

                if (_allReservations == null || _allReservations.Rows.Count == 0)
                {
                    clsLogger.LogWarning($"No reservations found for customer. Customer ID: {customerId}");

                    MessageBox.Show(
                        "No reservation information was found for this customer.",
                        "No Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                SetCustomer(FullName, customerId.ToString());

                SetSummary();

                dgvHistory.DataSource = _allReservations;
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading customer's reservation history. Customer ID: {customerId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading reservation information.",
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Computes and displays total spent, total nights, and total reservation count summary stats.
        public void SetSummary()
        {
            if (_allReservations.Rows.Count > 0)
            {
                lblStatSpentValue.Text = _allReservations.Compute("SUM(Total)", "").ToString();
                lblStatNightsValue.Text = _allReservations.Compute("SUM(Nights)", "").ToString();
                lblStatTotalValue.Text = _allReservations.Rows.Count.ToString();
            }
        }

        // Clips the stat card panel to a rounded-rectangle region and draws its border.
        private void StatCard_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            var rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            int radius = 10;

            using (var path = RoundedRect(rect, radius))
            using (var borderPen = new Pen(Color.FromArgb(230, 232, 238)))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                panel.Region = new Region(path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        // Builds a rounded-rectangle graphics path for the given bounds and corner radius.
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}