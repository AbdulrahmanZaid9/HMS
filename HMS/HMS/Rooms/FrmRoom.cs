using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Utilities;
namespace HMS
{
    public partial class FrmRoom : Form
    {
        private static DataTable _allRooms;

        private const int CARD_W = 330;
        private const int CARD_H = 295;
        private const int IMG_H = 148;

        Image ImageHeight = null;

        // Initializes the form and its designer-generated components.
        public FrmRoom()
        {
            InitializeComponent();
        }

        // Loads all room types into the type filter combo box, prefixed with an "All" option.
        private bool _LoadRoomTypes()
        {
            try
            {
                List<string> roomTypes = ClsRoomTypes.GetAllRoomTypes();

                if (roomTypes == null)
                    return false;


                roomTypes.Insert(0, "All");


                foreach (string roomType in roomTypes)
                {
                    cmbType.Items.Add(roomType);
                }


                return true;
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading room types.");
                return false;
            }
        }

        // Loads all room statuses into the status filter combo box.
        private bool _LoadRoomStatus()
        {
            try
            {
                List<string> roomStatuses = ClsRooms.GetAllRoomStatuses();

                if (roomStatuses == null)
                    return false;


                foreach (string roomStatus in roomStatuses)
                {
                    cmbStatus.Items.Add(roomStatus);
                }


                return true;
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading room statuses.");
                return false;
            }
        }

