using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace HMS.reservations.Controls
{
    public partial class CtrlBillSummaryView : UserControl
    {
        private const int lineWidthChars = 50;
        private const int cardWidth = 480;

        private List<(string Caption, decimal Amount)> _items = new List<(string, decimal)>();

        public event EventHandler SummaryLayoutComplete;

        // Initializes the control and its designer-generated components.
        public CtrlBillSummaryView()
        {
            InitializeComponent();
        }

        // Loads bill/room charge data for the given reservation and refreshes the whole summary UI.
        public void LoadSummary(int reservationId, int billId, short roomId, int customerId)
        {
            try
            {
                _items = ClsBills.GetBillSummaryByReservationID(reservationId);

                _items.AddRange(ClsReservations.GetRoomChargesByReservationId(reservationId));


                lblBillID.Text = $"Bill ID: {billId}";
                lblReservationInfo.Text = $"Reservation #{reservationId}  •  Room #{roomId}  •  Customer #{customerId}";


                DateTime? createdAt = ClsBills.GetCreatedAtBill(billId);
                DateTime? paidAt = ClsBills.GetPaidAtBill(billId);


                SetCreatedAt(createdAt);
                SetPaidAt(paidAt);


                RebuildSummary();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading bill summary. Reservation ID: {reservationId}, Bill ID: {billId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading bill summary.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Sets the "Created" label text based on the given nullable creation date.
        public void SetCreatedAt(DateTime? createdAt)
        {
            lblCreatedAt.Text = createdAt.HasValue
                ? $"Created: {createdAt.Value:g}"
                : "Created: N/A";
        }

        // Sets the "Paid" label text based on the given nullable paid date.
        public void SetPaidAt(DateTime? paidAt)
        {
            lblPaidAt.Text = paidAt.HasValue ? $"Paid: {paidAt.Value:g}" : "Paid: --";
        }

        // Draws the light border rectangle around the card panel.
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
            {
                var rect = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        // Draws a dashed horizontal divider line across the middle of the given panel.
        private void Divider_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            using (var pen = new Pen(Color.FromArgb(203, 213, 225), 1.5f)
            { DashStyle = DashStyle.Dash })
            {
                int y = panel.Height / 2;
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        // Builds a fixed-width line with the left caption, dot-fill padding, and right-aligned amount, trimming the caption if needed.
        private static string PadLine(string left, string right, int width)
        {
            int maxLeft = width - right.Length - 2;
            if (maxLeft < 1) maxLeft = 1;

            string trimmedLeft = left.Length > maxLeft
                ? left.Substring(0, Math.Max(0, maxLeft - 2)) + ".."
                : left;

            int dotCount = width - trimmedLeft.Length - right.Length;
            if (dotCount < 2) dotCount = 2;

            return trimmedLeft + new string('.', dotCount) + right;
        }

        // Creates a formatted Label row for a bill item, styling it differently if it represents a deposit.
        private Label CreateRow(string caption, decimal amount, bool isDeposit)
        {
            return new Label
            {
                Text = PadLine(caption, amount.ToString("$0.00"), lineWidthChars),
                AutoSize = false,
                Size = new Size(448, 20),
                Margin = new Padding(0, 0, 0, 3),
                Font = new Font("Consolas", 9.5F,
                    isDeposit ? FontStyle.Italic : FontStyle.Regular),
                ForeColor = isDeposit
                    ? Color.FromArgb(180, 83, 9)
                    : Color.FromArgb(51, 65, 85)
            };
        }

        // Recomputes and displays the total amount and item count badge from the current items list.
        private void UpdateTotal()
        {
            decimal total = _items.Sum(i => i.Amount);

            lblTotalValue.Text = total.ToString("$0.00");
            lblItemCountBadge.Text = $"-- {_items.Count} item{(_items.Count == 1 ? "" : "s")} --";
        }

        // Rebuilds the item rows, recalculates the total, repositions all UI elements, and notifies listeners that layout is complete.
        private void RebuildSummary()
        {
            flpItems.SuspendLayout();
            flpItems.Controls.Clear();

            foreach (var item in _items)
            {
                bool isDeposit = item.Caption.ToLower().Contains("deposit");
                flpItems.Controls.Add(CreateRow(item.Caption, item.Amount, isDeposit));
            }

            flpItems.ResumeLayout();
            flpItems.PerformLayout();

            UpdateTotal();

            // Reposition all controls based on actual flpItems size
            pnlDividerTop.Location = new Point(16, lblItemCountBadge.Bottom + 6);
            flpItems.Location = new Point(16, pnlDividerTop.Bottom + 6);

            pnlDivider.Location = new Point(16, flpItems.Bottom + 8);
            lblTotalCaption.Location = new Point(16, pnlDivider.Bottom + 12);
            lblTotalValue.Location = new Point(204, pnlDivider.Bottom + 8);

            int afterTotalY = Math.Max(lblTotalCaption.Bottom, lblTotalValue.Bottom) + 10;
            lblReservationInfo.Location = new Point(16, afterTotalY);

            int datesRowY = lblReservationInfo.Bottom + 4;
            lblCreatedAt.Location = new Point(16, datesRowY);
            lblPaidAt.Location = new Point(244, datesRowY);

            this.Width = cardWidth;
            this.Height = lblCreatedAt.Bottom + 16;

            // Tell the parent form to resize itself now that we know our real size
            SummaryLayoutComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}