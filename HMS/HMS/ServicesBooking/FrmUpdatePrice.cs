using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Globalization;
using System.Windows.Forms;
using Utilities;

namespace HMS.ServicesBooking
{
    public partial class FrmUpdatePrice : Form
    {
        public byte ServiceId { get; }
        public decimal NewPrice { get; set; }

        // Initializes the form, storing the service ID and pre-filling the current price into the input field.
        public FrmUpdatePrice(byte serviceId, decimal currentPrice)
        {
            InitializeComponent();

            ServiceId = serviceId;
            lblServiceId.Text = "ID: " + serviceId.ToString(CultureInfo.CurrentCulture);

            lblCurrentPriceValue.Text = currentPrice.ToString("N2", CultureInfo.CurrentCulture);
            txtPrice.Text = currentPrice.ToString("N2", CultureInfo.CurrentCulture);
            txtPrice.SelectAll();
        }

        // Validates the entered price and, if valid, updates the service's price and closes the form on success.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal price))
            {
                MessageBox.Show(
                    this,
                    "Please enter a valid price.",
                    "Invalid Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                txtPrice.SelectAll();
                return;
            }


            try
            {
                if (ClsServices.UpdatePriceById(ServiceId, price))
                {
                    clsLogger.LogInformation(
                        $"Service price updated successfully. Service ID: {ServiceId}, New Price: {price}");

                    MessageBox.Show(
                        "The service price has been updated successfully.",
                        "Update Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    clsLogger.LogWarning(
                        $"Failed to update service price. Service ID: {ServiceId}");

                    MessageBox.Show(
                        "Failed to update the service price. Please try again.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    $"Error while updating service price. Service ID: {ServiceId}");

                MessageBox.Show(
                    "An unexpected error occurred while updating the service price.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cancels the price update and closes the form with a Cancel dialog result.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Restricts keyboard input in the price field to valid price characters.
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidPrice(e.KeyChar, txtPrice.Text);
        }
    }
}