using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.ServicesBooking
{
    public partial class UcEditServiceBooking : UserControl
    {
        private int _bookingId;

        // Initializes the control and its designer-generated components.
        public UcEditServiceBooking()
        {
            InitializeComponent();
        }

        // Loads all services into the service combo box.
        private void _LoadServicesIntoCmb()
        {
            try
            {
                DataTable allServices = ClsServices.GetAllServiceNamesAndId();

                if (allServices == null || allServices.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load services.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                cmbService.DataSource = allServices;

                cmbService.DisplayMember = "service_name";

                cmbService.ValueMember = "service_id";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading services into combo box.");

                MessageBox.Show(
                    "An unexpected error occurred while loading services.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Sets up the control for editing a specific booking, loading the service list and displaying booking/customer info.
        public void LoadInfo(int bookingId, string customerName)
        {
            try
            {
                _bookingId = bookingId;

                _LoadServicesIntoCmb();

                lblBookingId.Text = $"Booking ID: {bookingId}";

                lblCustomerName.Text = $"Customer Name: {customerName}";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading service booking information.");

                MessageBox.Show(
                    "An unexpected error occurred while loading booking information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Updates the booking with the selected service and closes the parent form.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClsServiceBookings.UpdateBookingById(
                    _bookingId,
                    Convert.ToByte(cmbService.SelectedValue)))
                {
                    clsLogger.LogInformation(
                        $"Service booking {_bookingId} updated successfully.");

                    MessageBox.Show(
                        "The booking has been updated successfully.",
                        "Update Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    clsLogger.LogWarning(
                        $"Failed to update service booking {_bookingId}.");

                    MessageBox.Show(
                        "The booking could not be updated.\n\nPlease try again.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(
                    ex,
                    $"Error while updating service booking {_bookingId}.");

                MessageBox.Show(
                    "An unexpected error occurred while updating the booking.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


            this.FindForm().Close();
        }

        // Closes the parent form without saving changes.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}