        // Loads all rooms, populates the status/type filters, and builds the initial room cards on form load.
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            try
            {
                _allRooms = ClsRooms.GetAllRooms();


                if (_allRooms == null || _allRooms.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load rooms.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }


                if (_LoadRoomStatus())
                {
                    cmbStatus.SelectedIndex = 0;
                }


                if (_LoadRoomTypes())
                {
                    cmbType.SelectedIndex = 0;
                }


                BuildAllCards();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading rooms management form.");

                MessageBox.Show(
                    "An unexpected error occurred while loading rooms.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Clears and rebuilds the room card layout for all currently filtered rooms.
        private void BuildAllCards()
        {
            try
            {
                flowCards.SuspendLayout();

                flowCards.Controls.Clear();


                lblSubtitle.Text =
                    $"{_allRooms.DefaultView.Count} of {_allRooms.Rows.Count} rooms";


                foreach (DataRowView row in _allRooms.DefaultView)
                {
                    ClsRooms room = new ClsRooms(
                        (short)row["room_id"],
                        (short)row["room_number"],
                        (byte)row["floor_number"],
                        (byte)row["room_type_id"],
                        (decimal)row["price_per_night"],
                        (byte)row["capacity"],
                        row["amenities"].ToString(),
                        row["description"].ToString(),
                        row["image_path"].ToString(),
                        (ClsRooms.EnRoomStatus)Convert.ToByte(row["room_status"])
                    );


                    flowCards.Controls.Add(BuildCard(room));
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while building room cards.");

                MessageBox.Show(
                    "An unexpected error occurred while displaying rooms.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                flowCards.ResumeLayout(true);
            }
        }

        // Loads the given room's image (or a default image on failure/missing file) into the ImageHeight field.
        private void _LoadImagePreview(ClsRooms room)
        {
            string imagePath = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, room.ImagePath);

            if (File.Exists(imagePath))
            {
                try
                {
                    ImageHeight = Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, room.ImagePath))));
                }
                catch
                {
                    ImageHeight = Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath))));
                }
            }
            else
            {
                ImageHeight = Image.FromStream(new MemoryStream(File.ReadAllBytes(Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath))));
            }
        }

        // Opens the edit room form for the room attached to the clicked button, then refreshes the room list.
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ClsRooms room = (ClsRooms)button.Tag;
            FrmEditRoom editForm = new FrmEditRoom(room);
            editForm.ShowDialog();
            _RefreshRoom();
        }

        // Constructs a fully styled room card panel (image, badges, edit button, and detail rows) for the given room.
        private Panel BuildCard(ClsRooms room)
        {
            _LoadImagePreview(room);
            string roomNum = room.RoomNumber.ToString();
            string type = room.RoomType != null ? room.RoomType.RoomTypeName : "Unknown";
            if (type == "Unknown")
            {
                MessageBox.Show($"Room type with ID {room.RoomTypeId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string status = room.StatusString;
            int floor = room.FloorNumber;
            int cap = room.Capacity;
            decimal price = room.PricePerNight;

            Panel card = new Panel
            {
                Width = CARD_W,
                Height = CARD_H,
                BackColor = Color.White,
                Margin = new Padding(8),
            };
            card.Paint += Card_Paint;

            Panel imgPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(CARD_W, IMG_H),
                BackgroundImage = ImageHeight,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Label badge = new Label
            {
                AutoSize = false,
                Size = new Size(84, 24),
                Location = new Point(CARD_W - 92, 8),
                Text = status,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = StatusBg(status),
                ForeColor = StatusFg(status),
            };
            Rounded(badge, 10);
            imgPanel.Controls.Add(badge);
            card.Controls.Add(imgPanel);

            Button btnEdit = new Button
            {
                Size = new Size(30, 30),
                Location = new Point(CARD_W - 38, IMG_H + 8),
                Text = "✏",
                Font = new Font("Segoe UI Emoji", 10F),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(239, 246, 255),
                ForeColor = Color.FromArgb(59, 91, 219),
                Cursor = Cursors.Hand,
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            Rounded(btnEdit, 6);
            btnEdit.Tag = room;
            btnEdit.Click += BtnEdit_Click;

            card.Controls.Add(btnEdit);

            card.Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(12, IMG_H + 10),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Text = $"Room {roomNum}",
            });

            Label pill = new Label
            {
                AutoSize = false,
                Size = new Size(88, 20),
                Location = new Point(12, IMG_H + 36),
                Text = type,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = TypePillBg(type),
                ForeColor = TypePillFg(type),
            };
            Rounded(pill, 8);
            card.Controls.Add(pill);

            card.Controls.Add(new Panel
            {
                Location = new Point(12, IMG_H + 62),
                Size = new Size(CARD_W - 24, 1),
                BackColor = Color.FromArgb(226, 232, 240),
            });

            Row(card, "Floor", floor.ToString(), IMG_H + 70);
            Row(card, "Capacity", $"{cap} guests", IMG_H + 96);
            Row(card, "Price/Night", $"${price}", IMG_H + 122, blue: true);

            return card;
        }

        // Adds a key/value label row (e.g. "Floor: 3") to the given card panel at the specified vertical position.
        private void Row(Panel card, string key, string val, int y, bool blue = false)
        {
            card.Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(12, y),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(100, 116, 139),
                Text = key,
            });

            card.Controls.Add(new Label
            {
                AutoSize = false,
                Size = new Size(130, 20),
                Location = new Point(CARD_W - 142, y),
                Font = blue ? new Font("Segoe UI", 9.5F, FontStyle.Bold) : new Font("Segoe UI", 9F),
                ForeColor = blue ? Color.FromArgb(59, 91, 219) : Color.FromArgb(15, 23, 42),
                Text = val,
                TextAlign = ContentAlignment.TopRight,
            });
        }

        // Draws the light border rectangle around a room card.
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
                DrawRoundRect(e.Graphics, pen, 0, 0, p.Width - 1, p.Height - 1, 10);
        }

        // Draws the bottom divider line under the top bar panel.
        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        // Draws the bottom divider line under the filter bar panel.
        private void pnlFilterBar_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        // Draws the rounded border around the search box panel.
        private void pnlSearchBox_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(203, 213, 225), 1.2f))
                DrawRoundRect(e.Graphics, pen, 0, 0, p.Width - 1, p.Height - 1, 6);
        }

        // Returns the background color for a room status badge based on the status text.
        private static Color StatusBg(string s)
        {
            switch (s)
            {
                case "Available": return Color.FromArgb(220, 252, 231);
                case "Occupied": return Color.FromArgb(254, 226, 226);
                case "Cleaning": return Color.FromArgb(254, 243, 199);
                case "Maintenance": return Color.FromArgb(237, 233, 254);
                default: return Color.FromArgb(240, 241, 248);
            }
        }

        // Returns the foreground (text) color for a room status badge based on the status text.
        private static Color StatusFg(string s)
        {
            switch (s)
            {
                case "Available": return Color.FromArgb(22, 101, 52);
                case "Occupied": return Color.FromArgb(153, 27, 27);
                case "Cleaning": return Color.FromArgb(146, 64, 14);
                case "Maintenance": return Color.FromArgb(91, 33, 182);
                default: return Color.FromArgb(100, 116, 139);
            }
        }

        // Returns the background color for a room type pill based on the type name.
        private static Color TypePillBg(string t)
        {
            switch (t)
            {
                case "Standard": return Color.FromArgb(241, 245, 249);
                case "Deluxe": return Color.FromArgb(219, 234, 254);
                case "Suite": return Color.FromArgb(237, 233, 254);
                case "Presidential": return Color.FromArgb(254, 243, 199);
                case "Family": return Color.FromArgb(220, 252, 231);
                default: return Color.FromArgb(241, 245, 249);
            }
        }

        // Returns the foreground (text) color for a room type pill based on the type name.
        private static Color TypePillFg(string t)
        {
            switch (t)
            {
                case "Standard": return Color.FromArgb(71, 85, 105);
                case "Deluxe": return Color.FromArgb(29, 78, 216);
                case "Suite": return Color.FromArgb(109, 40, 217);
                case "Presidential": return Color.FromArgb(146, 64, 14);
                case "Family": return Color.FromArgb(22, 101, 52);
                default: return Color.FromArgb(71, 85, 105);
            }
        }

        // Draws a rounded rectangle outline with the given pen.
        private static void DrawRoundRect(Graphics g, Pen pen, int x, int y, int w, int h, int r)
        {
            using (GraphicsPath path = RoundPath(x, y, w, h, r))
                g.DrawPath(pen, path);
        }

        // Builds a rounded-rectangle graphics path for the given bounds and corner radius.
        private static GraphicsPath RoundPath(int x, int y, int w, int h, int r)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddArc(x, y, r * 2, r * 2, 180, 90);
            p.AddArc(x + w - r * 2, y, r * 2, r * 2, 270, 90);
            p.AddArc(x + w - r * 2, y + h - r * 2, r * 2, r * 2, 0, 90);
            p.AddArc(x, y + h - r * 2, r * 2, r * 2, 90, 90);
            p.CloseFigure();
            return p;
        }

        // Clips the given control's region to a rounded rectangle with the specified corner radius.
        private static void Rounded(Control ctrl, int r)
        {
            ctrl.Region = new Region(RoundPath(0, 0, ctrl.Width - 1, ctrl.Height - 1, r));
        }

        // Reloads all rooms from the database and rebuilds the card display.
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _allRooms = ClsRooms.GetAllRooms();
                if (_allRooms == null || _allRooms.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load rooms.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                BuildAllCards();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing rooms list.");

                MessageBox.Show(
                    "An unexpected error occurred while refreshing rooms.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Reloads all rooms from the database and reapplies the current filters.
        private void _RefreshRoom()
        {
            try
            {
                _allRooms = ClsRooms.GetAllRooms();

                if (_allRooms == null || _allRooms.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Failed to load rooms data.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();

                    return;
                }

                _ApplyFilters();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while refreshing rooms.");

                MessageBox.Show(
                    "An unexpected error occurred while loading rooms.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Reapplies filters whenever the search text changes.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        // Restricts keyboard input in the search box to valid integer characters.
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidInteger(e.KeyChar);
        }

        // Clears the search box on focus if its content isn't a valid number.
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !ClsValidation.IsNumber(txtSearch.Text))
            {
                txtSearch.Text = "";
            }
        }

        // Restores the placeholder text in the search box when it loses focus and is empty.
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search by room number";
            }

        }

        // Clears the active control focus once the form is shown.
        private void FrmRoom_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        // Reapplies filters whenever the status filter selection changes.
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        // Builds and applies a combined status/type/search row filter to the rooms data view, then rebuilds the cards.
        private void _ApplyFilters()
        {
            try
            {
                List<string> filters = new List<string>();


                // Status filter
                if (cmbStatus.Text != "All")
                {
                    filters.Add(
                        $"room_status = {ClsRooms.GetStatusNumberByName(cmbStatus.Text.Trim())}"
                    );
                }


                // Type filter
                if (cmbType.Text != "All")
                {
                    filters.Add(
                        $"room_type_id = {ClsRoomTypes.FindRoomtypeIDByName(cmbType.Text.Trim())}"
                    );
                }


                // Search filter
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    if (short.TryParse(txtSearch.Text.Trim(), out short roomNumber))
                    {
                        filters.Add(
                            $"Convert(room_number, 'System.String') LIKE '%{roomNumber}%'"
                        );
                    }
                }


                if (_allRooms != null)
                {
                    _allRooms.DefaultView.RowFilter = string.Join(" AND ", filters);
                }


                BuildAllCards();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while applying room filters.");

                MessageBox.Show(
                    "An unexpected error occurred while filtering rooms.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Reapplies filters whenever the type filter selection changes.
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }
    }
}