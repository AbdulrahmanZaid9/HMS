using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Drawing;
using System.Windows.Forms;
using static HMS_Buisness.ClsReservations;

namespace HMS.reservations.Controls
{
    public partial class CtrlCurrentReservation : UserControl
    {
        private ClsReservations _reservation;

        // Initializes the control and its designer-generated components.
        public CtrlCurrentReservation()
        {
            InitializeComponent();
        }
        private int _reservationId;

        // Loads a reservation by ID and populates all display fields, badges, and status color coding.
        public void LoadReservation(int reservationId)
        {
            try
            {
                _reservation = ClsReservations.FindReservationById(reservationId);

                if (_reservation == null)
                {
                    clsLogger.LogWarning($"Reservation not found. Reservation ID: {reservationId}");

                    MessageBox.Show(
                        $"No reservation was found with ID #{reservationId}.\n\n" +
                        "Please verify the ID and try again.",
                        "Reservation Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.FindForm().Close();
                    return;
                }


                _reservationId = reservationId;

                lblReservationIdBadge.Text = $"RESERVATION ID {_reservation.ReservationId}";


                string[] customerNameParts = _reservation.Customer.Person.FullName.Split();

                lblCustomerName.Text = customerNameParts.Length > 1
                    ? $"{customerNameParts[0]} {customerNameParts[1]}"
                    : customerNameParts[0];


                lblCustomerId.Text = $"{_reservation.CustomerId}";
                lblRoomNumber.Text = $"{_reservation.Room.RoomNumber}";
                lblRoomId.Text = $"{_reservation.RoomId}";

                lblCheckIn.Text = _reservation.CheckInDate.ToString("yyyy-MM-dd-HH-mm");
                lblCheckOut.Text = _reservation.CheckOutDate.ToString("yyyy-MM-dd-HH-mm");

                lblActualCheckout.Text = _reservation.ActualCheckOut == DateTime.MinValue
                    ? "Not checked out yet"
                    : _reservation.ActualCheckOut.ToString("yyyy-MM-dd-HH-mm");

                lblActualCheckin.Text = _reservation.ActualCheckIn == DateTime.MinValue
                    ? "Not checked in yet"
                    : _reservation.ActualCheckIn.ToString("yyyy-MM-dd-HH-mm");


                lblNotes.Text = string.IsNullOrEmpty(_reservation.Notes)
                    ? "—"
                    : _reservation.Notes;


                lblStatusBadge.Text = _reservation.ReservationStatusString;


                int nights = (_reservation.CheckOutDate.Date - _reservation.CheckInDate.Date).Days;

                lblNights.Text = nights.ToString();


                decimal servicesCharge = ClsServiceBookings.GetServicesChargeByReservationId(_reservationId);

                lblTotalPrice.Text = $"${(_reservation.Room.PricePerNight * nights) + servicesCharge}";


                switch (_reservation.ReservationStatus)
                {
                    case EnReservationStatus.Confirmed:
                        lblStatusBadge.BackColor = Color.RoyalBlue;
                        lblStatusBadge.ForeColor = Color.White;
                        break;

                    case EnReservationStatus.CheckedIn:
                        lblStatusBadge.BackColor = Color.SeaGreen;
                        lblStatusBadge.ForeColor = Color.White;
                        break;

                    case EnReservationStatus.CheckedOut:
                        lblStatusBadge.BackColor = Color.DimGray;
                        lblStatusBadge.ForeColor = Color.White;
                        break;

                    case EnReservationStatus.Cancelled:
                        lblStatusBadge.BackColor = Color.Firebrick;
                        lblStatusBadge.ForeColor = Color.White;
                        break;

                    default:
                        lblStatusBadge.BackColor = Color.LightGray;
                        lblStatusBadge.ForeColor = Color.Black;
                        break;
                }
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

        // Opens the add/update reservation form for editing, then reloads the reservation on close.
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateReservations addUpdateReservationsForm = new FrmAddUpdateReservations(_reservationId);

                addUpdateReservationsForm.ShowDialog();

                LoadReservation(_reservationId);
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while opening edit reservation form. Reservation ID: {_reservationId}");

                MessageBox.Show(
                    "An unexpected error occurred while editing reservation.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Closes the parent form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}