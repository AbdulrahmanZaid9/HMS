using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.reservations
{
    public partial class FrmAddUpdateReservations : Form
    {

        private enum EnMode
        {
            AddNew,
            Update
        }
        private EnMode _mode;
        private ClsReservations _reservation;
        private int _reservationId;

        // Initializes the form in "add new reservation" mode.
        public FrmAddUpdateReservations()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        // Initializes the form in "update reservation" mode for the given reservation ID.
        public FrmAddUpdateReservations(int reservationId)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _reservationId = reservationId;
        }

        // Loads active customers into the customer combo box.
        private void _FillCustomersInComoboBox()
        {
            DataTable allCustomers = ClsCustomers.GetActiveOrInactiveCustomers(true);

            cmbCustomer.DataSource = allCustomers;

            cmbCustomer.DisplayMember = "full_name";
            cmbCustomer.ValueMember = "customer_id";
        }

        // Loads available rooms into the room combo box.
        private void _FillRoomsInComoboBox()
        {
            DataTable allRooms = ClsRooms.GetRoomsByStatus(ClsRooms.EnRoomStatus.Available);

            cmbRoom.DataSource = allRooms;

            cmbRoom.DisplayMember = "room_number";
            cmbRoom.ValueMember = "room_id";
        }

        // Populates the customer/room combo boxes and sets the form title/subtitle based on add or update mode.
        private void _ResetDefualtValues()
        {
            try
            {
                _FillCustomersInComoboBox();

                _FillRoomsInComoboBox();


                if (_mode == EnMode.AddNew)
                {
                    lblFormTitle.Text = "Add New Reservation";
                    lblFormSubtitle.Text = "Fill in the details below to create a new reservation";

                    _reservation = new ClsReservations();
                }
                else
                {
                    lblFormTitle.Text = "Update Reservation";
                    lblFormSubtitle.Text = "Update and manage existing reservation details";
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while resetting reservation form default values.");

                MessageBox.Show(
                    "An unexpected error occurred while loading reservation data.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the reservation being updated (validating customer/room exist) and populates the form fields.
        private void _LoadData()
        {
            try
            {
                _reservation = ClsReservations.FindReservationById(_reservationId);


                if (_reservation == null)
                {
                    clsLogger.LogWarning($"Reservation not found. Reservation ID: {_reservationId}");

                    MessageBox.Show(
                        "Reservation not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                if (_reservation.Customer == null)
                {
                    clsLogger.LogWarning($"Customer details not found. Reservation ID: {_reservationId}");

                    MessageBox.Show(
                        "Customer details not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                if (_reservation.Room == null)
                {
                    clsLogger.LogWarning($"Room details not found. Reservation ID: {_reservationId}");

                    MessageBox.Show(
                        "Room details not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                cmbCustomer.SelectedValue = _reservation.CustomerId;

                cmbRoom.SelectedValue = _reservation.RoomId;


                dtpCheckIn.Value = _reservation.CheckInDate;

                dtpCheckOut.Value = _reservation.CheckOutDate;


                txtSpecialRequests.Text = string.IsNullOrEmpty(_reservation.Notes)
                    ? string.Empty
                    : _reservation.Notes;


                lblReservationID.Text = _reservation.ReservationId.ToString();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading reservation data. Reservation ID: {_reservationId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading reservation data.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Handles form load: resets defaults and, in update mode, loads the existing reservation's data.
        private void FrmAdd_UpdateReservations_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_mode == EnMode.Update)
                _LoadData();

        }

        // Closes the form without saving.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates input, saves the reservation (create or update) with Confirmed status, and closes the form.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show(
                    "Please correct the highlighted errors.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                _reservation.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);

                _reservation.RoomId = Convert.ToInt16(cmbRoom.SelectedValue);

                _reservation.CheckInDate = dtpCheckIn.Value;

                _reservation.CheckOutDate = dtpCheckOut.Value;

                _reservation.Notes = string.IsNullOrEmpty(txtSpecialRequests.Text)
                    ? null
                    : txtSpecialRequests.Text;

                _reservation.ReservationStatus = ClsReservations.EnReservationStatus.Confirmed;


                if (_reservation.Save())
                {
                    if (lblReservationID.Text == "??")
                    {
                        lblReservationID.Text = _reservation.ReservationId.ToString();
                    }

                    clsLogger.LogInformation($"Reservation saved successfully. Reservation ID: {_reservation.ReservationId}");

                    MessageBox.Show(
                        "Reservation saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    clsLogger.LogWarning($"Failed to save reservation. Customer ID: {_reservation.CustomerId}, Room ID: {_reservation.RoomId}");

                    MessageBox.Show(
                        "Failed to save reservation.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while saving reservation.");

                MessageBox.Show(
                    "An unexpected error occurred while saving the reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validates that a customer has been selected in the combo box, setting an error indicator if not.
        private void cmbCustomer_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmb, "Please select a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmb, null);

            }
        }
    }
}