using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace HMS.reservations.Controls
{
    public partial class CtrlBillSummary : UserControl
    {
        private const int lineWidthChars = 50;
        private const int cardWidth = 480;

        private List<(string Caption, decimal Amount)> _items = new List<(string, decimal)>();

        private decimal _roomAmount;
        private int _billId;
        private int _reservationId;
        private short _roomId;
        private int _customerId;

        public event EventHandler SummaryLayoutComplete;

        // Initializes the user control and its designer-generated components.
        public CtrlBillSummary()
        {
            InitializeComponent();
        }

        // Loads the bill's service and room charges for a reservation and builds the summary display.
        public void LoadSummary(int reservationId, int billId, short roomId, int customerId)
        {
            try
            {
                _items = ClsBills.GetBillSummaryByReservationID(reservationId);

                _items.AddRange(ClsReservations.GetRoomChargesByReservationId(reservationId));

                _roomAmount = _items[_items.Count - 1].Amount;

                lblBillID.Text = $"Bill ID: {billId}";

                _billId = billId;
                _reservationId = reservationId;
                _roomId = roomId;
                _customerId = customerId;

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

        // Draws a border around the summary card panel.
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
            {
                var rect = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        // Draws a dashed horizontal divider line in the given panel.
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

        // Recalculates the displayed total when the "include deposit" checkbox is toggled.
        private void chkIncludeDeposit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        // Formats a caption/amount pair into a fixed-width, dot-padded receipt-style line.
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

        // Creates a formatted label representing a single line item row in the summary.
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

        // Recalculates and displays the total (including or excluding deposit) and item count.
        private void UpdateTotal()
        {
            decimal total = _items
                .Where(i => chkIncludeDeposit.Checked
                            || !i.Caption.ToLower().Contains("deposit"))
                .Sum(i => i.Amount);

            lblTotalValue.Text = total.ToString("$0.00");
            lblItemCountBadge.Text = $"-- {_items.Count} item{(_items.Count == 1 ? "" : "s")} --";
        }

        // Rebuilds the entire line-item list and repositions all summary controls based on content size.
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

            // Update the total label
            UpdateTotal();

            // Reposition all controls based on actual flpItems size
            pnlDividerTop.Location = new Point(16, lblItemCountBadge.Bottom + 6);
            flpItems.Location = new Point(16, pnlDividerTop.Bottom + 6);

            chkIncludeDeposit.Location = new Point(16, flpItems.Bottom + 6);
            pnlDivider.Location = new Point(16, chkIncludeDeposit.Bottom + 8);
            lblTotalCaption.Location = new Point(16, pnlDivider.Bottom + 12);
            lblTotalValue.Location = new Point(204, pnlDivider.Bottom + 8);

            int afterTotalY = Math.Max(lblTotalCaption.Bottom, lblTotalValue.Bottom) + 12;
            pnlDividerActions.Location = new Point(16, afterTotalY);
            btnCancel.Location = new Point(16, pnlDividerActions.Bottom + 14);
            btnConfirm.Location = new Point(248, pnlDividerActions.Bottom + 14);

            this.Width = cardWidth;
            this.Height = btnConfirm.Bottom + 22;

            // Tell the parent form to resize itself now that we know our real size
            SummaryLayoutComplete?.Invoke(this, EventArgs.Empty);
        }

        // Closes the parent form without processing payment.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        // Creates a payment record for the deposit (refund or forfeiture, depending on the checkbox).
        private void _CreateDepositeRecord()
        {
            try
            {
                ClsPayments deposit = new ClsPayments();

                deposit.BillId = _billId;
                deposit.PaymentDate = DateTime.Now;
                deposit.PaymentMethodId = (byte)ClsPaymentMethods.EnPaymentMethods.Cash;
                deposit.Amount = ClsGlobal.DepoisteAmount;
                deposit.TransactionReference = clsUtil.GenerateTransactionReference();

                if (chkIncludeDeposit.Checked)
                    deposit.PaymentTypeId = (byte)ClsPaymentTypes.EnPaymentTypes.Refund;
                else
                    deposit.PaymentTypeId = (byte)ClsPaymentTypes.EnPaymentTypes.DepositForfeited;


                deposit.RelatedPaymentId = ClsPayments.GetRelatedPaymentId(_billId);


                if (!deposit.Save())
                {
                    clsLogger.LogWarning($"Failed to create deposit record. Bill ID: {_billId}");

                    MessageBox.Show(
                        "An error occurred while processing your request. Please try again later.",
                        "Deposit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    clsLogger.LogInformation($"Deposit record created successfully. Bill ID: {_billId}");
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while creating deposit record. Bill ID: {_billId}");

                MessageBox.Show(
                    "An unexpected error occurred while processing deposit.",
                    "Deposit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Creates a payment record for the room charge amount.
        private void _CreateRoomChargeRecord()
        {
            try
            {
                ClsPayments roomCharge = new ClsPayments();

                roomCharge.BillId = _billId;
                roomCharge.PaymentDate = DateTime.Now;
                roomCharge.PaymentMethodId = (byte)ClsPaymentMethods.EnPaymentMethods.Cash;
                roomCharge.Amount = _roomAmount;
                roomCharge.TransactionReference = clsUtil.GenerateTransactionReference();
                roomCharge.PaymentTypeId = (byte)ClsPaymentTypes.EnPaymentTypes.RoomCharge;


                if (!roomCharge.Save())
                {
                    clsLogger.LogWarning($"Failed to create room charge record. Bill ID: {_billId}");

                    MessageBox.Show(
                        "An error occurred while processing your request. Please try again later.",
                        "Room Charge",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    clsLogger.LogInformation($"Room charge record created successfully. Bill ID: {_billId}");
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while creating room charge record. Bill ID: {_billId}");

                MessageBox.Show(
                    "An unexpected error occurred while processing room charge.",
                    "Room Charge Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Creates a payment record for the total service charges (total minus room charge).
        private void _CreateServiceChargeRecord()
        {
            try
            {
                ClsPayments serviceCharge = new ClsPayments();

                serviceCharge.BillId = _billId;
                serviceCharge.PaymentDate = DateTime.Now;
                serviceCharge.PaymentMethodId = (byte)ClsPaymentMethods.EnPaymentMethods.Cash;
                serviceCharge.Amount = Convert.ToDecimal(lblTotalValue.Text.Replace("$", "")) - _roomAmount;
                serviceCharge.TransactionReference = clsUtil.GenerateTransactionReference();
                serviceCharge.PaymentTypeId = (byte)ClsPaymentTypes.EnPaymentTypes.ServiceCharge;


                if (!serviceCharge.Save())
                {
                    clsLogger.LogWarning($"Failed to create service charge record. Bill ID: {_billId}");

                    MessageBox.Show(
                        "An error occurred while processing your request. Please try again later.",
                        "Service Charge",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    clsLogger.LogInformation($"Service charge record created successfully. Bill ID: {_billId}");
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while creating service charge record. Bill ID: {_billId}");

                MessageBox.Show(
                    "An unexpected error occurred while processing service charge.",
                    "Service Charge Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Finalizes checkout: creates payment records, updates reservation/room/bill/customer status, then closes the form.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkIncludeDeposit.Checked)
                    _CreateDepositeRecord();


                _CreateRoomChargeRecord();


                if (_items.Count > 1)
                    _CreateServiceChargeRecord();


                if (!ClsReservations.ChangeReservationStatus(ClsReservations.EnReservationStatus.CheckedOut, _reservationId))
                {
                    clsLogger.LogWarning($"Failed to change reservation status to CheckedOut. Reservation ID: {_reservationId}");

                    MessageBox.Show(
                        "Failed to confirm check_out.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                if (!ClsRooms.ChangeRoomStatus(ClsRooms.EnRoomStatus.Cleaning, _roomId))
                {
                    clsLogger.LogWarning($"Failed to update room status. Room ID: {_roomId}");

                    MessageBox.Show(
                        "Failed to update room status.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                if (!ClsBills.UpdatePaitAtBill(_billId))
                {
                    clsLogger.LogWarning($"Failed to update bill PaidAt. Bill ID: {_billId}");

                    MessageBox.Show(
                        "Failed to update the bill.\n\nPlease try again. If the problem persists, contact your system administrator.",
                        "Operation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                if (!ClsCustomers.UpdateStatusByCustomerID(_customerId, false))
                {
                    clsLogger.LogWarning($"Failed to update customer status. Customer ID: {_customerId}");

                    MessageBox.Show(
                        "Failed to update the customer status.\n\nPlease try again. If the problem persists, contact your system administrator.",
                        "Operation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                clsLogger.LogInformation($"Checkout completed successfully. Reservation ID: {_reservationId}, Bill ID: {_billId}");

            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while processing checkout. Reservation ID: {_reservationId}, Bill ID: {_billId}");

                MessageBox.Show(
                    "An unexpected error occurred while processing the payment.",
                    "Operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.FindForm().Close();
                return;
            }


            MessageBox.Show(
                "The payment has been processed successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.FindForm().Close();
        }
    }
}