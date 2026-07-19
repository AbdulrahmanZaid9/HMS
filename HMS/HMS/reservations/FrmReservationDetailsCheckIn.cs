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
    public partial class FrmReservationDetailsCheckIn : Form
    {


        // Initializes the form and loads the given reservation's details for check-in overview.
        public FrmReservationDetailsCheckIn(int reservationId)
        {
            InitializeComponent();
            ctrlReservationOverview1.LoadReservationDetails(reservationId, HMS_Buisness.ClsReservations.EnReservationStatus.CheckedIn);
        }

        // Initializes the form without loading any reservation details.
        public FrmReservationDetailsCheckIn()
        {
            InitializeComponent();
        }
    }
}