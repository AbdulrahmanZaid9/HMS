namespace HMS.reservations.Controls
{
    partial class CtrlCurrentReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReservationIdBadge = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomerHeader = new System.Windows.Forms.Label();
            this.lblCustNameIcon = new System.Windows.Forms.Label();
            this.lblCustNameCaption = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustIdIcon = new System.Windows.Forms.Label();
            this.lblCustIdCaption = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.lblRoomHeader = new System.Windows.Forms.Label();
            this.lblRoomNumIcon = new System.Windows.Forms.Label();
            this.lblRoomNumCaption = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomIdIcon = new System.Windows.Forms.Label();
            this.lblRoomIdCaption = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.lblDatesHeader = new System.Windows.Forms.Label();
            this.lblCheckInIcon = new System.Windows.Forms.Label();
            this.lblCheckInCaption = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOutIcon = new System.Windows.Forms.Label();
            this.lblCheckOutCaption = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblActualCheckoutIcon = new System.Windows.Forms.Label();
            this.lblActualCheckoutCaption = new System.Windows.Forms.Label();
            this.lblActualCheckout = new System.Windows.Forms.Label();
            this.pnlBilling = new System.Windows.Forms.Panel();
            this.lblBillingHeader = new System.Windows.Forms.Label();
            this.lblNightsIcon = new System.Windows.Forms.Label();
            this.lblNightsCaption = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblTotalPriceIcon = new System.Windows.Forms.Label();
            this.lblTotalPriceCaption = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.lblNotesHeader = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActualCheckin = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlRoom.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.pnlBilling.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblReservationIdBadge);
            this.pnlHeader.Controls.Add(this.lblStatusBadge);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.picIcon.ForeColor = System.Drawing.Color.White;
            this.picIcon.Location = new System.Drawing.Point(24, 18);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(49, 51);
            this.picIcon.TabIndex = 0;
            this.picIcon.Text = "🗓";
            this.picIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(82, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Current Reservation";
            // 
            // lblReservationIdBadge
            // 
            this.lblReservationIdBadge.AutoSize = true;
            this.lblReservationIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblReservationIdBadge.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblReservationIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblReservationIdBadge.Location = new System.Drawing.Point(84, 50);
            this.lblReservationIdBadge.Name = "lblReservationIdBadge";
            this.lblReservationIdBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblReservationIdBadge.Size = new System.Drawing.Size(148, 24);
            this.lblReservationIdBadge.TabIndex = 2;
            this.lblReservationIdBadge.Text = "RESERVATION #??";
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusBadge.AutoSize = true;
            this.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(247)))), ((int)(((byte)(208)))));
            this.lblStatusBadge.Location = new System.Drawing.Point(557, 30);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblStatusBadge.Size = new System.Drawing.Size(111, 29);
            this.lblStatusBadge.TabIndex = 3;
            this.lblStatusBadge.Text = "Confirmed";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.Controls.Add(this.lblCustomerHeader);
            this.pnlCustomer.Controls.Add(this.lblCustNameIcon);
            this.pnlCustomer.Controls.Add(this.lblCustNameCaption);
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Controls.Add(this.lblCustIdIcon);
            this.pnlCustomer.Controls.Add(this.lblCustIdCaption);
            this.pnlCustomer.Controls.Add(this.lblCustomerId);
            this.pnlCustomer.Location = new System.Drawing.Point(0, 90);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(350, 140);
            this.pnlCustomer.TabIndex = 1;
            // 
            // lblCustomerHeader
            // 
            this.lblCustomerHeader.AutoSize = true;
            this.lblCustomerHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCustomerHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCustomerHeader.Location = new System.Drawing.Point(20, 12);
            this.lblCustomerHeader.Name = "lblCustomerHeader";
            this.lblCustomerHeader.Size = new System.Drawing.Size(88, 20);
            this.lblCustomerHeader.TabIndex = 0;
            this.lblCustomerHeader.Text = "CUSTOMER";
            // 
            // lblCustNameIcon
            // 
            this.lblCustNameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCustNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustNameIcon.Location = new System.Drawing.Point(20, 40);
            this.lblCustNameIcon.Name = "lblCustNameIcon";
            this.lblCustNameIcon.Size = new System.Drawing.Size(28, 30);
            this.lblCustNameIcon.TabIndex = 1;
            this.lblCustNameIcon.Text = "👤";
            this.lblCustNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustNameCaption
            // 
            this.lblCustNameCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustNameCaption.Location = new System.Drawing.Point(52, 41);
            this.lblCustNameCaption.Name = "lblCustNameCaption";
            this.lblCustNameCaption.Size = new System.Drawing.Size(96, 20);
            this.lblCustNameCaption.TabIndex = 2;
            this.lblCustNameCaption.Text = "Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoEllipsis = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustomerName.Location = new System.Drawing.Point(160, 41);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(174, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "—";
            // 
            // lblCustIdIcon
            // 
            this.lblCustIdIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCustIdIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustIdIcon.Location = new System.Drawing.Point(20, 72);
            this.lblCustIdIcon.Name = "lblCustIdIcon";
            this.lblCustIdIcon.Size = new System.Drawing.Size(28, 30);
            this.lblCustIdIcon.TabIndex = 4;
            this.lblCustIdIcon.Text = "🆔";
            this.lblCustIdIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustIdCaption
            // 
            this.lblCustIdCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCustIdCaption.Location = new System.Drawing.Point(52, 73);
            this.lblCustIdCaption.Name = "lblCustIdCaption";
            this.lblCustIdCaption.Size = new System.Drawing.Size(96, 20);
            this.lblCustIdCaption.TabIndex = 5;
            this.lblCustIdCaption.Text = "Customer ID";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoEllipsis = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustomerId.Location = new System.Drawing.Point(160, 73);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(174, 20);
            this.lblCustomerId.TabIndex = 6;
            this.lblCustomerId.Text = "—";
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackColor = System.Drawing.Color.White;
            this.pnlRoom.Controls.Add(this.lblRoomHeader);
            this.pnlRoom.Controls.Add(this.lblRoomNumIcon);
            this.pnlRoom.Controls.Add(this.lblRoomNumCaption);
            this.pnlRoom.Controls.Add(this.lblRoomNumber);
            this.pnlRoom.Controls.Add(this.lblRoomIdIcon);
            this.pnlRoom.Controls.Add(this.lblRoomIdCaption);
            this.pnlRoom.Controls.Add(this.lblRoomId);
            this.pnlRoom.Location = new System.Drawing.Point(350, 90);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(350, 140);
            this.pnlRoom.TabIndex = 2;
            // 
            // lblRoomHeader
            // 
            this.lblRoomHeader.AutoSize = true;
            this.lblRoomHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblRoomHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblRoomHeader.Location = new System.Drawing.Point(20, 12);
            this.lblRoomHeader.Name = "lblRoomHeader";
            this.lblRoomHeader.Size = new System.Drawing.Size(55, 20);
            this.lblRoomHeader.TabIndex = 0;
            this.lblRoomHeader.Text = "ROOM";
            // 
            // lblRoomNumIcon
            // 
            this.lblRoomNumIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblRoomNumIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomNumIcon.Location = new System.Drawing.Point(20, 40);
            this.lblRoomNumIcon.Name = "lblRoomNumIcon";
            this.lblRoomNumIcon.Size = new System.Drawing.Size(28, 30);
            this.lblRoomNumIcon.TabIndex = 1;
            this.lblRoomNumIcon.Text = "🚪";
            this.lblRoomNumIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNumCaption
            // 
            this.lblRoomNumCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomNumCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomNumCaption.Location = new System.Drawing.Point(52, 41);
            this.lblRoomNumCaption.Name = "lblRoomNumCaption";
            this.lblRoomNumCaption.Size = new System.Drawing.Size(96, 20);
            this.lblRoomNumCaption.TabIndex = 2;
            this.lblRoomNumCaption.Text = "Room Number";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoEllipsis = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(160, 41);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(174, 20);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "—";
            // 
            // lblRoomIdIcon
            // 
            this.lblRoomIdIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblRoomIdIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomIdIcon.Location = new System.Drawing.Point(20, 72);
            this.lblRoomIdIcon.Name = "lblRoomIdIcon";
            this.lblRoomIdIcon.Size = new System.Drawing.Size(28, 30);
            this.lblRoomIdIcon.TabIndex = 4;
            this.lblRoomIdIcon.Text = "🔑";
            this.lblRoomIdIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomIdCaption
            // 
            this.lblRoomIdCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRoomIdCaption.Location = new System.Drawing.Point(52, 73);
            this.lblRoomIdCaption.Name = "lblRoomIdCaption";
            this.lblRoomIdCaption.Size = new System.Drawing.Size(96, 20);
            this.lblRoomIdCaption.TabIndex = 5;
            this.lblRoomIdCaption.Text = "Room ID";
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoEllipsis = true;
            this.lblRoomId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRoomId.Location = new System.Drawing.Point(160, 73);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(174, 20);
            this.lblRoomId.TabIndex = 6;
            this.lblRoomId.Text = "—";
            // 
            // pnlDates
            // 
            this.pnlDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlDates.Controls.Add(this.label1);
            this.pnlDates.Controls.Add(this.label2);
            this.pnlDates.Controls.Add(this.lblActualCheckin);
            this.pnlDates.Controls.Add(this.lblDatesHeader);
            this.pnlDates.Controls.Add(this.lblCheckInIcon);
            this.pnlDates.Controls.Add(this.lblCheckInCaption);
            this.pnlDates.Controls.Add(this.lblCheckIn);
            this.pnlDates.Controls.Add(this.lblCheckOutIcon);
            this.pnlDates.Controls.Add(this.lblCheckOutCaption);
            this.pnlDates.Controls.Add(this.lblCheckOut);
            this.pnlDates.Controls.Add(this.lblActualCheckoutIcon);
            this.pnlDates.Controls.Add(this.lblActualCheckoutCaption);
            this.pnlDates.Controls.Add(this.lblActualCheckout);
            this.pnlDates.Location = new System.Drawing.Point(0, 230);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(700, 192);
            this.pnlDates.TabIndex = 3;
            // 
            // lblDatesHeader
            // 
            this.lblDatesHeader.AutoSize = true;
            this.lblDatesHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDatesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDatesHeader.Location = new System.Drawing.Point(20, 12);
            this.lblDatesHeader.Name = "lblDatesHeader";
            this.lblDatesHeader.Size = new System.Drawing.Size(94, 20);
            this.lblDatesHeader.TabIndex = 0;
            this.lblDatesHeader.Text = "STAY DATES";
            // 
            // lblCheckInIcon
            // 
            this.lblCheckInIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCheckInIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckInIcon.Location = new System.Drawing.Point(20, 44);
            this.lblCheckInIcon.Name = "lblCheckInIcon";
            this.lblCheckInIcon.Size = new System.Drawing.Size(28, 30);
            this.lblCheckInIcon.TabIndex = 1;
            this.lblCheckInIcon.Text = "📅";
            this.lblCheckInIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheckInCaption
            // 
            this.lblCheckInCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckInCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckInCaption.Location = new System.Drawing.Point(52, 45);
            this.lblCheckInCaption.Name = "lblCheckInCaption";
            this.lblCheckInCaption.Size = new System.Drawing.Size(140, 20);
            this.lblCheckInCaption.TabIndex = 2;
            this.lblCheckInCaption.Text = "Check-in";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoEllipsis = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCheckIn.Location = new System.Drawing.Point(20, 78);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(200, 24);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "—";
            // 
            // lblCheckOutIcon
            // 
            this.lblCheckOutIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblCheckOutIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckOutIcon.Location = new System.Drawing.Point(260, 44);
            this.lblCheckOutIcon.Name = "lblCheckOutIcon";
            this.lblCheckOutIcon.Size = new System.Drawing.Size(28, 30);
            this.lblCheckOutIcon.TabIndex = 4;
            this.lblCheckOutIcon.Text = "📅";
            this.lblCheckOutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheckOutCaption
            // 
            this.lblCheckOutCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckOutCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCheckOutCaption.Location = new System.Drawing.Point(292, 45);
            this.lblCheckOutCaption.Name = "lblCheckOutCaption";
            this.lblCheckOutCaption.Size = new System.Drawing.Size(140, 20);
            this.lblCheckOutCaption.TabIndex = 5;
            this.lblCheckOutCaption.Text = "Check-out";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoEllipsis = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCheckOut.Location = new System.Drawing.Point(260, 78);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(200, 24);
            this.lblCheckOut.TabIndex = 6;
            this.lblCheckOut.Text = "—";
            // 
            // lblActualCheckoutIcon
            // 
            this.lblActualCheckoutIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblActualCheckoutIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblActualCheckoutIcon.Location = new System.Drawing.Point(500, 44);
            this.lblActualCheckoutIcon.Name = "lblActualCheckoutIcon";
            this.lblActualCheckoutIcon.Size = new System.Drawing.Size(28, 30);
            this.lblActualCheckoutIcon.TabIndex = 7;
            this.lblActualCheckoutIcon.Text = "🚪";
            this.lblActualCheckoutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActualCheckoutCaption
            // 
            this.lblActualCheckoutCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActualCheckoutCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblActualCheckoutCaption.Location = new System.Drawing.Point(525, 47);
            this.lblActualCheckoutCaption.Name = "lblActualCheckoutCaption";
            this.lblActualCheckoutCaption.Size = new System.Drawing.Size(148, 20);
            this.lblActualCheckoutCaption.TabIndex = 8;
            this.lblActualCheckoutCaption.Text = "Actual Checkout";
            // 
            // lblActualCheckout
            // 
            this.lblActualCheckout.AutoEllipsis = true;
            this.lblActualCheckout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActualCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblActualCheckout.Location = new System.Drawing.Point(500, 78);
            this.lblActualCheckout.Name = "lblActualCheckout";
            this.lblActualCheckout.Size = new System.Drawing.Size(180, 24);
            this.lblActualCheckout.TabIndex = 9;
            this.lblActualCheckout.Text = "—";
            // 
            // pnlBilling
            // 
            this.pnlBilling.BackColor = System.Drawing.Color.White;
            this.pnlBilling.Controls.Add(this.lblBillingHeader);
            this.pnlBilling.Controls.Add(this.lblNightsIcon);
            this.pnlBilling.Controls.Add(this.lblNightsCaption);
            this.pnlBilling.Controls.Add(this.lblNights);
            this.pnlBilling.Controls.Add(this.lblTotalPriceIcon);
            this.pnlBilling.Controls.Add(this.lblTotalPriceCaption);
            this.pnlBilling.Controls.Add(this.lblTotalPrice);
            this.pnlBilling.Location = new System.Drawing.Point(3, 428);
            this.pnlBilling.Name = "pnlBilling";
            this.pnlBilling.Size = new System.Drawing.Size(700, 80);
            this.pnlBilling.TabIndex = 4;
            // 
            // lblBillingHeader
            // 
            this.lblBillingHeader.AutoSize = true;
            this.lblBillingHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBillingHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBillingHeader.Location = new System.Drawing.Point(20, 10);
            this.lblBillingHeader.Name = "lblBillingHeader";
            this.lblBillingHeader.Size = new System.Drawing.Size(68, 20);
            this.lblBillingHeader.TabIndex = 0;
            this.lblBillingHeader.Text = "BILLING";
            // 
            // lblNightsIcon
            // 
            this.lblNightsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblNightsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNightsIcon.Location = new System.Drawing.Point(20, 38);
            this.lblNightsIcon.Name = "lblNightsIcon";
            this.lblNightsIcon.Size = new System.Drawing.Size(28, 30);
            this.lblNightsIcon.TabIndex = 1;
            this.lblNightsIcon.Text = "🌙";
            this.lblNightsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNightsCaption
            // 
            this.lblNightsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNightsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNightsCaption.Location = new System.Drawing.Point(52, 39);
            this.lblNightsCaption.Name = "lblNightsCaption";
            this.lblNightsCaption.Size = new System.Drawing.Size(72, 29);
            this.lblNightsCaption.TabIndex = 2;
            this.lblNightsCaption.Text = "Nights";
            // 
            // lblNights
            // 
            this.lblNights.AutoEllipsis = true;
            this.lblNights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNights.Location = new System.Drawing.Point(130, 38);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(140, 24);
            this.lblNights.TabIndex = 3;
            this.lblNights.Text = "—";
            // 
            // lblTotalPriceIcon
            // 
            this.lblTotalPriceIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblTotalPriceIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalPriceIcon.Location = new System.Drawing.Point(400, 38);
            this.lblTotalPriceIcon.Name = "lblTotalPriceIcon";
            this.lblTotalPriceIcon.Size = new System.Drawing.Size(28, 30);
            this.lblTotalPriceIcon.TabIndex = 4;
            this.lblTotalPriceIcon.Text = "💰";
            this.lblTotalPriceIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceCaption
            // 
            this.lblTotalPriceCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalPriceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalPriceCaption.Location = new System.Drawing.Point(432, 39);
            this.lblTotalPriceCaption.Name = "lblTotalPriceCaption";
            this.lblTotalPriceCaption.Size = new System.Drawing.Size(100, 20);
            this.lblTotalPriceCaption.TabIndex = 5;
            this.lblTotalPriceCaption.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoEllipsis = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(540, 35);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(140, 27);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "—";
            // 
            // pnlNotes
            // 
            this.pnlNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlNotes.Controls.Add(this.lblNotesHeader);
            this.pnlNotes.Controls.Add(this.lblNotes);
            this.pnlNotes.Location = new System.Drawing.Point(3, 501);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(700, 100);
            this.pnlNotes.TabIndex = 5;
            // 
            // lblNotesHeader
            // 
            this.lblNotesHeader.AutoSize = true;
            this.lblNotesHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNotesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNotesHeader.Location = new System.Drawing.Point(20, 10);
            this.lblNotesHeader.Name = "lblNotesHeader";
            this.lblNotesHeader.Size = new System.Drawing.Size(56, 20);
            this.lblNotesHeader.TabIndex = 0;
            this.lblNotesHeader.Text = "NOTES";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.White;
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNotes.Location = new System.Drawing.Point(20, 32);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(660, 58);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "—";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnEditInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 608);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(700, 80);
            this.pnlFooter.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(309, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInfo.FlatAppearance.BorderSize = 0;
            this.btnEditInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnEditInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.Location = new System.Drawing.Point(500, 18);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(180, 44);
            this.btnEditInfo.TabIndex = 0;
            this.btnEditInfo.Text = "✎  Edit Info";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "🚪";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Actual Checkin";
            // 
            // lblActualCheckin
            // 
            this.lblActualCheckin.AutoEllipsis = true;
            this.lblActualCheckin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActualCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblActualCheckin.Location = new System.Drawing.Point(22, 161);
            this.lblActualCheckin.Name = "lblActualCheckin";
            this.lblActualCheckin.Size = new System.Drawing.Size(180, 24);
            this.lblActualCheckin.TabIndex = 12;
            this.lblActualCheckin.Text = "—";
            // 
            // CtrlCurrentReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.pnlBilling);
            this.Controls.Add(this.pnlDates);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CtrlCurrentReservation";
            this.Size = new System.Drawing.Size(700, 688);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlRoom.ResumeLayout(false);
            this.pnlRoom.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.pnlBilling.ResumeLayout(false);
            this.pnlBilling.PerformLayout();
            this.pnlNotes.ResumeLayout(false);
            this.pnlNotes.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label picIcon;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblReservationIdBadge;
        public System.Windows.Forms.Label lblStatusBadge;

        // Customer panel
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomerHeader;
        private System.Windows.Forms.Label lblCustNameIcon;
        private System.Windows.Forms.Label lblCustNameCaption;
        public System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustIdIcon;
        private System.Windows.Forms.Label lblCustIdCaption;
        public System.Windows.Forms.Label lblCustomerId;

        // Room panel
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Label lblRoomHeader;
        private System.Windows.Forms.Label lblRoomNumIcon;
        private System.Windows.Forms.Label lblRoomNumCaption;
        public System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomIdIcon;
        private System.Windows.Forms.Label lblRoomIdCaption;
        public System.Windows.Forms.Label lblRoomId;

        // Dates panel
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.Label lblDatesHeader;
        private System.Windows.Forms.Label lblCheckInIcon;
        private System.Windows.Forms.Label lblCheckInCaption;
        public System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOutIcon;
        private System.Windows.Forms.Label lblCheckOutCaption;
        public System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblActualCheckoutIcon;
        private System.Windows.Forms.Label lblActualCheckoutCaption;
        public System.Windows.Forms.Label lblActualCheckout;

        // Billing panel (NEW: number of nights + total price)
        private System.Windows.Forms.Panel pnlBilling;
        private System.Windows.Forms.Label lblBillingHeader;
        private System.Windows.Forms.Label lblNightsIcon;
        private System.Windows.Forms.Label lblNightsCaption;
        public System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblTotalPriceIcon;
        private System.Windows.Forms.Label lblTotalPriceCaption;
        public System.Windows.Forms.Label lblTotalPrice;

        // Notes
        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Label lblNotesHeader;
        public System.Windows.Forms.Label lblNotes;

        // Footer
        private System.Windows.Forms.Panel pnlFooter;
        public System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblActualCheckin;
    }
}