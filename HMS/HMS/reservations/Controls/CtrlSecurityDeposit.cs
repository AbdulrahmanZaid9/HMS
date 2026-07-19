using HMS.Global_Classes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Utilities;

namespace HMS.reservations.Controls
{
    public partial class CtrlSecurityDeposit : UserControl
    {
        // Returns the deposit amount entered in the text box as a decimal.
        public decimal DepositAmount()
        {
            return Convert.ToDecimal(txtDepositAmount.Text);
        }

        // Initializes the control and pre-fills the deposit amount field with the global default.
        public CtrlSecurityDeposit()
        {
            InitializeComponent();
            txtDepositAmount.Text = ClsGlobal.DepoisteAmount.ToString();
        }

        // Draws the amber border rectangle around the card panel.
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(253, 230, 138), 1f))
            {
                var rect = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        // Draws a filled shield icon with a checkmark on the shield picture box.
        private void picShieldIcon_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picShieldIcon.Width;
            int h = picShieldIcon.Height;

            using (var path = new GraphicsPath())
            {
                path.AddLine(w / 2f, 1f, w - 2f, 5f);
                path.AddLine(w - 2f, 5f, w - 2f, h / 2f);
                path.AddBezier(w - 2f, h / 2f, w - 2f, h - 4f, w / 2f + 2f, h - 1f, w / 2f, h - 1f);
                path.AddBezier(w / 2f, h - 1f, w / 2f - 2f, h - 1f, 2f, h - 4f, 2f, h / 2f);
                path.AddLine(2f, h / 2f, 2f, 5f);
                path.CloseFigure();

                using (var brush = new SolidBrush(Color.FromArgb(217, 119, 6)))
                {
                    g.FillPath(brush, path);
                }
            }

            using (var pen = new Pen(Color.White, 1.8f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                var pts = new[]
                {
                    new Point(w / 2 - 5, h / 2),
                    new Point(w / 2 - 1, h / 2 + 4),
                    new Point(w / 2 + 5, h / 2 - 5)
                };
                g.DrawLines(pen, pts);
            }
        }

        // Restricts keyboard input in the deposit amount field to valid price characters.
        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidPrice(e.KeyChar, txtDepositAmount.Text);
        }
    }
}