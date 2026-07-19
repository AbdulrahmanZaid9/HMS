using HMS.Customers;
using HMS.Global_Classes;
using HMS.Reports;
using HMS.reservations;
using HMS.ServicesBooking;
using HMS.Users;
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

namespace HMS
{
    public partial class Mainform : Form
    {
        // Initializes the form and updates rooms from Cleaning to Available status on startup.
        public Mainform()
        {
            InitializeComponent();
            try
            {
                ClsRooms.UpdateRoomsStatus(
                    (byte)ClsRooms.EnRoomStatus.Cleaning,
                    (byte)ClsRooms.EnRoomStatus.Available);

                lblUserFullName.Text = ClsGlobal.CurrentUser.UserName.ToString();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while updating room statuses.");

                MessageBox.Show(
                    "An unexpected error occurred while updating room statuses.",
                    "Operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Activates the Rooms nav button and opens the room management form.
        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavRooms);

            this.Refresh();
            Application.DoEvents();

            FrmRoom rooms = new FrmRoom();
            rooms.ShowDialog();
        }

        // Applies hover highlight styling to a nav button that isn't currently active.
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != currentActiveButton)
            {
                btn.BackColor = Color.FromArgb(51, 65, 85);
                btn.ForeColor = Color.White;
            }
        }

        // Reverts hover styling on a nav button that isn't currently active when the mouse leaves.
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != currentActiveButton)
            {
                btn.BackColor = Color.Transparent;
                if (btn == btnExits)
                    btn.ForeColor = Color.FromArgb(239, 68, 68);
                else
                    btn.ForeColor = subTextColor;
            }
        }

        // Generic click handler that marks the clicked button as the active nav button.
        private void Button_Click(object sender, EventArgs e) =>
            SetActiveButton((Button)sender);

        // Updates the active/inactive styling and position indicator for the navigation buttons.
        private void SetActiveButton(Button activeButton)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.Transparent;
                if (currentActiveButton == btnExits)
                    currentActiveButton.ForeColor = Color.FromArgb(239, 68, 68);
                else
                    currentActiveButton.ForeColor = subTextColor;
            }

            currentActiveButton = activeButton;
            activeButton.BackColor = Color.FromArgb(59, 91, 219);
            activeButton.ForeColor = Color.White;

            pnlActiveIndicator.Top = activeButton.Top;
            pnlActiveIndicator.Height = activeButton.Height;
        }

        // Activates the Customers nav button and opens the customer management form.
        private void Customers_click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmCustomersMangement customers = new FrmCustomersMangement();
            customers.ShowDialog();
        }

        // Activates the Reservations nav button and opens the reservations management form.
        private void Reservation_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmReservationsManagment Reservation = new FrmReservationsManagment();
            Reservation.ShowDialog();
        }

        // Activates the nav button and opens the service bookings management form.
        private void ServiceBooking_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmServicesBookingManagment Reservation = new FrmServicesBookingManagment();
            Reservation.ShowDialog();

        }

        // Activates the nav button and opens the services management form.
        private void Services_Booking(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmServicesManagment Reservation = new FrmServicesManagment();
            Reservation.ShowDialog();
        }

        // Activates the Users nav button and opens the users management form.
        private void Users_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmUsersManagment Reservation = new FrmUsersManagment();
            Reservation.ShowDialog();
        }

        // Opens the profile view for the currently logged-in user.
        private void pnlUserBtn_Click(object sender, EventArgs e)
        {
            FrmViewProfile viewProfile = new FrmViewProfile(ClsGlobal.CurrentUser.UserId);
            viewProfile.ShowDialog();
        }

        // Activates the Reports nav button and opens the reports form.
        private void Reports_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            this.Refresh();
            Application.DoEvents();

            FrmReports viewProfile = new FrmReports();
            viewProfile.ShowDialog();
        }
    }
}