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
    public partial class FrmCurrentReservation : Form
    {
        // Initializes the form and loads the given reservation into the embedded current-reservation control.
        public FrmCurrentReservation(int reservationId)
        {
            InitializeComponent();
            ctrlCurrentReservation1.LoadReservation(reservationId);
        }
    }
}