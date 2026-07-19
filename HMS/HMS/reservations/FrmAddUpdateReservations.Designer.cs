namespace HMS.reservations
{
    partial class FrmAddUpdateReservations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormIcon = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.pnlReservationId = new System.Windows.Forms.Panel();
            this.lblReservationIdCaption = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.lblCustomerIcon = new System.Windows.Forms.Label();
            this.lblCustomerCaption = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblRoomIcon = new System.Windows.Forms.Label();
            this.lblRoomCaption = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblCheckInIcon = new System.Windows.Forms.Label();
            this.lblCheckInCaption = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutIcon = new System.Windows.Forms.Label();
            this.lblCheckOutCaption = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.lblNotesHeader = new System.Windows.Forms.Label();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFormHeader.SuspendLayout();
            this.pnlReservationId.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlFormHeader.Controls.Add(this.lblFormIcon);
            this.pnlFormHeader.Controls.Add(this.lblFormTitle);
            this.pnlFormHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(537, 90);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormIcon
            // 
            this.lblFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFormIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lblFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblFormIcon.Location = new System.Drawing.Point(16, 18);
            this.lblFormIcon.Name = "lblFormIcon";
            this.lblFormIcon.Size = new System.Drawing.Size(42, 42);
            this.lblFormIcon.TabIndex = 0;
            this.lblFormIcon.Text = "🗓";
            this.lblFormIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(70, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(207, 32);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "New Reservation";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(72, 50);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(359, 21);
            this.lblFormSubtitle.TabIndex = 2;
            this.lblFormSubtitle.Text = "Fill in the details below to create a new reservation";
            // 
            // pnlReservationId
            // 
            this.pnlReservationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlReservationId.Controls.Add(this.lblReservationIdCaption);
            this.pnlReservationId.Controls.Add(this.lblReservationID);
            this.pnlReservationId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReservationId.Location = new System.Drawing.Point(0, 90);
            this.pnlReservationId.Name = "pnlReservationId";
            this.pnlReservationId.Size = new System.Drawing.Size(537, 54);
            this.pnlReservationId.TabIndex = 1;
            // 
            // lblReservationIdCaption
            // 
            this.lblReservationIdCaption.AutoSize = true;
            this.lblReservationIdCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReservationIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblReservationIdCaption.Location = new System.Drawing.Point(20, 8);
            this.lblReservationIdCaption.Name = "lblReservationIdCaption";
            this.lblReservationIdCaption.Size = new System.Drawing.Size(128, 21);
            this.lblReservationIdCaption.TabIndex = 0;
            this.lblReservationIdCaption.Text = "RESERVATION ID";
            // 
            // lblReservationID
            // 
            this.lblReservationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblReservationID.Location = new System.Drawing.Point(20, 26);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(140, 22);
            this.lblReservationID.TabIndex = 1;
            this.lblReservationID.Text = "??";
            this.lblReservationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.lblDetailsHeader);
            this.pnlDetails.Controls.Add(this.lblCustomerIcon);
            this.pnlDetails.Controls.Add(this.lblCustomerCaption);
            this.pnlDetails.Controls.Add(this.cmbCustomer);
            this.pnlDetails.Controls.Add(this.lblRoomIcon);
            this.pnlDetails.Controls.Add(this.lblRoomCaption);
            this.pnlDetails.Controls.Add(this.cmbRoom);
            this.pnlDetails.Controls.Add(this.lblCheckInIcon);
            this.pnlDetails.Controls.Add(this.lblCheckInCaption);
            this.pnlDetails.Controls.Add(this.dtpCheckIn);
            this.pnlDetails.Controls.Add(this.lblCheckOutIcon);
            this.pnlDetails.Controls.Add(this.lblCheckOutCaption);
            this.pnlDetails.Controls.Add(this.dtpCheckOut);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.Location = new System.Drawing.Point(0, 144);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(537, 230);
            this.pnlDetails.TabIndex = 2;
            // 
            // lblDetailsHeader
            // 
            this.lblDetailsHeader.AutoSize = true;
            this.lblDetailsHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDetailsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDetailsHeader.Location = new System.Drawing.Point(20, 12);
            this.lblDetailsHeader.Name = "lblDetailsHeader";
            this.lblDetailsHeader.Size = new System.Drawing.Size(172, 20);
            this.lblDetailsHeader.TabIndex = 0;
            this.lblDetailsHeader.Text = "RESERVATION DETAILS";
            // 
            // lblCustomerIcon
            // 
            this.lblCustomerIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCustomerIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustomerIcon.Location = new System.Drawing.Point(20, 38);
            this.lblCustomerIcon.Name = "lblCustomerIcon";
            this.lblCustomerIcon.Size = new System.Drawing.Size(24, 20);
            this.lblCustomerIcon.TabIndex = 1;
            this.lblCustomerIcon.Text = "👤";
            // 
            // lblCustomerCaption
            // 
            this.lblCustomerCaption.AutoSize = true;
            this.lblCustomerCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustomerCaption.Location = new System.Drawing.Point(48, 38);
            this.lblCustomerCaption.Name = "lblCustomerCaption";
            this.lblCustomerCaption.Size = new System.Drawing.Size(106, 25);
            this.lblCustomerCaption.TabIndex = 2;
            this.lblCustomerCaption.Text = "Customer *";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(20, 60);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(497, 33);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCustomer_Validating);
            // 
            // lblRoomIcon
            // 
            this.lblRoomIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblRoomIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomIcon.Location = new System.Drawing.Point(20, 96);
            this.lblRoomIcon.Name = "lblRoomIcon";
            this.lblRoomIcon.Size = new System.Drawing.Size(24, 20);
            this.lblRoomIcon.TabIndex = 4;
            this.lblRoomIcon.Text = "🛏";
            // 
            // lblRoomCaption
            // 
            this.lblRoomCaption.AutoSize = true;
            this.lblRoomCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoomCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRoomCaption.Location = new System.Drawing.Point(48, 96);
            this.lblRoomCaption.Name = "lblRoomCaption";
            this.lblRoomCaption.Size = new System.Drawing.Size(75, 25);
            this.lblRoomCaption.TabIndex = 5;
            this.lblRoomCaption.Text = "Room *";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(20, 118);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(497, 33);
            this.cmbRoom.TabIndex = 6;
            this.cmbRoom.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCustomer_Validating);
            // 
            // lblCheckInIcon
            // 
            this.lblCheckInIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCheckInIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckInIcon.Location = new System.Drawing.Point(20, 154);
            this.lblCheckInIcon.Name = "lblCheckInIcon";
            this.lblCheckInIcon.Size = new System.Drawing.Size(24, 20);
            this.lblCheckInIcon.TabIndex = 7;
            this.lblCheckInIcon.Text = "📅";
            // 
            // lblCheckInCaption
            // 
            this.lblCheckInCaption.AutoSize = true;
            this.lblCheckInCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckInCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCheckInCaption.Location = new System.Drawing.Point(48, 154);
            this.lblCheckInCaption.Name = "lblCheckInCaption";
            this.lblCheckInCaption.Size = new System.Drawing.Size(144, 25);
            this.lblCheckInCaption.TabIndex = 8;
            this.lblCheckInCaption.Text = "Check-In Date *";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(20, 180);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(238, 33);
            this.dtpCheckIn.TabIndex = 9;
            // 
            // lblCheckOutIcon
            // 
            this.lblCheckOutIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCheckOutIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckOutIcon.Location = new System.Drawing.Point(279, 154);
            this.lblCheckOutIcon.Name = "lblCheckOutIcon";
            this.lblCheckOutIcon.Size = new System.Drawing.Size(24, 20);
            this.lblCheckOutIcon.TabIndex = 10;
            this.lblCheckOutIcon.Text = "📅";
            // 
            // lblCheckOutCaption
            // 
            this.lblCheckOutCaption.AutoSize = true;
            this.lblCheckOutCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCheckOutCaption.Location = new System.Drawing.Point(307, 154);
            this.lblCheckOutCaption.Name = "lblCheckOutCaption";
            this.lblCheckOutCaption.Size = new System.Drawing.Size(159, 25);
            this.lblCheckOutCaption.TabIndex = 11;
            this.lblCheckOutCaption.Text = "Check-Out Date *";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(279, 180);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(238, 33);
            this.dtpCheckOut.TabIndex = 12;
            // 
            // pnlNotes
            // 
            this.pnlNotes.BackColor = System.Drawing.Color.White;
            this.pnlNotes.Controls.Add(this.lblNotesHeader);
            this.pnlNotes.Controls.Add(this.txtSpecialRequests);
            this.pnlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotes.Location = new System.Drawing.Point(0, 374);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(537, 96);
            this.pnlNotes.TabIndex = 3;
            // 
            // lblNotesHeader
            // 
            this.lblNotesHeader.AutoSize = true;
            this.lblNotesHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNotesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNotesHeader.Location = new System.Drawing.Point(20, 12);
            this.lblNotesHeader.Name = "lblNotesHeader";
            this.lblNotesHeader.Size = new System.Drawing.Size(144, 20);
            this.lblNotesHeader.TabIndex = 0;
            this.lblNotesHeader.Text = "SPECIAL REQUESTS";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtSpecialRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialRequests.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSpecialRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSpecialRequests.Location = new System.Drawing.Point(20, 32);
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecialRequests.Size = new System.Drawing.Size(497, 56);
            this.txtSpecialRequests.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.btnSave.Location = new System.Drawing.Point(399, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "💾  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 470);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(537, 60);
            this.pnlFooter.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCancel.Location = new System.Drawing.Point(293, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAdd_UpdateReservations
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(537, 530);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlReservationId);
            this.Controls.Add(this.pnlFormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd_UpdateReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAdd_UpdateReservations";
            this.Load += new System.EventHandler(this.FrmAdd_UpdateReservations_Load);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlReservationId.ResumeLayout(false);
            this.pnlReservationId.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlNotes.ResumeLayout(false);
            this.pnlNotes.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormIcon;
        public System.Windows.Forms.Label lblFormTitle;
        public System.Windows.Forms.Label lblFormSubtitle;

        // Reservation ID strip
        private System.Windows.Forms.Panel pnlReservationId;
        private System.Windows.Forms.Label lblReservationIdCaption;
        public System.Windows.Forms.Label lblReservationID;

        // Reservation details panel
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.Label lblCustomerIcon;
        private System.Windows.Forms.Label lblCustomerCaption;
        public System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblRoomIcon;
        private System.Windows.Forms.Label lblRoomCaption;
        public System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblCheckInIcon;
        private System.Windows.Forms.Label lblCheckInCaption;
        public System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOutIcon;
        private System.Windows.Forms.Label lblCheckOutCaption;
        public System.Windows.Forms.DateTimePicker dtpCheckOut;

        // Notes / special requests
        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Label lblNotesHeader;
        public System.Windows.Forms.TextBox txtSpecialRequests;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btnCancel;
    }
}