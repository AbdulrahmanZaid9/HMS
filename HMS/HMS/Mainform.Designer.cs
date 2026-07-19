using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class Mainform
    {
        private System.ComponentModel.IContainer components = null;
        private bool isDarkMode = false;
        private Panel pnlActiveIndicator;
        private Button currentActiveButton;
        private Button btnDarkMode;

        private Color sideBarColor = Color.FromArgb(15, 23, 42);
        private Color sideBarHeaderColor = Color.FromArgb(15, 23, 42);
        private Color textColor = Color.FromArgb(15, 23, 42);
        private Color subTextColor = Color.FromArgb(100, 116, 139);
        private Color contentBackColor = Color.White;
        private Color topBarColor = Color.White;
        private Color footerColor = Color.FromArgb(248, 250, 252);
        private Color userBtnColor = Color.FromArgb(239, 246, 255);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void SetLightModeColors()
        {
            sideBarColor = Color.FromArgb(15, 23, 42);
            sideBarHeaderColor = Color.FromArgb(15, 23, 42);
            textColor = Color.FromArgb(15, 23, 42);
            subTextColor = Color.FromArgb(100, 116, 139);
            contentBackColor = Color.White;
            topBarColor = Color.White;
            footerColor = Color.FromArgb(248, 250, 252);
            userBtnColor = Color.FromArgb(239, 246, 255);
        }

        private void SetDarkModeColors()
        {
            sideBarColor = Color.FromArgb(17, 24, 39);
            sideBarHeaderColor = Color.FromArgb(17, 24, 39);
            textColor = Color.FromArgb(241, 245, 249);
            subTextColor = Color.FromArgb(148, 163, 184);
            contentBackColor = Color.FromArgb(30, 41, 59);
            topBarColor = Color.FromArgb(30, 41, 59);
            footerColor = Color.FromArgb(51, 65, 85);
            userBtnColor = Color.FromArgb(51, 65, 85);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarHotelIcon = new System.Windows.Forms.Label();
            this.lblSidebarVersion = new System.Windows.Forms.Label();
            this.btnExits = new System.Windows.Forms.Button();
            this.btnNavsReports = new System.Windows.Forms.Button();
            this.btnNavvUsers = new System.Windows.Forms.Button();
            this.btnNavServices = new System.Windows.Forms.Button();
            this.btnNavCheckIn = new System.Windows.Forms.Button();
            this.btnNavReservations = new System.Windows.Forms.Button();
            this.btnNavCustomers = new System.Windows.Forms.Button();
            this.btnNavRooms = new System.Windows.Forms.Button();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblAppSub = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.pnlActiveIndicator = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeIcon = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterVersion = new System.Windows.Forms.Label();
            this.lblFooterCopyright = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.pnlUserBtn = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserAvatar = new System.Windows.Forms.Label();
            this.lblTopSub = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlWorkArea.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlUserBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarHotelIcon);
            this.pnlSidebar.Controls.Add(this.lblSidebarVersion);
            this.pnlSidebar.Controls.Add(this.btnExits);
            this.pnlSidebar.Controls.Add(this.btnNavsReports);
            this.pnlSidebar.Controls.Add(this.btnNavvUsers);
            this.pnlSidebar.Controls.Add(this.btnNavServices);
            this.pnlSidebar.Controls.Add(this.btnNavCheckIn);
            this.pnlSidebar.Controls.Add(this.btnNavReservations);
            this.pnlSidebar.Controls.Add(this.btnNavCustomers);
            this.pnlSidebar.Controls.Add(this.btnNavRooms);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Controls.Add(this.pnlActiveIndicator);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 700);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarHotelIcon
            // 
            this.lblSidebarHotelIcon.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarHotelIcon.Name = "lblSidebarHotelIcon";
            this.lblSidebarHotelIcon.Size = new System.Drawing.Size(100, 23);
            this.lblSidebarHotelIcon.TabIndex = 0;
            // 
            // lblSidebarVersion
            // 
            this.lblSidebarVersion.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarVersion.Name = "lblSidebarVersion";
            this.lblSidebarVersion.Size = new System.Drawing.Size(100, 23);
            this.lblSidebarVersion.TabIndex = 1;
            // 
            // btnExits
            // 
            this.btnExits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExits.FlatAppearance.BorderSize = 0;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnExits.Location = new System.Drawing.Point(0, 370);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(240, 40);
            this.btnExits.TabIndex = 5;
            this.btnExits.Text = "   🚪    Exit";
            this.btnExits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExits.Click += new System.EventHandler(this.Exit_Click);
            this.btnExits.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnExits.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavsReports
            // 
            this.btnNavsReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavsReports.FlatAppearance.BorderSize = 0;
            this.btnNavsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavsReports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavsReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavsReports.Location = new System.Drawing.Point(0, 330);
            this.btnNavsReports.Name = "btnNavsReports";
            this.btnNavsReports.Size = new System.Drawing.Size(240, 40);
            this.btnNavsReports.TabIndex = 6;
            this.btnNavsReports.Text = "   📈    Reports";
            this.btnNavsReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavsReports.Click += new System.EventHandler(this.Reports_Click);
            this.btnNavsReports.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavsReports.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavvUsers
            // 
            this.btnNavvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavvUsers.FlatAppearance.BorderSize = 0;
            this.btnNavvUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavvUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavvUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavvUsers.Location = new System.Drawing.Point(0, 290);
            this.btnNavvUsers.Name = "btnNavvUsers";
            this.btnNavvUsers.Size = new System.Drawing.Size(240, 40);
            this.btnNavvUsers.TabIndex = 7;
            this.btnNavvUsers.Text = "   👥    Users";
            this.btnNavvUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavvUsers.Click += new System.EventHandler(this.Users_Click);
            this.btnNavvUsers.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavvUsers.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavServices
            // 
            this.btnNavServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavServices.FlatAppearance.BorderSize = 0;
            this.btnNavServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavServices.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavServices.Location = new System.Drawing.Point(0, 250);
            this.btnNavServices.Name = "btnNavServices";
            this.btnNavServices.Size = new System.Drawing.Size(240, 40);
            this.btnNavServices.TabIndex = 8;
            this.btnNavServices.Text = "   🛎️    Services";
            this.btnNavServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavServices.Click += new System.EventHandler(this.Services_Booking);
            this.btnNavServices.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavServices.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavCheckIn
            // 
            this.btnNavCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCheckIn.FlatAppearance.BorderSize = 0;
            this.btnNavCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavCheckIn.Location = new System.Drawing.Point(0, 210);
            this.btnNavCheckIn.Name = "btnNavCheckIn";
            this.btnNavCheckIn.Size = new System.Drawing.Size(240, 40);
            this.btnNavCheckIn.TabIndex = 9;
            this.btnNavCheckIn.Text = "   📋    Service Bookings";
            this.btnNavCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCheckIn.Click += new System.EventHandler(this.ServiceBooking_Click);
            this.btnNavCheckIn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavCheckIn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavReservations
            // 
            this.btnNavReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReservations.FlatAppearance.BorderSize = 0;
            this.btnNavReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReservations.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavReservations.Location = new System.Drawing.Point(0, 170);
            this.btnNavReservations.Name = "btnNavReservations";
            this.btnNavReservations.Size = new System.Drawing.Size(240, 40);
            this.btnNavReservations.TabIndex = 10;
            this.btnNavReservations.Text = "   📅    Reservations";
            this.btnNavReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReservations.Click += new System.EventHandler(this.Reservation_Click);
            this.btnNavReservations.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavReservations.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavCustomers
            // 
            this.btnNavCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCustomers.FlatAppearance.BorderSize = 0;
            this.btnNavCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCustomers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavCustomers.Location = new System.Drawing.Point(0, 130);
            this.btnNavCustomers.Name = "btnNavCustomers";
            this.btnNavCustomers.Size = new System.Drawing.Size(240, 40);
            this.btnNavCustomers.TabIndex = 11;
            this.btnNavCustomers.Text = "   👤    Customers";
            this.btnNavCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.Click += new System.EventHandler(this.Customers_click);
            this.btnNavCustomers.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavCustomers.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavRooms
            // 
            this.btnNavRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRooms.FlatAppearance.BorderSize = 0;
            this.btnNavRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnNavRooms.Location = new System.Drawing.Point(0, 90);
            this.btnNavRooms.Name = "btnNavRooms";
            this.btnNavRooms.Size = new System.Drawing.Size(240, 40);
            this.btnNavRooms.TabIndex = 12;
            this.btnNavRooms.Text = "   🛏️    Rooms";
            this.btnNavRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRooms.Click += new System.EventHandler(this.btnNavRooms_Click);
            this.btnNavRooms.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavRooms.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebarHeader.Controls.Add(this.pnlSeparator);
            this.pnlSidebarHeader.Controls.Add(this.lblAppSub);
            this.pnlSidebarHeader.Controls.Add(this.lblAppName);
            this.pnlSidebarHeader.Controls.Add(this.lblAppIcon);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(240, 90);
            this.pnlSidebarHeader.TabIndex = 13;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlSeparator.Location = new System.Drawing.Point(0, 89);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(240, 1);
            this.pnlSeparator.TabIndex = 0;
            // 
            // lblAppSub
            // 
            this.lblAppSub.AutoSize = true;
            this.lblAppSub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAppSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAppSub.Location = new System.Drawing.Point(62, 38);
            this.lblAppSub.Name = "lblAppSub";
            this.lblAppSub.Size = new System.Drawing.Size(138, 20);
            this.lblAppSub.TabIndex = 1;
            this.lblAppSub.Text = "Hotel Management";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(62, 18);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(136, 28);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Grand Palace";
            // 
            // lblAppIcon
            // 
            this.lblAppIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(99)))), ((int)(((byte)(200)))));
            this.lblAppIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 22F);
            this.lblAppIcon.ForeColor = System.Drawing.Color.White;
            this.lblAppIcon.Location = new System.Drawing.Point(10, 20);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(46, 46);
            this.lblAppIcon.TabIndex = 3;
            this.lblAppIcon.Text = "🏢";
            this.lblAppIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActiveIndicator
            // 
            this.pnlActiveIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(219)))));
            this.pnlActiveIndicator.Location = new System.Drawing.Point(0, 90);
            this.pnlActiveIndicator.Name = "pnlActiveIndicator";
            this.pnlActiveIndicator.Size = new System.Drawing.Size(4, 40);
            this.pnlActiveIndicator.TabIndex = 14;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pnlWorkArea);
            this.pnlContent.Controls.Add(this.pnlFooter);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(860, 700);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.BackColor = System.Drawing.Color.White;
            this.pnlWorkArea.Controls.Add(this.lblWelcomeSub);
            this.pnlWorkArea.Controls.Add(this.lblWelcomeTitle);
            this.pnlWorkArea.Controls.Add(this.lblWelcomeIcon);
            this.pnlWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkArea.Location = new System.Drawing.Point(0, 64);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(860, 601);
            this.pnlWorkArea.TabIndex = 1;
            this.pnlWorkArea.Resize += new System.EventHandler(this.pnlWorkArea_Resize);
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.AutoSize = true;
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWelcomeSub.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(546, 30);
            this.lblWelcomeSub.TabIndex = 0;
            this.lblWelcomeSub.Text = "Hotel Management System — Select a section to begin";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(296, 60);
            this.lblWelcomeTitle.TabIndex = 1;
            this.lblWelcomeTitle.Text = "Grand Palace";
            // 
            // lblWelcomeIcon
            // 
            this.lblWelcomeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(99)))), ((int)(((byte)(200)))));
            this.lblWelcomeIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 52F);
            this.lblWelcomeIcon.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeIcon.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeIcon.Name = "lblWelcomeIcon";
            this.lblWelcomeIcon.Size = new System.Drawing.Size(140, 130);
            this.lblWelcomeIcon.TabIndex = 2;
            this.lblWelcomeIcon.Text = "🏢";
            this.lblWelcomeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.lblFooterVersion);
            this.pnlFooter.Controls.Add(this.lblFooterCopyright);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 665);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(860, 35);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblFooterVersion
            // 
            this.lblFooterVersion.AutoSize = true;
            this.lblFooterVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFooterVersion.Location = new System.Drawing.Point(15, 10);
            this.lblFooterVersion.Name = "lblFooterVersion";
            this.lblFooterVersion.Size = new System.Drawing.Size(51, 21);
            this.lblFooterVersion.TabIndex = 0;
            this.lblFooterVersion.Text = "v1.0.0";
            // 
            // lblFooterCopyright
            // 
            this.lblFooterCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterCopyright.AutoSize = true;
            this.lblFooterCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFooterCopyright.Location = new System.Drawing.Point(689, 10);
            this.lblFooterCopyright.Name = "lblFooterCopyright";
            this.lblFooterCopyright.Size = new System.Drawing.Size(156, 21);
            this.lblFooterCopyright.TabIndex = 1;
            this.lblFooterCopyright.Text = "© Grand Palace HMS";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnDarkMode);
            this.pnlTopBar.Controls.Add(this.pnlUserBtn);
            this.pnlTopBar.Controls.Add(this.lblTopSub);
            this.pnlTopBar.Controls.Add(this.lblTopTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(860, 64);
            this.pnlTopBar.TabIndex = 2;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnDarkMode.Location = new System.Drawing.Point(755, 12);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(40, 40);
            this.btnDarkMode.TabIndex = 0;
            this.btnDarkMode.Text = "🌙";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.ToggleDarkMode);
            // 
            // pnlUserBtn
            // 
            this.pnlUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlUserBtn.Controls.Add(this.lblUserRole);
            this.pnlUserBtn.Controls.Add(this.lblUserFullName);
            this.pnlUserBtn.Controls.Add(this.lblUserAvatar);
            this.pnlUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUserBtn.Location = new System.Drawing.Point(625, 8);
            this.pnlUserBtn.Name = "pnlUserBtn";
            this.pnlUserBtn.Size = new System.Drawing.Size(220, 48);
            this.pnlUserBtn.TabIndex = 1;
            this.pnlUserBtn.Click += new System.EventHandler(this.pnlUserBtn_Click);
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(219)))));
            this.lblUserRole.Location = new System.Drawing.Point(52, 26);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(125, 20);
            this.lblUserRole.TabIndex = 0;
            this.lblUserRole.Text = "👑 Administrator";
            this.lblUserRole.Click += new System.EventHandler(this.pnlUserBtn_Click);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblUserFullName.Location = new System.Drawing.Point(52, 8);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(170, 25);
            this.lblUserFullName.TabIndex = 1;
            this.lblUserFullName.Text = "Zaid Abdulrahman";
            this.lblUserFullName.Click += new System.EventHandler(this.pnlUserBtn_Click);
            // 
            // lblUserAvatar
            // 
            this.lblUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(219)))));
            this.lblUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserAvatar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserAvatar.ForeColor = System.Drawing.Color.White;
            this.lblUserAvatar.Location = new System.Drawing.Point(8, 6);
            this.lblUserAvatar.Name = "lblUserAvatar";
            this.lblUserAvatar.Size = new System.Drawing.Size(36, 36);
            this.lblUserAvatar.TabIndex = 2;
            this.lblUserAvatar.Text = "Z";
            this.lblUserAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserAvatar.Click += new System.EventHandler(this.pnlUserBtn_Click);
            // 
            // lblTopSub
            // 
            this.lblTopSub.AutoSize = true;
            this.lblTopSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTopSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTopSub.Location = new System.Drawing.Point(20, 34);
            this.lblTopSub.Name = "lblTopSub";
            this.lblTopSub.Size = new System.Drawing.Size(217, 23);
            this.lblTopSub.TabIndex = 2;
            this.lblTopSub.Text = "Hotel Management System";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTopTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(324, 36);
            this.lblTopTitle.TabIndex = 3;
            this.lblTopTitle.Text = "Welcome to Grand Palace";
            // 
            // Mainform
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Palace";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResizeEnd += new System.EventHandler(this.Mainform_ResizeEnd);
            this.Resize += new System.EventHandler(this.Mainform_Resize);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlWorkArea.ResumeLayout(false);
            this.pnlWorkArea.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlUserBtn.ResumeLayout(false);
            this.pnlUserBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void ApplyThemeColors()
        {
            this.BackColor = contentBackColor;
            this.pnlSidebar.BackColor = sideBarColor;
            this.pnlSidebarHeader.BackColor = sideBarHeaderColor;
            this.pnlContent.BackColor = contentBackColor;
            this.pnlTopBar.BackColor = topBarColor;
            this.pnlWorkArea.BackColor = contentBackColor;
            this.pnlFooter.BackColor = footerColor;
            this.pnlUserBtn.BackColor = userBtnColor;

            this.lblTopTitle.ForeColor = textColor;
            this.lblTopSub.ForeColor = subTextColor;
            this.lblWelcomeTitle.ForeColor = textColor;
            this.lblWelcomeSub.ForeColor = subTextColor;
            this.lblFooterVersion.ForeColor = subTextColor;
            this.lblFooterCopyright.ForeColor = subTextColor;
            this.lblUserFullName.ForeColor = textColor;

            foreach (Button btn in new Button[] { btnNavRooms, btnNavCustomers, btnNavReservations,
                btnNavCheckIn, btnNavServices, btnNavvUsers, btnNavsReports,
                btnExits, btnNavvUsers, btnNavsReports })
            {
                if (btn != currentActiveButton)
                {
                    btn.ForeColor = subTextColor;
                    btn.BackColor = Color.Transparent;
                }
            }

            if (currentActiveButton != null && currentActiveButton != btnExits)
            {
                currentActiveButton.BackColor = Color.FromArgb(59, 91, 219);
                currentActiveButton.ForeColor = Color.White;
            }

            this.btnExits.ForeColor = Color.FromArgb(239, 68, 68);
        }

        private void ToggleDarkMode(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            if (isDarkMode) { SetDarkModeColors(); btnDarkMode.Text = "☀️"; }
            else { SetLightModeColors(); btnDarkMode.Text = "🌙"; }
            ApplyThemeColors();
            this.pnlTopBar.Invalidate();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            AdjustUserPanelPosition();
            CenterWelcomeContent();
        }

        private void CenterWelcomeContent()
        {
            if (pnlWorkArea == null || !pnlWorkArea.IsHandleCreated) return;

            lblWelcomeTitle.Size = TextRenderer.MeasureText(lblWelcomeTitle.Text, lblWelcomeTitle.Font);
            lblWelcomeSub.Size = TextRenderer.MeasureText(lblWelcomeSub.Text, lblWelcomeSub.Font);

            int cx = pnlWorkArea.ClientSize.Width / 2;
            int cy = pnlWorkArea.ClientSize.Height / 2;

            int totalH = lblWelcomeIcon.Height + 20 + lblWelcomeTitle.Height + 10 + lblWelcomeSub.Height;
            int startY = cy - totalH / 2;

            lblWelcomeIcon.Left = cx - lblWelcomeIcon.Width / 2;
            lblWelcomeIcon.Top = startY;

            lblWelcomeTitle.Left = cx - lblWelcomeTitle.Width / 2;
            lblWelcomeTitle.Top = lblWelcomeIcon.Bottom + 20;

            lblWelcomeSub.Left = cx - lblWelcomeSub.Width / 2;
            lblWelcomeSub.Top = lblWelcomeTitle.Bottom + 10;
        }

        private void pnlWorkArea_Resize(object sender, EventArgs e) =>
            CenterWelcomeContent();

        private void Mainform_Resize(object sender, EventArgs e) =>
            AdjustUserPanelPosition();

        private void Mainform_ResizeEnd(object sender, EventArgs e)
        {
            AdjustUserPanelPosition();
            CenterWelcomeContent();
        }

        private void AdjustUserPanelPosition()
        {
            if (pnlUserBtn != null && pnlTopBar != null)
            {
                pnlUserBtn.Left = pnlTopBar.Width - pnlUserBtn.Width - 15;
                if (btnDarkMode != null)
                    btnDarkMode.Left = pnlUserBtn.Left - 50;
            }
            if (pnlFooter != null && lblFooterCopyright != null)
                lblFooterCopyright.Left = pnlFooter.Width - lblFooterCopyright.Width - 15;
        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1f))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        // ── CONTROL DECLARATIONS ─────────────────────────────────────────────
        private Panel pnlSidebar;
        private Panel pnlSidebarHeader;
        private Label lblAppIcon;
        private Label lblAppName;
        private Label lblAppSub;
        private Panel pnlSeparator;
        private Button btnNavRooms;
        private Button btnNavCustomers;
        private Button btnNavReservations;
        private Button btnNavServices;
        private Button btnNavvUsers;
        private Button btnNavsReports;
        private Button btnExits;
        private Label lblSidebarVersion;
        private Label lblSidebarHotelIcon;
        private Panel pnlContent;
        private Panel pnlFooter;
        private Label lblFooterVersion;
        private Label lblFooterCopyright;
        private Panel pnlWorkArea;
        private Label lblWelcomeSub;
        private Label lblWelcomeTitle;
        private Label lblWelcomeIcon;
        private Panel pnlTopBar;
        private Panel pnlUserBtn;
        private Label lblUserRole;
        private Label lblUserFullName;
        private Label lblUserAvatar;
        private Label lblTopSub;
        private Label lblTopTitle;
        private Button btnNavCheckIn;
    }
}