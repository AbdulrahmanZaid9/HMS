using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Windows.Forms;
using Utilities;

namespace HMS.reservations.Controls
{
    public partial class CtrlCheckInConfirm : UserControl
    {
        private ClsReservations _reservation;

        // Initializes the control and its designer-generated components.
        public CtrlCheckInConfirm()
        {
            InitializeComponent();
        }

        // Forwards guest, room, and stay details to the embedded summary control for display.
        public void SetDetails(string guestName, string roomInfo, DateTime checkIn, DateTime checkOut, int nights, decimal roomTotal)
        {
            ctrlSummary.SetDetails(guestName, roomInfo, checkIn, checkOut, nights, roomTotal);
        }

        // Closes the parent form without confirming the check-in.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        // Confirms check-in by updating reservation/room status, creating a bill, and recording the deposit payment, closing the form when done.
        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClsReservations.ChangeReservationStatus(ClsReservations.EnReservationStatus.CheckedIn, _reservation.ReservationId))
                {
                    clsLogger.LogWarning($"Failed to confirm check-in. Reservation ID: {_reservation.ReservationId}");

                    MessageBox.Show(
                        "Failed to confirm check-in.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                if (!ClsRooms.ChangeRoomStatus(ClsRooms.EnRoomStatus.Occupied, _reservation.Room.RoomId))
                {
                    clsLogger.LogWarning($"Failed to update room status to Occupied. Room ID: {_reservation.Room.RoomId}");

                    MessageBox.Show(
                        "Failed to update room status.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                ClsBills bill = new ClsBills();

                bill.ReservationId = _reservation.ReservationId;
                bill.BillStatus = ClsBills.EnBillStatus.Unpaid;


                if (!bill.Save())
                {
                    clsLogger.LogWarning($"Failed to create bill. Reservation ID: {_reservation.ReservationId}");

                    MessageBox.Show(
                        "Failed to create bill.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }

                ClsPayments payment = new ClsPayments();

                payment.BillId = bill.BillId;
                payment.Amount = ClsGlobal.DepoisteAmount;
                payment.PaymentDate = DateTime.Now;
                payment.PaymentTypeId = (byte)ClsPaymentTypes.EnPaymentTypes.Deposite;
                payment.PaymentMethodId = (byte)ClsPaymentMethods.EnPaymentMethods.Cash;
                payment.TransactionReference = clsUtil.GenerateTransactionReference();


                if (!payment.Save())
                {
                    clsLogger.LogWarning($"Failed to record deposit payment. Bill ID: {bill.BillId}");

                    MessageBox.Show(
                        "Failed to record security deposit payment.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.FindForm().Close();
                    return;
                }


                clsLogger.LogInformation($"Check-in completed successfully. Reservation ID: {_reservation.ReservationId}, Bill ID: {bill.BillId}");


                MessageBox.Show(
                    "Check-in confirmed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                this.FindForm().Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while confirming check-in. Reservation ID: {_reservation.ReservationId}");

                MessageBox.Show(
                    "An unexpected error occurred while confirming check-in.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the reservation (with customer and room), validates it, computes totals, and populates the summary display.
        public void LoadReservationDetails(int reservationId)
        {
            try
            {
                _reservation = ClsReservations.FindReservationById(reservationId);

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


                int totalDays = (_reservation.CheckOutDate.Date - _reservation.CheckInDate.Date).Days;

                decimal totalAmount = _reservation.Room.PricePerNight * totalDays;


                SetDetails(
                    _reservation.Customer.Person.FullName,
                    _reservation.Room.RoomNumber.ToString(),
                    _reservation.CheckInDate,
                    _reservation.CheckOutDate,
                    totalDays,
                    totalAmount);
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
    }
}