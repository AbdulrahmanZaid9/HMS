using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.reservations
{
    public partial class FrmCheckIn : Form
    {

        // Initializes the form and loads the reservation details into the embedded check-in confirmation control.
        public FrmCheckIn(int reservationId)
        {
            InitializeComponent();
            ctrlCheckInConfirm1.LoadReservationDetails(reservationId);
        }
    }
}