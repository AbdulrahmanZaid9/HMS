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
    public partial class FrmCheckOut : Form
    {
        // Initializes the form, wires up the layout-complete event, and loads the bill summary for the given reservation/bill.
        public FrmCheckOut(int reservationId, int BillId, short RoomId, int cusomerId)
        {
            InitializeComponent();
            ctrlBillSummary1.SummaryLayoutComplete += OnSummaryLayoutComplete;
            ctrlBillSummary1.LoadSummary(reservationId, BillId, RoomId, cusomerId);
        }

        // Resizes the form to fit the bill summary control once its real size is known.
        private void OnSummaryLayoutComplete(object sender, EventArgs e)
        {
            // Now the control knows its real size — fit the form around it
            this.ClientSize = new Size(
                ctrlBillSummary1.Right + ctrlBillSummary1.Left,
                ctrlBillSummary1.Bottom + ctrlBillSummary1.Top
            );
        }
    }
}