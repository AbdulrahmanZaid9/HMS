using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Users
{
    public partial class FrmViewProfile : Form
    {
        // Initializes the form, centers it on screen, and loads the given user's profile into the embedded control.
        public FrmViewProfile(int userId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            ctrlViewUserProfile1.LoadData(userId);
        }
    }
}