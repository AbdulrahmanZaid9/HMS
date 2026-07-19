namespace HMS.Customers.Controls
{
    partial class CtrlViewCusomterProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustIdBadge = new System.Windows.Forms.Label();
            this.lblPersonIdBadge = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.lblContactHeader = new System.Windows.Forms.Label();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.lblEmailCaption = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneIcon = new System.Windows.Forms.Label();
            this.lblPhoneCaption = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressIcon = new System.Windows.Forms.Label();
            this.lblAddressCaption = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlPersonal = new System.Windows.Forms.Panel();
            this.lblPersonalHeader = new System.Windows.Forms.Label();
            this.lblDOBIcon = new System.Windows.Forms.Label();
            this.lblDOBCaption = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGenderIcon = new System.Windows.Forms.Label();
            this.lblGenderCaption = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalityIcon = new System.Windows.Forms.Label();
            this.lblNationalityCaption = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblPassportIcon = new System.Windows.Forms.Label();
            this.lblPassportCaption = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.lblNotesHeader = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblClockIcon = new System.Windows.Forms.Label();
            this.lblTimestamps = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlProfileHeader.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.pnlPersonal.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfileHeader
            // 
            this.pnlProfileHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlProfileHeader.Controls.Add(this.picAvatar);
            this.pnlProfileHeader.Controls.Add(this.lblName);
            this.pnlProfileHeader.Controls.Add(this.lblCustIdBadge);
            this.pnlProfileHeader.Controls.Add(this.lblPersonIdBadge);
            this.pnlProfileHeader.Controls.Add(this.lblStatusBadge);
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileHeader.Name = "pnlProfileHeader";
            this.pnlProfileHeader.Size = new System.Drawing.Size(680, 80);
            this.pnlProfileHeader.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.picAvatar.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.picAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.picAvatar.Location = new System.Drawing.Point(14, 14);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(52, 52);
            this.picAvatar.TabIndex = 0;
            this.picAvatar.Text = "👤";
            this.picAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(78, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "—";
            // 
            // lblCustIdBadge
            // 
            this.lblCustIdBadge.AutoSize = true;
            this.lblCustIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustIdBadge.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCustIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblCustIdBadge.Location = new System.Drawing.Point(80, 48);
            this.lblCustIdBadge.Name = "lblCustIdBadge";
            this.lblCustIdBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblCustIdBadge.Size = new System.Drawing.Size(85, 24);
            this.lblCustIdBadge.TabIndex = 2;
            this.lblCustIdBadge.Text = "CUST #??";
            // 
            // lblPersonIdBadge
            // 
            this.lblPersonIdBadge.AutoSize = true;
            this.lblPersonIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPersonIdBadge.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblPersonIdBadge.Location = new System.Drawing.Point(160, 48);
            this.lblPersonIdBadge.Name = "lblPersonIdBadge";
            this.lblPersonIdBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblPersonIdBadge.Size = new System.Drawing.Size(106, 24);
            this.lblPersonIdBadge.TabIndex = 3;
            this.lblPersonIdBadge.Text = "PERSON #??";
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusBadge.AutoSize = true;
            this.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(247)))), ((int)(((byte)(208)))));
            this.lblStatusBadge.Location = new System.Drawing.Point(560, 28);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblStatusBadge.Size = new System.Drawing.Size(78, 29);
            this.lblStatusBadge.TabIndex = 4;
            this.lblStatusBadge.Text = "Active";
            // 
            // pnlContact
            // 
            this.pnlContact.BackColor = System.Drawing.Color.White;
            this.pnlContact.Controls.Add(this.lblContactHeader);
            this.pnlContact.Controls.Add(this.lblEmailIcon);
            this.pnlContact.Controls.Add(this.lblEmailCaption);
            this.pnlContact.Controls.Add(this.lblEmail);
            this.pnlContact.Controls.Add(this.lblPhoneIcon);
            this.pnlContact.Controls.Add(this.lblPhoneCaption);
            this.pnlContact.Controls.Add(this.lblPhone);
            this.pnlContact.Controls.Add(this.lblAddressIcon);
            this.pnlContact.Controls.Add(this.lblAddressCaption);
            this.pnlContact.Controls.Add(this.lblAddress);
            this.pnlContact.Location = new System.Drawing.Point(0, 80);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(340, 175);
            this.pnlContact.TabIndex = 1;
            // 
            // lblContactHeader
            // 
            this.lblContactHeader.AutoSize = true;
            this.lblContactHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblContactHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblContactHeader.Location = new System.Drawing.Point(16, 10);
            this.lblContactHeader.Name = "lblContactHeader";
            this.lblContactHeader.Size = new System.Drawing.Size(78, 20);
            this.lblContactHeader.TabIndex = 0;
            this.lblContactHeader.Text = "CONTACT";
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmailIcon.Location = new System.Drawing.Point(16, 33);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(28, 30);
            this.lblEmailIcon.TabIndex = 1;
            this.lblEmailIcon.Text = "✉";
            this.lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailCaption
            // 
            this.lblEmailCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmailCaption.Location = new System.Drawing.Point(48, 34);
            this.lblEmailCaption.Name = "lblEmailCaption";
            this.lblEmailCaption.Size = new System.Drawing.Size(96, 20);
            this.lblEmailCaption.TabIndex = 2;
            this.lblEmailCaption.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoEllipsis = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblEmail.Location = new System.Drawing.Point(148, 34);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(182, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "—";
            // 
            // lblPhoneIcon
            // 
            this.lblPhoneIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblPhoneIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhoneIcon.Location = new System.Drawing.Point(16, 62);
            this.lblPhoneIcon.Name = "lblPhoneIcon";
            this.lblPhoneIcon.Size = new System.Drawing.Size(28, 30);
            this.lblPhoneIcon.TabIndex = 4;
            this.lblPhoneIcon.Text = "📞";
            this.lblPhoneIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneCaption
            // 
            this.lblPhoneCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhoneCaption.Location = new System.Drawing.Point(48, 64);
            this.lblPhoneCaption.Name = "lblPhoneCaption";
            this.lblPhoneCaption.Size = new System.Drawing.Size(96, 20);
            this.lblPhoneCaption.TabIndex = 5;
            this.lblPhoneCaption.Text = "Phone";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoEllipsis = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPhone.Location = new System.Drawing.Point(148, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(182, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "—";
            // 
            // lblAddressIcon
            // 
            this.lblAddressIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblAddressIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAddressIcon.Location = new System.Drawing.Point(16, 94);
            this.lblAddressIcon.Name = "lblAddressIcon";
            this.lblAddressIcon.Size = new System.Drawing.Size(28, 29);
            this.lblAddressIcon.TabIndex = 7;
            this.lblAddressIcon.Text = "📍";
            this.lblAddressIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddressCaption
            // 
            this.lblAddressCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAddressCaption.Location = new System.Drawing.Point(48, 94);
            this.lblAddressCaption.Name = "lblAddressCaption";
            this.lblAddressCaption.Size = new System.Drawing.Size(96, 20);
            this.lblAddressCaption.TabIndex = 8;
            this.lblAddressCaption.Text = "Address";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblAddress.Location = new System.Drawing.Point(148, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(182, 81);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "—";
            // 
            // pnlPersonal
            // 
            this.pnlPersonal.BackColor = System.Drawing.Color.White;
            this.pnlPersonal.Controls.Add(this.lblPersonalHeader);
            this.pnlPersonal.Controls.Add(this.lblDOBIcon);
            this.pnlPersonal.Controls.Add(this.lblDOBCaption);
            this.pnlPersonal.Controls.Add(this.lblDOB);
            this.pnlPersonal.Controls.Add(this.lblGenderIcon);
            this.pnlPersonal.Controls.Add(this.lblGenderCaption);
            this.pnlPersonal.Controls.Add(this.lblGender);
            this.pnlPersonal.Controls.Add(this.lblNationalityIcon);
            this.pnlPersonal.Controls.Add(this.lblNationalityCaption);
            this.pnlPersonal.Controls.Add(this.lblNationality);
            this.pnlPersonal.Controls.Add(this.lblPassportIcon);
            this.pnlPersonal.Controls.Add(this.lblPassportCaption);
            this.pnlPersonal.Controls.Add(this.lblPassport);
            this.pnlPersonal.Location = new System.Drawing.Point(340, 80);
            this.pnlPersonal.Name = "pnlPersonal";
            this.pnlPersonal.Size = new System.Drawing.Size(340, 175);
            this.pnlPersonal.TabIndex = 2;
            // 
            // lblPersonalHeader
            // 
            this.lblPersonalHeader.AutoSize = true;
            this.lblPersonalHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonalHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPersonalHeader.Location = new System.Drawing.Point(16, 10);
            this.lblPersonalHeader.Name = "lblPersonalHeader";
            this.lblPersonalHeader.Size = new System.Drawing.Size(86, 20);
            this.lblPersonalHeader.TabIndex = 0;
            this.lblPersonalHeader.Text = "PERSONAL";
            // 
            // lblDOBIcon
            // 
            this.lblDOBIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblDOBIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDOBIcon.Location = new System.Drawing.Point(16, 31);
            this.lblDOBIcon.Name = "lblDOBIcon";
            this.lblDOBIcon.Size = new System.Drawing.Size(28, 30);
            this.lblDOBIcon.TabIndex = 1;
            this.lblDOBIcon.Text = "📅";
            this.lblDOBIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDOBCaption
            // 
            this.lblDOBCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDOBCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDOBCaption.Location = new System.Drawing.Point(48, 34);
            this.lblDOBCaption.Name = "lblDOBCaption";
            this.lblDOBCaption.Size = new System.Drawing.Size(96, 20);
            this.lblDOBCaption.TabIndex = 2;
            this.lblDOBCaption.Text = "Date of birth";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoEllipsis = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDOB.Location = new System.Drawing.Point(148, 34);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(182, 20);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "—";
            // 
            // lblGenderIcon
            // 
            this.lblGenderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblGenderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGenderIcon.Location = new System.Drawing.Point(16, 62);
            this.lblGenderIcon.Name = "lblGenderIcon";
            this.lblGenderIcon.Size = new System.Drawing.Size(28, 30);
            this.lblGenderIcon.TabIndex = 4;
            this.lblGenderIcon.Text = "⚧";
            this.lblGenderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenderCaption
            // 
            this.lblGenderCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGenderCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGenderCaption.Location = new System.Drawing.Point(48, 64);
            this.lblGenderCaption.Name = "lblGenderCaption";
            this.lblGenderCaption.Size = new System.Drawing.Size(96, 20);
            this.lblGenderCaption.TabIndex = 5;
            this.lblGenderCaption.Text = "Gender";
            // 
            // lblGender
            // 
            this.lblGender.AutoEllipsis = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGender.Location = new System.Drawing.Point(148, 64);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(182, 20);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "—";
            // 
            // lblNationalityIcon
            // 
            this.lblNationalityIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblNationalityIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNationalityIcon.Location = new System.Drawing.Point(16, 93);
            this.lblNationalityIcon.Name = "lblNationalityIcon";
            this.lblNationalityIcon.Size = new System.Drawing.Size(28, 30);
            this.lblNationalityIcon.TabIndex = 7;
            this.lblNationalityIcon.Text = "🌐";
            this.lblNationalityIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNationalityCaption
            // 
            this.lblNationalityCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalityCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNationalityCaption.Location = new System.Drawing.Point(48, 94);
            this.lblNationalityCaption.Name = "lblNationalityCaption";
            this.lblNationalityCaption.Size = new System.Drawing.Size(96, 20);
            this.lblNationalityCaption.TabIndex = 8;
            this.lblNationalityCaption.Text = "Nationality";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoEllipsis = true;
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNationality.Location = new System.Drawing.Point(148, 94);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(182, 20);
            this.lblNationality.TabIndex = 9;
            this.lblNationality.Text = "—";
            // 
            // lblPassportIcon
            // 
            this.lblPassportIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.lblPassportIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPassportIcon.Location = new System.Drawing.Point(16, 119);
            this.lblPassportIcon.Name = "lblPassportIcon";
            this.lblPassportIcon.Size = new System.Drawing.Size(28, 32);
            this.lblPassportIcon.TabIndex = 10;
            this.lblPassportIcon.Text = "🪪";
            this.lblPassportIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassportCaption
            // 
            this.lblPassportCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassportCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPassportCaption.Location = new System.Drawing.Point(48, 124);
            this.lblPassportCaption.Name = "lblPassportCaption";
            this.lblPassportCaption.Size = new System.Drawing.Size(96, 20);
            this.lblPassportCaption.TabIndex = 11;
            this.lblPassportCaption.Text = "Passport";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoEllipsis = true;
            this.lblPassport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPassport.Location = new System.Drawing.Point(148, 124);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(182, 20);
            this.lblPassport.TabIndex = 12;
            this.lblPassport.Text = "—";
            // 
            // pnlNotes
            // 
            this.pnlNotes.BackColor = System.Drawing.Color.White;
            this.pnlNotes.Controls.Add(this.lblNotesHeader);
            this.pnlNotes.Controls.Add(this.lblNotes);
            this.pnlNotes.Location = new System.Drawing.Point(0, 255);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(680, 100);
            this.pnlNotes.TabIndex = 3;
            // 
            // lblNotesHeader
            // 
            this.lblNotesHeader.AutoSize = true;
            this.lblNotesHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNotesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNotesHeader.Location = new System.Drawing.Point(20, 12);
            this.lblNotesHeader.Name = "lblNotesHeader";
            this.lblNotesHeader.Size = new System.Drawing.Size(56, 20);
            this.lblNotesHeader.TabIndex = 0;
            this.lblNotesHeader.Text = "NOTES";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNotes.Location = new System.Drawing.Point(20, 32);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(640, 52);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "—";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblClockIcon);
            this.pnlFooter.Controls.Add(this.lblTimestamps);
            this.pnlFooter.Location = new System.Drawing.Point(0, 355);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(680, 36);
            this.pnlFooter.TabIndex = 4;
            // 
            // lblClockIcon
            // 
            this.lblClockIcon.AutoSize = true;
            this.lblClockIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClockIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblClockIcon.Location = new System.Drawing.Point(20, 10);
            this.lblClockIcon.Name = "lblClockIcon";
            this.lblClockIcon.Size = new System.Drawing.Size(37, 25);
            this.lblClockIcon.TabIndex = 0;
            this.lblClockIcon.Text = "🕐";
            // 
            // lblTimestamps
            // 
            this.lblTimestamps.AutoSize = true;
            this.lblTimestamps.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTimestamps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTimestamps.Location = new System.Drawing.Point(44, 10);
            this.lblTimestamps.Name = "lblTimestamps";
            this.lblTimestamps.Size = new System.Drawing.Size(212, 21);
            this.lblTimestamps.TabIndex = 1;
            this.lblTimestamps.Text = "Created —  ·  Last updated —";
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
            this.btnEditInfo.Location = new System.Drawing.Point(145, 402);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(180, 44);
            this.btnEditInfo.TabIndex = 5;
            this.btnEditInfo.Text = "✎  Edit Info";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(-49, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CtrlViewCusomterProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.pnlProfileHeader);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.pnlPersonal);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.pnlFooter);
            this.Name = "CtrlViewCusomterProfile";
            this.Size = new System.Drawing.Size(680, 450);
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.pnlPersonal.ResumeLayout(false);
            this.pnlPersonal.PerformLayout();
            this.pnlNotes.ResumeLayout(false);
            this.pnlNotes.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlProfileHeader;
        private System.Windows.Forms.Label picAvatar;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCustIdBadge;
        public System.Windows.Forms.Label lblPersonIdBadge;
        public System.Windows.Forms.Label lblStatusBadge;

        // Contact panel
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Label lblContactHeader;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.Label lblEmailCaption;
        public System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneIcon;
        private System.Windows.Forms.Label lblPhoneCaption;
        public System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressIcon;
        private System.Windows.Forms.Label lblAddressCaption;
        public System.Windows.Forms.Label lblAddress;

        // Personal panel
        private System.Windows.Forms.Panel pnlPersonal;
        private System.Windows.Forms.Label lblPersonalHeader;
        private System.Windows.Forms.Label lblDOBIcon;
        private System.Windows.Forms.Label lblDOBCaption;
        public System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGenderIcon;
        private System.Windows.Forms.Label lblGenderCaption;
        public System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalityIcon;
        private System.Windows.Forms.Label lblNationalityCaption;
        public System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblPassportIcon;
        private System.Windows.Forms.Label lblPassportCaption;
        public System.Windows.Forms.Label lblPassport;

        // Notes
        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Label lblNotesHeader;
        public System.Windows.Forms.Label lblNotes;

        // Footer
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblClockIcon;
        public System.Windows.Forms.Label lblTimestamps;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnEditInfo;
        public System.Windows.Forms.Button btnClose;
    }
}