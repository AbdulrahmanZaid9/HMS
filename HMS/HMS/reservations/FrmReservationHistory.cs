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
    public partial class FrmReservationHistory : Form
    {
        private int _customerId;
        private string _fullName;

        // Initializes the form and stores the customer ID and name for loading their reservation history.
        public FrmReservationHistory(int customerId, string fullName)
        {
            InitializeComponent();
            _customerId = customerId;
            _fullName = fullName;
        }

        // Loads the customer's reservation history into the embedded history control when the form loads.
        private void FrmReservationHistory_Load(object sender, EventArgs e)
        {
            ucReservationHistory1.LoadResverstaionsInfo(_customerId, _fullName);
        }
    }
}