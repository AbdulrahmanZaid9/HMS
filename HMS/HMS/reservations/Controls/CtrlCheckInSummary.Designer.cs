namespace HMS.reservations.Controls
{
    partial class CtrlCheckInSummary
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.picCheckIcon = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.lblGuestCaption = new System.Windows.Forms.Label();
            this.lblGuestValue = new System.Windows.Forms.Label();
            this.lblRoomCaption = new System.Windows.Forms.Label();
            this.lblRoomValue = new System.Windows.Forms.Label();
            this.lblCheckInCaption = new System.Windows.Forms.Label();
            this.lblCheckInValue = new System.Windows.Forms.Label();
            this.lblCheckOutCaption = new System.Windows.Forms.Label();
            this.lblCheckOutValue = new System.Windows.Forms.Label();
            this.lblDurationCaption = new System.Windows.Forms.Label();
            this.lblDurationValue = new System.Windows.Forms.Label();

            this.pnlDivider = new System.Windows.Forms.Panel();

            this.lblRoomTotalCaption = new System.Windows.Forms.Label();
            this.lblRoomTotalValue = new System.Windows.Forms.Label();

            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // pnlCard
            // =========================================================
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.pnlCard.Controls.Add(this.picCheckIcon);
            this.pnlCard.Controls.Add(this.lblHeaderTitle);
            this.pnlCard.Controls.Add(this.lblGuestCaption);
            this.pnlCard.Controls.Add(this.lblGuestValue);
            this.pnlCard.Controls.Add(this.lblRoomCaption);
            this.pnlCard.Controls.Add(this.lblRoomValue);
            this.pnlCard.Controls.Add(this.lblCheckInCaption);
            this.pnlCard.Controls.Add(this.lblCheckInValue);
            this.pnlCard.Controls.Add(this.lblCheckOutCaption);
            this.pnlCard.Controls.Add(this.lblCheckOutValue);
            this.pnlCard.Controls.Add(this.lblDurationCaption);
            this.pnlCard.Controls.Add(this.lblDurationValue);
            this.pnlCard.Controls.Add(this.pnlDivider);
            this.pnlCard.Controls.Add(this.lblRoomTotalCaption);
            this.pnlCard.Controls.Add(this.lblRoomTotalValue);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(480, 290);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            //
            // picCheckIcon
            //
            this.picCheckIcon.Location = new System.Drawing.Point(16, 14);
            this.picCheckIcon.Name = "picCheckIcon";
            this.picCheckIcon.Size = new System.Drawing.Size(26, 26);
            this.picCheckIcon.TabIndex = 0;
            this.picCheckIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.picCheckIcon_Paint);
            //
            // lblHeaderTitle
            //
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(52, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(230, 25);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Ready to Check In";
            //
            // lblGuestCaption
            //
            this.lblGuestCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGuestCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblGuestCaption.Location = new System.Drawing.Point(16, 60);
            this.lblGuestCaption.Name = "lblGuestCaption";
            this.lblGuestCaption.Size = new System.Drawing.Size(140, 22);
            this.lblGuestCaption.TabIndex = 2;
            this.lblGuestCaption.Text = "Guest";
            //
            // lblGuestValue
            //
            this.lblGuestValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuestValue.AutoEllipsis = true;
            this.lblGuestValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGuestValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblGuestValue.Location = new System.Drawing.Point(204, 60);
            this.lblGuestValue.Name = "lblGuestValue";
            this.lblGuestValue.Size = new System.Drawing.Size(260, 22);
            this.lblGuestValue.TabIndex = 3;
            this.lblGuestValue.Text = "—";
            this.lblGuestValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblRoomCaption
            //
            this.lblRoomCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRoomCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRoomCaption.Location = new System.Drawing.Point(16, 92);
            this.lblRoomCaption.Name = "lblRoomCaption";
            this.lblRoomCaption.Size = new System.Drawing.Size(140, 22);
            this.lblRoomCaption.TabIndex = 4;
            this.lblRoomCaption.Text = "Room";
            //
            // lblRoomValue
            //
            this.lblRoomValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomValue.AutoEllipsis = true;
            this.lblRoomValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRoomValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRoomValue.Location = new System.Drawing.Point(204, 92);
            this.lblRoomValue.Name = "lblRoomValue";
            this.lblRoomValue.Size = new System.Drawing.Size(260, 22);
            this.lblRoomValue.TabIndex = 5;
            this.lblRoomValue.Text = "—";
            this.lblRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblCheckInCaption
            //
            this.lblCheckInCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCheckInCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCheckInCaption.Location = new System.Drawing.Point(16, 124);
            this.lblCheckInCaption.Name = "lblCheckInCaption";
            this.lblCheckInCaption.Size = new System.Drawing.Size(140, 22);
            this.lblCheckInCaption.TabIndex = 6;
            this.lblCheckInCaption.Text = "Check-in";
            //
            // lblCheckInValue
            //
            this.lblCheckInValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckInValue.AutoEllipsis = true;
            this.lblCheckInValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckInValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckInValue.Location = new System.Drawing.Point(204, 124);
            this.lblCheckInValue.Name = "lblCheckInValue";
            this.lblCheckInValue.Size = new System.Drawing.Size(260, 22);
            this.lblCheckInValue.TabIndex = 7;
            this.lblCheckInValue.Text = "—";
            this.lblCheckInValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblCheckOutCaption
            //
            this.lblCheckOutCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCheckOutCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCheckOutCaption.Location = new System.Drawing.Point(16, 156);
            this.lblCheckOutCaption.Name = "lblCheckOutCaption";
            this.lblCheckOutCaption.Size = new System.Drawing.Size(140, 22);
            this.lblCheckOutCaption.TabIndex = 8;
            this.lblCheckOutCaption.Text = "Check-out";
            //
            // lblCheckOutValue
            //
            this.lblCheckOutValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckOutValue.AutoEllipsis = true;
            this.lblCheckOutValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckOutValue.Location = new System.Drawing.Point(204, 156);
            this.lblCheckOutValue.Name = "lblCheckOutValue";
            this.lblCheckOutValue.Size = new System.Drawing.Size(260, 22);
            this.lblCheckOutValue.TabIndex = 9;
            this.lblCheckOutValue.Text = "—";
            this.lblCheckOutValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblDurationCaption
            //
            this.lblDurationCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDurationCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDurationCaption.Location = new System.Drawing.Point(16, 188);
            this.lblDurationCaption.Name = "lblDurationCaption";
            this.lblDurationCaption.Size = new System.Drawing.Size(140, 22);
            this.lblDurationCaption.TabIndex = 10;
            this.lblDurationCaption.Text = "Duration";
            //
            // lblDurationValue
            //
            this.lblDurationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDurationValue.AutoEllipsis = true;
            this.lblDurationValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDurationValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDurationValue.Location = new System.Drawing.Point(204, 188);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(260, 22);
            this.lblDurationValue.TabIndex = 11;
            this.lblDurationValue.Text = "—";
            this.lblDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnlDivider
            //
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(167, 230, 201);
            this.pnlDivider.Location = new System.Drawing.Point(16, 224);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(448, 1);
            this.pnlDivider.TabIndex = 12;
            //
            // lblRoomTotalCaption
            //
            this.lblRoomTotalCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomTotalCaption.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRoomTotalCaption.Location = new System.Drawing.Point(16, 238);
            this.lblRoomTotalCaption.Name = "lblRoomTotalCaption";
            this.lblRoomTotalCaption.Size = new System.Drawing.Size(150, 26);
            this.lblRoomTotalCaption.TabIndex = 13;
            this.lblRoomTotalCaption.Text = "Room Total";
            //
            // lblRoomTotalValue
            //
            this.lblRoomTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomTotalValue.AutoEllipsis = true;
            this.lblRoomTotalValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRoomTotalValue.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblRoomTotalValue.Location = new System.Drawing.Point(204, 234);
            this.lblRoomTotalValue.Name = "lblRoomTotalValue";
            this.lblRoomTotalValue.Size = new System.Drawing.Size(260, 32);
            this.lblRoomTotalValue.TabIndex = 14;
            this.lblRoomTotalValue.Text = "—";
            this.lblRoomTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // =========================================================
            // CtrlCheckInSummary
            // =========================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "CtrlCheckInSummary";
            this.Size = new System.Drawing.Size(480, 290);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel picCheckIcon;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.Label lblGuestCaption;
        public System.Windows.Forms.Label lblGuestValue;
        private System.Windows.Forms.Label lblRoomCaption;
        public System.Windows.Forms.Label lblRoomValue;
        private System.Windows.Forms.Label lblCheckInCaption;
        public System.Windows.Forms.Label lblCheckInValue;
        private System.Windows.Forms.Label lblCheckOutCaption;
        public System.Windows.Forms.Label lblCheckOutValue;
        private System.Windows.Forms.Label lblDurationCaption;
        public System.Windows.Forms.Label lblDurationValue;

        private System.Windows.Forms.Panel pnlDivider;

        private System.Windows.Forms.Label lblRoomTotalCaption;
        public System.Windows.Forms.Label lblRoomTotalValue;
    }
}