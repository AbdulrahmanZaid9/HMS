using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.reservations.Controls
{
    public partial class CtrlReservationOverview : UserControl
    {

        ClsReservations _reservation = new ClsReservations();
        private ClsReservations.EnReservationStatus _status;

        // Initializes the control and its designer-generated components.
        public CtrlReservationOverview()
        {
            InitializeComponent();
        }

        // Populates room detail fields, applies status badge coloring, and loads the room image preview.
        private void _LoadRoomDetails()
        {
            lblRoomId.Text = _reservation.RoomId.ToString();
            lblRoomNumber.Text = _reservation.Room.RoomNumber.ToString();
            lblFloor.Text = _reservation.Room.FloorNumber.ToString();
            lblRoomType.Text = _reservation.Room.RoomType.RoomTypeName;
            lblCapacity.Text = _reservation.Room.Capacity.ToString();
            lblPrice.Text = $"${_reservation.Room.PricePerNight}";
            lblAmenities.Text = string.IsNullOrEmpty(_reservation.Room.Amenities) ? "No amenities available" : _reservation.Room.Amenities;
            lblDescription.Text = string.IsNullOrEmpty(_reservation.Room.Description) ? "No description available" : _reservation.Room.Description;
            lblRoomStatusBadge.Text = _reservation.Room.StatusString;
            switch (_reservation.Room.RoomStatus)
            {
                case ClsRooms.EnRoomStatus.Available:
                    lblRoomStatusBadge.BackColor = Color.SeaGreen;
                    lblRoomStatusBadge.ForeColor = Color.White;
                    break;

                case ClsRooms.EnRoomStatus.Occupied:
                    lblRoomStatusBadge.BackColor = Color.RoyalBlue;
                    lblRoomStatusBadge.ForeColor = Color.White;

                    break;

                case ClsRooms.EnRoomStatus.Maintenance:
                    lblRoomStatusBadge.BackColor = Color.DarkOrange;
                    lblRoomStatusBadge.ForeColor = Color.White;
                    break;

                case ClsRooms.EnRoomStatus.Cleaning:
                    lblRoomStatusBadge.BackColor = Color.Firebrick;
                    lblRoomStatusBadge.ForeColor = Color.White;
                    break;

                default:
                    lblRoomStatusBadge.BackColor = Color.LightGray;
                    lblRoomStatusBadge.ForeColor = Color.Black;
                    break;
            }

            lblImagePath.Text = string.IsNullOrEmpty(_reservation.Room.ImagePath) ? "No image available" : _reservation.Room.ImagePath;
            _LoadImagePreview();
        }

        // Populates customer detail fields and applies active/inactive status badge styling.
        private void _LoadCustomerDetails()
        {
            lblCustIdBadge.Text = $"CUST: {_reservation.CustomerId}";
            lblPersonIdBadge.Text = $"Person: {_reservation.Customer.PersonId}";
            lblEmail.Text = _reservation.Customer.Person.Email;
            lblCustomerName.Text = _reservation.Customer.Person.FullName;
            lblPhone.Text = _reservation.Customer.Person.Phone;
            lblAddress.Text = _reservation.Customer.Person.Address;
            lblGender.Text = _reservation.Customer.Person.Gender == false ? "male" : "female";
            lblNationality.Text = _reservation.Customer.Person.Nationality.CountryName;
            lblPassport.Text = _reservation.Customer.Person.PassportNumber;
            lblDOB.Text = _reservation.Customer.Person.DateOfBirth.ToString("dd/MM/yyyy");
            lblCustomerNotes.Text = string.IsNullOrEmpty(_reservation.Customer.Person.Notes) ? "No notes available" : _reservation.Customer.Person.Notes;

            lblStatusBadge.Text = _reservation.Customer.IsActive ? "Active" : "Inactive";

            lblStatusBadge.BackColor = _reservation.Customer.IsActive
                ? Color.FromArgb(22, 101, 52)
                : Color.FromArgb(127, 29, 29);
            lblStatusBadge.ForeColor = _reservation.Customer.IsActive
                ? Color.FromArgb(187, 247, 208)
                : Color.FromArgb(254, 202, 202);
        }

        // Populates reservation detail fields including dates, nights, total price, and notes.
        private void _LoadResversationDetails()
        {
            lblReservationIdBadge.Text = $"RESERVATION ID {_reservation.ReservationId}";
            lblCheckIn.Text = _reservation.CheckInDate.ToString("dd/MM/yyyy");
            lblCheckOut.Text = _reservation.CheckOutDate.ToString("dd/MM/yyyy");
            lblActualCheckout.Text = _reservation.ActualCheckOut == DateTime.MinValue ? "Not checked out yet" : _reservation.ActualCheckOut.ToString("dd/MM/yyyy");
            lblActualCheckin.Text = _reservation.ActualCheckIn == DateTime.MinValue ? "Not checked in yet" : _reservation.ActualCheckIn.ToString("dd/MM/yyyy");

            lblNights.Text = _reservation.CheckOutDate.Date.Subtract(_reservation.CheckInDate.Date).Days.ToString();
            lblTotalPrice.Text = $"${_reservation.Room.PricePerNight * _reservation.CheckOutDate.Date.Subtract(_reservation.CheckInDate.Date).Days + ClsServiceBookings.GetServicesChargeByReservationId(_reservation.ReservationId)}";
            lblNotes.Text = string.IsNullOrEmpty(_reservation.Notes) ? "No notes available" : _reservation.Notes;
        }

        // Loads a reservation by ID/status, validates related data exists, then populates customer, reservation, and room sections.
        public void LoadReservationDetails(int reservationId, ClsReservations.EnReservationStatus status)
        {
            try
            {
                _reservation = ClsReservations.FindReservationById(reservationId);
                _status = status;


                if (_reservation == null)
                {
                    clsLogger.LogWarning($"Reservation not found. Reservation ID: {reservationId}");

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
                    clsLogger.LogWarning($"Customer details not found for reservation. Reservation ID: {reservationId}");

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
                    clsLogger.LogWarning($"Room details not found for reservation. Reservation ID: {reservationId}");

                    MessageBox.Show(
                        "Room details not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                _LoadCustomerDetails();

                _LoadResversationDetails();

                _LoadRoomDetails();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading reservation details. Reservation ID: {reservationId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading reservation details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the room's image into the picture box, falling back to a default image if missing or unloadable.
        private void _LoadImagePreview()
        {
            string imagePath = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, _reservation.Room.ImagePath);

            if (File.Exists(imagePath))
            {
                try
                {
                    picRoomImage.Load(imagePath);
                }
                catch
                {
                    picRoomImage.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
                }
            }
            else
            {
                picRoomImage.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
            }
        }

        // Closes the parent form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        // Opens the check-in or check-out form based on the current reservation status, then closes this form.
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_status == ClsReservations.EnReservationStatus.CheckedIn)
                {
                    FrmCheckIn checkInForm = new FrmCheckIn(_reservation.ReservationId);
                    checkInForm.ShowDialog();
                }
                else
                {
                    int billId = ClsBills.GetBillIdByReservationId(_reservation.ReservationId);

                    FrmCheckOut checkOutForm = new FrmCheckOut(
                        _reservation.ReservationId,
                        billId,
                        _reservation.RoomId,
                        _reservation.CustomerId);

                    checkOutForm.ShowDialog();
                }

                this.FindForm().Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while opening check-in/check-out window. Reservation ID: {_reservation.ReservationId}");

                MessageBox.Show(
                    "An unexpected error occurred while opening the window.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Sets the process button's label based on whether the reservation needs check-in or check-out.
        private void CtrlReservationOverview_Load(object sender, EventArgs e)
        {
            btnProcessInfo.Text = _status == ClsReservations.EnReservationStatus.CheckedIn ? "➡️ Process To Check In" : "➡️ Process To Check Out";
        }
    }
}