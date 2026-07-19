using HMS.Global_Classes;
using HMS.reservations;
using System;
using System.Windows.Forms;
using Utilities;

namespace HMS.ServicesBooking
{
    public partial class FrmReservationBillEntry : Form
    {
        // Initializes the form and its designer-generated components.
        public FrmReservationBillEntry()
        {
            InitializeComponent();
        }

        // Validates the entered Reservation ID and Bill ID, then opens the Add Service To Bill form and closes this one.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
            {
                MessageBox.Show(
                    "Please enter the Reservation ID.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtReservationId.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtBillId.Text))
            {
                MessageBox.Show(
                    "Please enter the Bill ID.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBillId.Focus();
                return;
            }


            try
            {
                int reservationId = Convert.ToInt32(txtReservationId.Text.Trim());

                int billId = Convert.ToInt32(txtBillId.Text.Trim());


                FrmAddServicetoBill addServices = new FrmAddServicetoBill(reservationId, billId);

                addServices.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening Add Service To Bill form.");

                MessageBox.Show(
                    "An unexpected error occurred while opening the service form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cancels the form with a Cancel dialog result and closes it.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Restricts keyboard input in the Reservation ID field to valid integer characters.
        private void txtReservationId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
        }

        // Restricts keyboard input in the Bill ID field to valid integer characters.
        private void txtBillId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
        }

    }
}