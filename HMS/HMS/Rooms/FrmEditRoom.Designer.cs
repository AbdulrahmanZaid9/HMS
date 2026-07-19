using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class FrmEditRoom
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.pnlRoomID = new System.Windows.Forms.Panel();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.pnlRoomNumber = new System.Windows.Forms.Panel();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.pnlFloor = new System.Windows.Forms.Panel();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.pnlCapacity = new System.Windows.Forms.Panel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.pnlImagePreview = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.pnlAmenities = new System.Windows.Forms.Panel();
            this.txtAmenities = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlOuter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlRoomID.SuspendLayout();
            this.pnlRoomNumber.SuspendLayout();
            this.pnlFloor.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlCapacity.SuspendLayout();
            this.pnlImagePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlAmenities.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlOuter.Controls.Add(this.pnlBody);
            this.pnlOuter.Controls.Add(this.pnlFooter);
            this.pnlOuter.Controls.Add(this.pnlHeader);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(580, 590);
            this.pnlOuter.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlBody.Controls.Add(this.lblRoomID);
            this.pnlBody.Controls.Add(this.pnlRoomID);
            this.pnlBody.Controls.Add(this.lblRoomNumber);
            this.pnlBody.Controls.Add(this.pnlRoomNumber);
            this.pnlBody.Controls.Add(this.lblFloor);
            this.pnlBody.Controls.Add(this.pnlFloor);
            this.pnlBody.Controls.Add(this.lblStatus);
            this.pnlBody.Controls.Add(this.cmbStatus);
            this.pnlBody.Controls.Add(this.lblRoomType);
            this.pnlBody.Controls.Add(this.cmbRoomType);
            this.pnlBody.Controls.Add(this.lblPrice);
            this.pnlBody.Controls.Add(this.pnlPrice);
            this.pnlBody.Controls.Add(this.lblCapacity);
            this.pnlBody.Controls.Add(this.pnlCapacity);
            this.pnlBody.Controls.Add(this.lblImage);
            this.pnlBody.Controls.Add(this.pnlImagePreview);
            this.pnlBody.Controls.Add(this.lblImagePath);
            this.pnlBody.Controls.Add(this.lblAmenities);
            this.pnlBody.Controls.Add(this.pnlAmenities);
            this.pnlBody.Controls.Add(this.lblDescription);
            this.pnlBody.Controls.Add(this.pnlDescription);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 70);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 18, 24, 0);
            this.pnlBody.Size = new System.Drawing.Size(580, 452);
            this.pnlBody.TabIndex = 0;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomID.Location = new System.Drawing.Point(24, 18);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(80, 21);
            this.lblRoomID.TabIndex = 0;
            this.lblRoomID.Text = "ROOM ID";
            // 
            // pnlRoomID
            // 
            this.pnlRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlRoomID.Controls.Add(this.txtRoomID);
            this.pnlRoomID.Location = new System.Drawing.Point(24, 38);
            this.pnlRoomID.Name = "pnlRoomID";
            this.pnlRoomID.Size = new System.Drawing.Size(246, 40);
            this.pnlRoomID.TabIndex = 1;
            this.pnlRoomID.Tag = "readonly";
            this.pnlRoomID.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtRoomID
            // 
            this.txtRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtRoomID.Location = new System.Drawing.Point(12, 11);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(222, 26);
            this.txtRoomID.TabIndex = 0;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(286, 18);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(143, 21);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "ROOM NUMBER *";
            // 
            // pnlRoomNumber
            // 
            this.pnlRoomNumber.BackColor = System.Drawing.Color.White;
            this.pnlRoomNumber.Controls.Add(this.txtRoomNumber);
            this.pnlRoomNumber.Enabled = false;
            this.pnlRoomNumber.Location = new System.Drawing.Point(286, 38);
            this.pnlRoomNumber.Name = "pnlRoomNumber";
            this.pnlRoomNumber.Size = new System.Drawing.Size(246, 40);
            this.pnlRoomNumber.TabIndex = 3;
            this.pnlRoomNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.White;
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(12, 11);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(222, 26);
            this.txtRoomNumber.TabIndex = 0;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFloor.Location = new System.Drawing.Point(24, 96);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(60, 21);
            this.lblFloor.TabIndex = 4;
            this.lblFloor.Text = "FLOOR";
            // 
            // pnlFloor
            // 
            this.pnlFloor.BackColor = System.Drawing.Color.White;
            this.pnlFloor.Controls.Add(this.txtFloor);
            this.pnlFloor.Enabled = false;
            this.pnlFloor.Location = new System.Drawing.Point(24, 116);
            this.pnlFloor.Name = "pnlFloor";
            this.pnlFloor.Size = new System.Drawing.Size(246, 40);
            this.pnlFloor.TabIndex = 5;
            this.pnlFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtFloor
            // 
            this.txtFloor.BackColor = System.Drawing.Color.White;
            this.txtFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFloor.Location = new System.Drawing.Point(12, 11);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(222, 26);
            this.txtFloor.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatus.Location = new System.Drawing.Point(286, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "STATUS";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cmbStatus.Location = new System.Drawing.Point(286, 116);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(246, 33);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomType.Location = new System.Drawing.Point(24, 174);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(112, 21);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "ROOM TYPE *";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.White;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Enabled = false;
            this.cmbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cmbRoomType.Location = new System.Drawing.Point(24, 194);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(246, 33);
            this.cmbRoomType.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPrice.Location = new System.Drawing.Point(286, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(177, 21);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "PRICE PER NIGHT ($) *";
            // 
            // pnlPrice
            // 
            this.pnlPrice.BackColor = System.Drawing.Color.White;
            this.pnlPrice.Controls.Add(this.txtPrice);
            this.pnlPrice.Location = new System.Drawing.Point(286, 194);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(246, 40);
            this.pnlPrice.TabIndex = 11;
            this.pnlPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPrice.Location = new System.Drawing.Point(12, 11);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 26);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCapacity.Location = new System.Drawing.Point(24, 252);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(160, 21);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "CAPACITY (GUESTS)";
            // 
            // pnlCapacity
            // 
            this.pnlCapacity.BackColor = System.Drawing.Color.White;
            this.pnlCapacity.Controls.Add(this.txtCapacity);
            this.pnlCapacity.Enabled = false;
            this.pnlCapacity.Location = new System.Drawing.Point(24, 272);
            this.pnlCapacity.Name = "pnlCapacity";
            this.pnlCapacity.Size = new System.Drawing.Size(246, 40);
            this.pnlCapacity.TabIndex = 13;
            this.pnlCapacity.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.White;
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtCapacity.Location = new System.Drawing.Point(12, 11);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(222, 26);
            this.txtCapacity.TabIndex = 0;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblImage.Location = new System.Drawing.Point(286, 252);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(114, 21);
            this.lblImage.TabIndex = 14;
            this.lblImage.Text = "ROOM IMAGE";
            // 
            // pnlImagePreview
            // 
            this.pnlImagePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlImagePreview.Controls.Add(this.picPreview);
            this.pnlImagePreview.Controls.Add(this.btnBrowseImage);
            this.pnlImagePreview.Location = new System.Drawing.Point(286, 272);
            this.pnlImagePreview.Name = "pnlImagePreview";
            this.pnlImagePreview.Size = new System.Drawing.Size(246, 122);
            this.pnlImagePreview.TabIndex = 15;
            this.pnlImagePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImagePreview_Paint);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Transparent;
            this.picPreview.Location = new System.Drawing.Point(6, 6);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(234, 80);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.Validating += new System.ComponentModel.CancelEventHandler(this.picPreview_Validating);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Location = new System.Drawing.Point(6, 90);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(234, 28);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "📁  Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoEllipsis = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblImagePath.Location = new System.Drawing.Point(286, 398);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(246, 16);
            this.lblImagePath.TabIndex = 16;
            this.lblImagePath.Text = "No image selected";
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAmenities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAmenities.Location = new System.Drawing.Point(24, 334);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(95, 21);
            this.lblAmenities.TabIndex = 17;
            this.lblAmenities.Text = "AMENITIES";
            // 
            // pnlAmenities
            // 
            this.pnlAmenities.BackColor = System.Drawing.Color.White;
            this.pnlAmenities.Controls.Add(this.txtAmenities);
            this.pnlAmenities.Location = new System.Drawing.Point(24, 354);
            this.pnlAmenities.Name = "pnlAmenities";
            this.pnlAmenities.Size = new System.Drawing.Size(508, 40);
            this.pnlAmenities.TabIndex = 18;
            this.pnlAmenities.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtAmenities
            // 
            this.txtAmenities.BackColor = System.Drawing.Color.White;
            this.txtAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmenities.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAmenities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtAmenities.Location = new System.Drawing.Point(12, 11);
            this.txtAmenities.Name = "txtAmenities";
            this.txtAmenities.Size = new System.Drawing.Size(484, 26);
            this.txtAmenities.TabIndex = 0;
            this.txtAmenities.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmenities_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDescription.Location = new System.Drawing.Point(24, 412);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 21);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "DESCRIPTION";
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.White;
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Location = new System.Drawing.Point(24, 432);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(508, 88);
            this.pnlDescription.TabIndex = 20;
            this.pnlDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtDescription.Location = new System.Drawing.Point(12, 10);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(484, 68);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 522);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(580, 68);
            this.pnlFooter.TabIndex = 1;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCancel.Location = new System.Drawing.Point(268, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(396, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "💾  Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(580, 70);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // picIcon
            // 
            this.picIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.picIcon.ForeColor = System.Drawing.Color.White;
            this.picIcon.Location = new System.Drawing.Point(20, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(38, 38);
            this.picIcon.TabIndex = 0;
            this.picIcon.Text = "🏢";
            this.picIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(66, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Edit Room";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitle.Location = new System.Drawing.Point(68, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(237, 21);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Grand Palace Hotel Management";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditRoom
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 590);
            this.Controls.Add(this.pnlOuter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Room — Grand Palace";
            this.Load += new System.EventHandler(this.FrmEditRoom_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlRoomID.ResumeLayout(false);
            this.pnlRoomID.PerformLayout();
            this.pnlRoomNumber.ResumeLayout(false);
            this.pnlRoomNumber.PerformLayout();
            this.pnlFloor.ResumeLayout(false);
            this.pnlFloor.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.pnlCapacity.ResumeLayout(false);
            this.pnlCapacity.PerformLayout();
            this.pnlImagePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlAmenities.ResumeLayout(false);
            this.pnlAmenities.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Panel pnlRoomID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Panel pnlRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Panel pnlFloor;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Panel pnlCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Panel pnlImagePreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Panel pnlAmenities;
        private System.Windows.Forms.TextBox txtAmenities;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private ErrorProvider errorProvider1;
    }
}