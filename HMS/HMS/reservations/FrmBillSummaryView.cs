using HMS.Global_Classes;
using HMS.reservations.Controls;
using HMS_Buisness;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS.reservations
{
    public partial class FrmBillSummaryView : Form
    {
        private readonly CtrlBillSummaryView _ctrlBillSummaryView;
        private readonly int _reservationId;
        private readonly int _billId;
        private readonly short _roomId;
        private readonly int _customerId;

        private const int bodyPadding = 20;

        // Initializes the form, creates and wires up the bill summary control, and adds it to the body panel.
        public FrmBillSummaryView(int reservationId, int billId, short roomId, int customerId)
        {
            InitializeComponent();

            _reservationId = reservationId;
            _billId = billId;
            _roomId = roomId;
            _customerId = customerId;

            _ctrlBillSummaryView = new CtrlBillSummaryView
            {
                Location = new System.Drawing.Point(bodyPadding, bodyPadding)
            };
            _ctrlBillSummaryView.SummaryLayoutComplete += CtrlBillSummaryView_SummaryLayoutComplete;

            pnlBody.Controls.Add(_ctrlBillSummaryView);
        }

        // Loads the bill summary data and payment status when the form loads.
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);

                _ctrlBillSummaryView.LoadSummary(_reservationId, _billId, _roomId, _customerId);

                SetPaymentStatus(ClsBills.IsBillPaid(_billId));
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading checkout form. Reservation ID: {_reservationId}, Bill ID: {_billId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading checkout information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Updates the payment status label's text and color scheme based on whether the bill is paid.
        public void SetPaymentStatus(bool isPaid)
        {
            lblPaymentStatus.Text = isPaid ? "PAID" : "NOT PAID";

            lblPaymentStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPaymentStatus.TextAlign = ContentAlignment.MiddleCenter;

            if (isPaid)
            {
                // Paid
                lblPaymentStatus.BackColor = Color.FromArgb(220, 252, 231); // Light Green
                lblPaymentStatus.ForeColor = Color.FromArgb(22, 101, 52);   // Dark Green
            }
            else
            {
                // Not Paid
                lblPaymentStatus.BackColor = Color.FromArgb(254, 226, 226); // Light Red
                lblPaymentStatus.ForeColor = Color.FromArgb(185, 28, 28);   // Dark Red
            }

            lblPaymentStatus.BorderStyle = BorderStyle.FixedSingle;
            lblPaymentStatus.Visible = true;
        }

        // Resizes the form and re-centers the summary control once its layout has been computed.
        private void CtrlBillSummaryView_SummaryLayoutComplete(object sender, EventArgs e)
        {
            // Resize the form to fit the control's real size once it has laid out its rows
            this.ClientSize = new System.Drawing.Size(
                _ctrlBillSummaryView.Width + bodyPadding * 2,
                pnlHeader.Height + _ctrlBillSummaryView.Height + bodyPadding * 2);

            // Center the control horizontally within the body panel
            _ctrlBillSummaryView.Location = new System.Drawing.Point(
                (pnlBody.ClientSize.Width - _ctrlBillSummaryView.Width) / 2,
                bodyPadding);
        }

        // Closes the form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}