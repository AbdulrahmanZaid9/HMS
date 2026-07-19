using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Customers
{
    public partial class FrmViewCustomerInfo : Form
    {
        // Initializes the form and its designer-generated components.
        public FrmViewCustomerInfo()
        {
            InitializeComponent();
        }

        // Initializes the form and loads the profile of the given customer into the embedded profile control.
        public FrmViewCustomerInfo(int customerId)
        {
            InitializeComponent();
            ctrlViewCusomterProfile1.LoadCustomerProfile(customerId);
        }
    }
}