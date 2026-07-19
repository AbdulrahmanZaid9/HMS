using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.ServicesBooking
{
    public partial class FrmEditServiceBooking : Form
    {
        // Initializes the form and loads the given booking's info into the embedded edit control.
        public FrmEditServiceBooking(string fullName, int bookingId)
        {
            InitializeComponent();
            ucEditServiceBooking1.LoadInfo(bookingId, fullName);
        }
    }
}