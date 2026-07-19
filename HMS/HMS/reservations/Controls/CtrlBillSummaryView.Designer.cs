namespace HMS.reservations.Controls
{
    partial class CtrlBillSummaryView
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
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblItemCountBadge = new System.Windows.Forms.Label();
            this.pnlDividerTop = new System.Windows.Forms.Panel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblReservationInfo = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblPaidAt = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCard.Controls.Add(this.lblBillID);
            this.pnlCard.Controls.Add(this.lblPaymentStatus);
            this.pnlCard.Controls.Add(this.lblHeaderTitle);
            this.pnlCard.Controls.Add(this.lblItemCountBadge);
            this.pnlCard.Controls.Add(this.pnlDividerTop);
            this.pnlCard.Controls.Add(this.flpItems);
            this.pnlCard.Controls.Add(this.pnlDivider);
            this.pnlCard.Controls.Add(this.lblTotalCaption);
            this.pnlCard.Controls.Add(this.lblTotalValue);
            this.pnlCard.Controls.Add(this.lblReservationInfo);
            this.pnlCard.Controls.Add(this.lblCreatedAt);
            this.pnlCard.Controls.Add(this.lblPaidAt);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(480, 260);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // lblBillID
            // 
            this.lblBillID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.lblBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBillID.Location = new System.Drawing.Point(16, 2);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(448, 16);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPaymentStatus.Location = new System.Drawing.Point(330, 16);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(134, 26);
            this.lblPaymentStatus.TabIndex = 10;
            this.lblPaymentStatus.Text = "";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPaymentStatus.Visible = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(448, 26);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "★ BILL SUMMARY ★";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemCountBadge
            // 
            this.lblItemCountBadge.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblItemCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblItemCountBadge.Location = new System.Drawing.Point(16, 44);
            this.lblItemCountBadge.Name = "lblItemCountBadge";
            this.lblItemCountBadge.Size = new System.Drawing.Size(448, 18);
            this.lblItemCountBadge.TabIndex = 2;
            this.lblItemCountBadge.Text = "-- 0 items --";
            this.lblItemCountBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDividerTop
            // 
            this.pnlDividerTop.Location = new System.Drawing.Point(16, 66);
            this.pnlDividerTop.Name = "pnlDividerTop";
            this.pnlDividerTop.Size = new System.Drawing.Size(448, 10);
            this.pnlDividerTop.TabIndex = 3;
            this.pnlDividerTop.Paint += new System.Windows.Forms.PaintEventHandler(this.Divider_Paint);
            // 
            // flpItems
            // 
            this.flpItems.AutoSize = true;
            this.flpItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItems.Location = new System.Drawing.Point(16, 80);
            this.flpItems.Margin = new System.Windows.Forms.Padding(0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(0, 0);
            this.flpItems.TabIndex = 4;
            this.flpItems.WrapContents = false;
            // 
            // pnlDivider
            // 
            this.pnlDivider.Location = new System.Drawing.Point(16, 96);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(448, 10);
            this.pnlDivider.TabIndex = 5;
            this.pnlDivider.Paint += new System.Windows.Forms.PaintEventHandler(this.Divider_Paint);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 110);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(150, 28);
            this.lblTotalCaption.TabIndex = 6;
            this.lblTotalCaption.Text = "TOTAL";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblTotalValue.Location = new System.Drawing.Point(204, 106);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(260, 34);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReservationInfo
            // 
            this.lblReservationInfo.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblReservationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblReservationInfo.Location = new System.Drawing.Point(16, 152);
            this.lblReservationInfo.Name = "lblReservationInfo";
            this.lblReservationInfo.Size = new System.Drawing.Size(448, 18);
            this.lblReservationInfo.TabIndex = 8;
            this.lblReservationInfo.Text = "Reservation #0  •  Room #0  •  Customer #0";
            this.lblReservationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCreatedAt.Location = new System.Drawing.Point(16, 170);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(220, 18);
            this.lblCreatedAt.TabIndex = 9;
            this.lblCreatedAt.Text = "Created: --";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaidAt
            // 
            this.lblPaidAt.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblPaidAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPaidAt.Location = new System.Drawing.Point(244, 170);
            this.lblPaidAt.Name = "lblPaidAt";
            this.lblPaidAt.Size = new System.Drawing.Size(220, 18);
            this.lblPaidAt.TabIndex = 11;
            this.lblPaidAt.Text = "Paid: --";
            this.lblPaidAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CtrlBillSummaryView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "CtrlBillSummaryView";
            this.Size = new System.Drawing.Size(480, 260);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblItemCountBadge;
        private System.Windows.Forms.Panel pnlDividerTop;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblReservationInfo;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblPaidAt;
    }
}