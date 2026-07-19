using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Utilities;
using static HMS_Buisness.ClsRooms;

namespace HMS
{
    public partial class FrmEditRoom : Form
    {

        // Accent colors
        private static readonly Color AccentColor = Color.FromArgb(99, 102, 241);   // Indigo-500
        private static readonly Color AccentDark = Color.FromArgb(67, 56, 202);   // Indigo-700
        private static readonly Color HeaderBg = Color.FromArgb(15, 23, 42);   // Slate-950
        private static readonly Color BodyBg = Color.FromArgb(248, 249, 252);  // near-white
        private static readonly Color InputBorder = Color.FromArgb(209, 213, 219);
        private static readonly Color InputFocusBorder = Color.FromArgb(99, 102, 241);
        private static readonly Color LabelColor = Color.FromArgb(71, 85, 105);

        // Initializes the form and stores the room to be edited.
        public FrmEditRoom(ClsRooms room)
        {
            InitializeComponent();
            _room = room;
        }

        private ClsRooms _room;

        // Populates all form fields, status/type combo boxes, and image preview from the room being edited.
        private void _LoadRoomData()
        {
            try
            {
                txtRoomID.Text = _room.RoomId.ToString();
                txtRoomNumber.Text = _room.RoomNumber.ToString();
                txtFloor.Text = _room.FloorNumber.ToString();
                txtPrice.Text = _room.PricePerNight.ToString();
                txtCapacity.Text = _room.Capacity.ToString();
                txtAmenities.Text = _room.Amenities;
                txtDescription.Text = _room.Description;


                cmbStatus.Items.Add(EnRoomStatus.Available.ToString());
                cmbStatus.Items.Add(EnRoomStatus.Occupied.ToString());
                cmbStatus.Items.Add(EnRoomStatus.Maintenance.ToString());
                cmbStatus.Items.Add(EnRoomStatus.Cleaning.ToString());


                if (_room.RoomType == null)
                {
                    MessageBox.Show(
                        $"Room type with room number {_room.RoomNumber} not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    cmbRoomType.Items.Add("Unknown");
                }
                else
                {
                    cmbRoomType.Items.Add(_room.RoomType.RoomTypeName);
                }


                cmbStatus.SelectedItem = _room.RoomStatus.ToString();

                cmbRoomType.SelectedIndex = 0;


                lblImagePath.Text = _room.ImagePath;

                lblImagePath.ForeColor = AccentColor;


                pnlImagePreview.Invalidate();

                _LoadImagePreview();


                lblTitle.Text = $"Edit Room — {_room.RoomNumber}";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading room data into edit form.");

                MessageBox.Show(
                    "An unexpected error occurred while loading room information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Loads the room's image into the preview box, falling back to a default image if missing or unloadable.
        private void _LoadImagePreview()
        {
            string imagePath = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, _room.ImagePath);

            if (File.Exists(imagePath))
            {
                try
                {
                    picPreview.Load(imagePath);
                    lblImagePath.Text = _room.ImagePath;
                    lblImagePath.ForeColor = AccentColor;
                    pnlImagePreview.Invalidate();
                }
                catch
                {
                    picPreview.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
                    lblImagePath.Text = ClsGlobal.DefulatImagePath;
                    lblImagePath.ForeColor = Color.Red;
                    pnlImagePreview.Invalidate();
                }
            }
            else
            {
                picPreview.ImageLocation = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, ClsGlobal.DefulatImagePath);
                lblImagePath.Text = ClsGlobal.DefulatImagePath;
                lblImagePath.ForeColor = Color.Gray;
                pnlImagePreview.Invalidate();
            }
        }

        // Loads room data, rounds button corners, and wires up input focus styling when the form loads.
        private void FrmEditRoom_Load(object sender, EventArgs e)
        {
            _LoadRoomData();

            RoundControl(btnSave, 10);
            RoundControl(btnCancel, 10);
            RoundControl(btnBrowseImage, 6);

            WireInputFocus(txtPrice, pnlPrice);
            WireInputFocus(txtAmenities, pnlAmenities);
            WireInputFocus(txtDescription, pnlDescription);
        }

        // Wires an input control's Enter/Leave events to toggle its wrapping panel's focus visual state.
        private void WireInputFocus(Control input, Panel panel)
        {
            input.Enter += (s, e) => { panel.Tag = "focus"; panel.Invalidate(); };
            input.Leave += (s, e) => { panel.Tag = null; panel.Invalidate(); };
        }

        // If the image was changed, deletes the old room image file and copies the new one into the project images folder.
        private bool _HandlePersonImage()
        {
            if (_room.ImagePath != lblImagePath.Text)
            {
                if (_room.ImagePath != "")
                {
                    try
                    {
                        File.Delete(Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName, _room.ImagePath));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (picPreview.ImageLocation != null)
                {
                    string imagePath = picPreview.ImageLocation.ToString();
                    string startupPath = Path.Combine(Application.StartupPath, ClsGlobal.ImagesFolderName);


                    if (clsUtil.CopyImageToProjectImagesFolder(startupPath, ref imagePath))
                    {
                        _room.ImagePath = Path.GetFileName(imagePath);
                        picPreview.ImageLocation = imagePath;

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to copy new image. Please check file permissions.", "Image Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        // Opens a file dialog to select a new room image and loads it into the preview.
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Room Image";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picPreview.Load(dlg.FileName);
                        lblImagePath.Text = Path.GetFileName(dlg.FileName);
                        lblImagePath.ForeColor = AccentColor;
                        pnlImagePreview.Invalidate();
                    }
                    catch
                    {
                        MessageBox.Show("Could not load the selected image.", "Image Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Validates input, handles image changes, saves the updated room, and closes the form on success.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show(
                        "Please correct the highlighted errors.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (!_HandlePersonImage())
                {
                    MessageBox.Show(
                        "Failed to handle room image. Please try again.",
                        "Image Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                _room.PricePerNight = decimal.Parse(txtPrice.Text.Trim());

                _room.Amenities = txtAmenities.Text.Trim();

                _room.Description = txtDescription.Text.Trim();


                _room.RoomStatus = (ClsRooms.EnRoomStatus)Enum.Parse(
                    typeof(ClsRooms.EnRoomStatus),
                    cmbStatus.Text
                );


                if (_room.Save())
                {
                    clsLogger.LogInformation($"Room {_room.RoomId} updated successfully.");

                    MessageBox.Show(
                        "Room updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    clsLogger.LogWarning($"Failed to update room {_room.RoomId}.");

                    MessageBox.Show(
                        "Failed to update room. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while saving room information.");

                MessageBox.Show(
                    "An unexpected error occurred while saving room information.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cancels editing and closes the form with a Cancel dialog result.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Draws the dark header background with an accent stripe and bottom divider line.
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(HeaderBg);

            using (SolidBrush b = new SolidBrush(AccentColor))
                g.FillRectangle(b, 0, 0, 4, p.Height);

            using (Pen pen = new Pen(Color.FromArgb(40, 255, 255, 255), 1f))
                g.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        // Draws the white footer background with a top divider line.
        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            e.Graphics.Clear(Color.White);
            using (Pen pen = new Pen(Color.FromArgb(229, 231, 235), 1f))
                e.Graphics.DrawLine(pen, 0, 0, p.Width, 0);
        }

        // Draws a rounded input panel background and border, with a focus glow effect when active.
        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            bool isFocus = p.Tag?.ToString() == "focus";
            bool isReadonly = p.Tag?.ToString() == "readonly";

            Color bg = isReadonly ? Color.FromArgb(245, 247, 250) : Color.White;
            Color border = isFocus ? InputFocusBorder : InputBorder;
            float thick = isFocus ? 2f : 1f;

            using (SolidBrush fill = new SolidBrush(bg))
                FillRoundRect(g, fill, 0, 0, p.Width - 1, p.Height - 1, 8);

            using (Pen pen = new Pen(border, thick))
                DrawRoundRect(g, pen, 0, 0, p.Width - 1, p.Height - 1, 8);

            if (isFocus)
            {
                using (Pen glow = new Pen(Color.FromArgb(55, 99, 102, 241), 3f))
                    DrawRoundRect(g, glow, 2, 2, p.Width - 5, p.Height - 5, 8);
            }
        }

        // Draws the rounded, light-gray background panel behind the image preview.
        private void pnlImagePreview_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush bg = new SolidBrush(Color.FromArgb(245, 247, 250)))
                FillRoundRect(g, bg, 0, 0, p.Width - 1, p.Height - 1, 10);

            using (Pen pen = new Pen(InputBorder, 1f))
                DrawRoundRect(g, pen, 0, 0, p.Width - 1, p.Height - 1, 10);
        }

        // Fills a rounded rectangle path with the given brush.
        private static void FillRoundRect(Graphics g, Brush br, int x, int y, int w, int h, int r)
        {
            using (GraphicsPath path = RoundPath(x, y, w, h, r))
                g.FillPath(br, path);
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
        private static void RoundControl(Control ctrl, int r)
        {
            ctrl.Region = new Region(RoundPath(0, 0, ctrl.Width - 1, ctrl.Height - 1, r));
        }

        // Validates that an image has been selected for the room.
        private void picPreview_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (picPreview.ImageLocation == null)
            {
                errorProvider1.SetError(btnBrowseImage, "Please select an image for the room.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(btnBrowseImage, null);
                e.Cancel = false;
            }
        }

        // Validates that a price has been entered for the room.
        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(txtPrice, "Please enter a price for the room.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
                e.Cancel = false;
            }
        }

        // Validates that amenities have been entered for the room.
        private void txtAmenities_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmenities.Text))
            {
                errorProvider1.SetError(txtAmenities, "Please enter amenities for the room.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAmenities, null);
                e.Cancel = false;
            }
        }

        // Validates that a description has been entered for the room.
        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Please enter a description for the room.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
                e.Cancel = false;
            }
        }

        // Restricts keyboard input in the price field to valid price characters.
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ClsValidation.IsValidPrice(e.KeyChar, txtPrice.Text);
        }
    }
}