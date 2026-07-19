using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Rooms
{
    public partial class FrmViewRoom : Form
    {

        // Initializes the form and loads the given room's details into the embedded view control.
        public FrmViewRoom(short roomId)
        {
            InitializeComponent();
            ctrlViewRoom1.LoadRoomDetails(roomId);
        }
    }
}