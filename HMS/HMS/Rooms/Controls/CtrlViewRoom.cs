using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HMS_Buisness.ClsReservations;
using static HMS_Buisness.ClsRooms;
namespace HMS.Rooms.Controls
{
    public partial class CtrlViewRoom : UserControl
    {
        // Initializes the control and its designer-generated components.
        public CtrlViewRoom()
        {
            InitializeComponent();
        }

        private ClsRooms _room;
        private short _roomId;

        // Opens the edit room form for the current room, then reloads the room details on close.
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditRoom frmEditRoom = new FrmEditRoom(_room);

                frmEditRoom.ShowDialog();

                LoadRoomDetails(_roomId);
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while opening edit room form.");

                MessageBox.Show(
                    "An unexpected error occurred while editing room information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads a room by ID and populates all detail fields, status badge coloring, and the image preview.
        public void LoadRoomDetails(short roomId)
        {
            try
            {
                _room = ClsRooms.FindRoomById(roomId);

                if (_room == null)
                {
                    MessageBox.Show(
                        $"No room was found with ID #{roomId}.\n\n" +
                        "Please verify the ID and try again.",
                        "Room Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                _roomId = roomId;

                lblRoomNumberBadge.Text = $"ROOM #{_room.RoomNumber}";
                lblRoomNumberValue.Text = $"{_room.RoomNumber}";
                lblFloorValue.Text = $"{_room.FloorNumber}";
                lblRoomTypeValue.Text = _room.RoomType == null ? "—" : _room.RoomType.RoomTypeName;
                lblCapacityValue.Text = $"{_room.Capacity}";
                lblPriceValue.Text = $"${_room.PricePerNight}";
                lblRoomIdValue.Text = $"{_room.RoomId}";
                lblAmenitiesValue.Text = string.IsNullOrEmpty(_room.Amenities) ? "—" : _room.Amenities;
                lblDescriptionValue.Text = string.IsNullOrEmpty(_room.Description) ? "—" : _room.Description;
                lblImagePathValue.Text = string.IsNullOrEmpty(_room.ImagePath) ? "—" : _room.ImagePath;

                lblStatusBadge.Text = _room.StatusString;


                switch (_room.RoomStatus)
                {
                    case ClsRooms.EnRoomStatus.Available:
                        lblStatusBadge.BackColor = Color.SeaGreen;
                        lblStatusBadge.ForeColor = Color.White;
                        break;


                    case ClsRooms.EnRoomStatus.Occupied:
                        lblStatusBadge.BackColor = Color.RoyalBlue;
                        lblStatusBadge.ForeColor = Color.White;
                        break;


                    case ClsRooms.EnRoomStatus.Maintenance:
                        lblStatusBadge.BackColor = Color.DarkOrange;
                        lblStatusBadge.ForeColor = Color.White;
                        break;


                    case ClsRooms.EnRoomStatus.Cleaning:
                        lblStatusBadge.BackColor = Color.Firebrick;
                        lblStatusBadge.ForeColor = Color.White;
                        break;


                    default:
                        lblStatusBadge.BackColor = Color.LightGray;
                        lblStatusBadge.ForeColor = Color.Black;
                        break;
                }


                _LoadImagePreview();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading room details. Room ID: {roomId}");

                MessageBox.Show(
                    "An unexpected error occurred while loading room details.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the room's image into the picture box, falling back to a default image if missing or unloadable.
        private void _LoadImagePreview()
        {
            string imagePath = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, _room.ImagePath);

            if (File.Exists(imagePath))
            {
                try
                {
                    picRoomImage.Load(imagePath);
                }
                catch
                {
                    picRoomImage.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
                }
            }
            else
            {
                picRoomImage.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
            }
        }

        // Closes the parent form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();

        }
    }
}