namespace HMS.reservations
{
    partial class UcReservationHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblStatTotalIcon = new System.Windows.Forms.Label();
            this.lblStatTotalValue = new System.Windows.Forms.Label();
            this.lblStatTotalCaption = new System.Windows.Forms.Label();
            this.pnlStatNights = new System.Windows.Forms.Panel();
            this.lblStatNightsIcon = new System.Windows.Forms.Label();
            this.lblStatNightsValue = new System.Windows.Forms.Label();
            this.lblStatNightsCaption = new System.Windows.Forms.Label();
            this.pnlStatSpent = new System.Windows.Forms.Panel();
            this.lblStatSpentIcon = new System.Windows.Forms.Label();
            this.lblStatSpentValue = new System.Windows.Forms.Label();
            this.lblStatSpentCaption = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblEmptyState = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatNights.SuspendLayout();
            this.pnlStatSpent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1286, 96);
            this.pnlHeader.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.picIcon.ForeColor = System.Drawing.Color.White;
            this.picIcon.Location = new System.Drawing.Point(26, 23);
            this.picIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(49, 51);
            this.picIcon.TabIndex = 0;
            this.picIcon.Text = "🕘";
            this.picIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Reservation History";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitle.Location = new System.Drawing.Point(87, 52);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(289, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Customer: —  •  ID: —  •  0 records";
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlStats.Controls.Add(this.pnlStatTotal);
            this.pnlStats.Controls.Add(this.pnlStatNights);
            this.pnlStats.Controls.Add(this.pnlStatSpent);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 96);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlStats.Size = new System.Drawing.Size(1286, 104);
            this.pnlStats.TabIndex = 1;
            // 
            // pnlStatTotal
            // 
            this.pnlStatTotal.BackColor = System.Drawing.Color.White;
            this.pnlStatTotal.Controls.Add(this.lblStatTotalIcon);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalValue);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalCaption);
            this.pnlStatTotal.Location = new System.Drawing.Point(24, 16);
            this.pnlStatTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatTotal.Name = "pnlStatTotal";
            this.pnlStatTotal.Size = new System.Drawing.Size(390, 80);
            this.pnlStatTotal.TabIndex = 0;
            this.pnlStatTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblStatTotalIcon
            // 
            this.lblStatTotalIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lblStatTotalIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatTotalIcon.Location = new System.Drawing.Point(18, 14);
            this.lblStatTotalIcon.Name = "lblStatTotalIcon";
            this.lblStatTotalIcon.Size = new System.Drawing.Size(44, 44);
            this.lblStatTotalIcon.TabIndex = 0;
            this.lblStatTotalIcon.Text = "📋";
            this.lblStatTotalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatTotalValue
            // 
            this.lblStatTotalValue.AutoSize = true;
            this.lblStatTotalValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStatTotalValue.Location = new System.Drawing.Point(70, 10);
            this.lblStatTotalValue.Name = "lblStatTotalValue";
            this.lblStatTotalValue.Size = new System.Drawing.Size(33, 38);
            this.lblStatTotalValue.TabIndex = 1;
            this.lblStatTotalValue.Text = "0";
            // 
            // lblStatTotalCaption
            // 
            this.lblStatTotalCaption.AutoSize = true;
            this.lblStatTotalCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatTotalCaption.Location = new System.Drawing.Point(72, 44);
            this.lblStatTotalCaption.Name = "lblStatTotalCaption";
            this.lblStatTotalCaption.Size = new System.Drawing.Size(135, 21);
            this.lblStatTotalCaption.TabIndex = 2;
            this.lblStatTotalCaption.Text = "Total Reservations";
            // 
            // pnlStatNights
            // 
            this.pnlStatNights.BackColor = System.Drawing.Color.White;
            this.pnlStatNights.Controls.Add(this.lblStatNightsIcon);
            this.pnlStatNights.Controls.Add(this.lblStatNightsValue);
            this.pnlStatNights.Controls.Add(this.lblStatNightsCaption);
            this.pnlStatNights.Location = new System.Drawing.Point(438, 16);
            this.pnlStatNights.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatNights.Name = "pnlStatNights";
            this.pnlStatNights.Size = new System.Drawing.Size(390, 80);
            this.pnlStatNights.TabIndex = 1;
            this.pnlStatNights.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblStatNightsIcon
            // 
            this.lblStatNightsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lblStatNightsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatNightsIcon.Location = new System.Drawing.Point(18, 14);
            this.lblStatNightsIcon.Name = "lblStatNightsIcon";
            this.lblStatNightsIcon.Size = new System.Drawing.Size(44, 44);
            this.lblStatNightsIcon.TabIndex = 0;
            this.lblStatNightsIcon.Text = "🌙";
            this.lblStatNightsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatNightsValue
            // 
            this.lblStatNightsValue.AutoSize = true;
            this.lblStatNightsValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatNightsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStatNightsValue.Location = new System.Drawing.Point(70, 10);
            this.lblStatNightsValue.Name = "lblStatNightsValue";
            this.lblStatNightsValue.Size = new System.Drawing.Size(33, 38);
            this.lblStatNightsValue.TabIndex = 1;
            this.lblStatNightsValue.Text = "0";
            // 
            // lblStatNightsCaption
            // 
            this.lblStatNightsCaption.AutoSize = true;
            this.lblStatNightsCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatNightsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatNightsCaption.Location = new System.Drawing.Point(72, 44);
            this.lblStatNightsCaption.Name = "lblStatNightsCaption";
            this.lblStatNightsCaption.Size = new System.Drawing.Size(92, 21);
            this.lblStatNightsCaption.TabIndex = 2;
            this.lblStatNightsCaption.Text = "Total Nights";
            // 
            // pnlStatSpent
            // 
            this.pnlStatSpent.BackColor = System.Drawing.Color.White;
            this.pnlStatSpent.Controls.Add(this.lblStatSpentIcon);
            this.pnlStatSpent.Controls.Add(this.lblStatSpentValue);
            this.pnlStatSpent.Controls.Add(this.lblStatSpentCaption);
            this.pnlStatSpent.Location = new System.Drawing.Point(852, 16);
            this.pnlStatSpent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatSpent.Name = "pnlStatSpent";
            this.pnlStatSpent.Size = new System.Drawing.Size(390, 80);
            this.pnlStatSpent.TabIndex = 2;
            this.pnlStatSpent.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblStatSpentIcon
            // 
            this.lblStatSpentIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lblStatSpentIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatSpentIcon.Location = new System.Drawing.Point(18, 14);
            this.lblStatSpentIcon.Name = "lblStatSpentIcon";
            this.lblStatSpentIcon.Size = new System.Drawing.Size(44, 44);
            this.lblStatSpentIcon.TabIndex = 0;
            this.lblStatSpentIcon.Text = "💳";
            this.lblStatSpentIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatSpentValue
            // 
            this.lblStatSpentValue.AutoSize = true;
            this.lblStatSpentValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatSpentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStatSpentValue.Location = new System.Drawing.Point(70, 10);
            this.lblStatSpentValue.Name = "lblStatSpentValue";
            this.lblStatSpentValue.Size = new System.Drawing.Size(73, 38);
            this.lblStatSpentValue.TabIndex = 1;
            this.lblStatSpentValue.Text = "0.00";
            // 
            // lblStatSpentCaption
            // 
            this.lblStatSpentCaption.AutoSize = true;
            this.lblStatSpentCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatSpentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatSpentCaption.Location = new System.Drawing.Point(72, 45);
            this.lblStatSpentCaption.Name = "lblStatSpentCaption";
            this.lblStatSpentCaption.Size = new System.Drawing.Size(86, 21);
            this.lblStatSpentCaption.TabIndex = 2;
            this.lblStatSpentCaption.Text = "Total Spent";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeight = 40;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.dgvHistory.Location = new System.Drawing.Point(0, 200);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 40;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1286, 637);
            this.dgvHistory.TabIndex = 2;
            // 
            // lblEmptyState
            // 
            this.lblEmptyState.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmptyState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEmptyState.Location = new System.Drawing.Point(0, 260);
            this.lblEmptyState.Name = "lblEmptyState";
            this.lblEmptyState.Size = new System.Drawing.Size(1286, 60);
            this.lblEmptyState.TabIndex = 3;
            this.lblEmptyState.Text = "No reservation history found for this customer.";
            this.lblEmptyState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyState.Visible = false;
            // 
            // UcReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblEmptyState);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcReservationHistory";
            this.Size = new System.Drawing.Size(1286, 837);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatTotal.PerformLayout();
            this.pnlStatNights.ResumeLayout(false);
            this.pnlStatNights.PerformLayout();
            this.pnlStatSpent.ResumeLayout(false);
            this.pnlStatSpent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Label lblStatTotalIcon;
        private System.Windows.Forms.Label lblStatTotalValue;
        private System.Windows.Forms.Label lblStatTotalCaption;
        private System.Windows.Forms.Panel pnlStatNights;
        private System.Windows.Forms.Label lblStatNightsIcon;
        private System.Windows.Forms.Label lblStatNightsValue;
        private System.Windows.Forms.Label lblStatNightsCaption;
        private System.Windows.Forms.Panel pnlStatSpent;
        private System.Windows.Forms.Label lblStatSpentIcon;
        private System.Windows.Forms.Label lblStatSpentValue;
        private System.Windows.Forms.Label lblStatSpentCaption;

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblEmptyState;
    }
}