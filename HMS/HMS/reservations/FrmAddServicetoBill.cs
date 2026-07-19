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
    public partial class FrmAddServicetoBill : Form
    {
        // Initializes the form and loads service/bill info for the given reservation and bill into the embedded control.
        public FrmAddServicetoBill(int reservationId, int billId)
        {
            InitializeComponent();
            ctrlAddServiceToBill1.LoadInfo(reservationId, billId);
        }
    }
}