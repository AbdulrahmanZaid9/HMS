using HMS.Global_Classes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HMS.reservations.Controls
{
    public partial class CtrlCheckInSummary : UserControl
    {
        // Initializes the control and its designer-generated components.
        public CtrlCheckInSummary()
        {
            InitializeComponent();
        }

        // Populates the summary labels with guest, room, and stay details.
        public void SetDetails(string guestName, string roomInfo, DateTime checkIn, DateTime checkOut, int nights, decimal roomTotal)
        {
            try
            {
                lblGuestValue.Text = guestName;
                lblRoomValue.Text = roomInfo;
                lblCheckInValue.Text = checkIn.ToString("yyyy-MM-dd");
                lblCheckOutValue.Text = checkOut.ToString("yyyy-MM-dd");
                lblDurationValue.Text = nights == 1 ? "1 night" : nights + " night(s)";
                lblRoomTotalValue.Text = roomTotal.ToString("$0.00");
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while setting reservation details UI values");

                MessageBox.Show(
                    "An unexpected error occurred while displaying reservation details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Draws the light green border rectangle around the card panel.
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(167, 243, 208), 1f))
            {
                var rect = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        // Draws a green checkmark-in-circle icon on the check icon picture box.
        private void picCheckIcon_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(1, 1, picCheckIcon.Width - 3, picCheckIcon.Height - 3);
            using (var pen = new Pen(Color.FromArgb(22, 163, 74), 2f))
            {
                g.DrawEllipse(pen, rect);
            }

            using (var pen = new Pen(Color.FromArgb(22, 163, 74), 2.2f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                var p1 = new Point(7, 13);
                var p2 = new Point(11, 17);
                var p3 = new Point(19, 8);
                g.DrawLines(pen, new[] { p1, p2, p3 });
            }
        }

    }
}