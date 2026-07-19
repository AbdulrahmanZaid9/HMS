namespace HMS.reservations.Controls
{
    partial class CtrlBillSummary
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblItemCountBadge = new System.Windows.Forms.Label();
            this.pnlDividerTop = new System.Windows.Forms.Panel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.chkIncludeDeposit = new System.Windows.Forms.CheckBox();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlDividerActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblFooterNote = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCard.Controls.Add(this.lblHeaderTitle);
            this.pnlCard.Controls.Add(this.lblItemCountBadge);
            this.pnlCard.Controls.Add(this.pnlDividerTop);
            this.pnlCard.Controls.Add(this.flpItems);
            this.pnlCard.Controls.Add(this.chkIncludeDeposit);
            this.pnlCard.Controls.Add(this.pnlDivider);
            this.pnlCard.Controls.Add(this.lblTotalCaption);
            this.pnlCard.Controls.Add(this.lblTotalValue);
            this.pnlCard.Controls.Add(this.pnlDividerActions);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.Controls.Add(this.btnConfirm);
            this.pnlCard.Controls.Add(this.lblFooterNote);
            this.pnlCard.Controls.Add(this.lblBillID);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(480, 260);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 14);
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
            this.lblItemCountBadge.Location = new System.Drawing.Point(16, 40);
            this.lblItemCountBadge.Name = "lblItemCountBadge";
            this.lblItemCountBadge.Size = new System.Drawing.Size(448, 18);
            this.lblItemCountBadge.TabIndex = 6;
            this.lblItemCountBadge.Text = "-- 0 items --";
            this.lblItemCountBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDividerTop
            // 
            this.pnlDividerTop.Location = new System.Drawing.Point(16, 62);
            this.pnlDividerTop.Name = "pnlDividerTop";
            this.pnlDividerTop.Size = new System.Drawing.Size(448, 10);
            this.pnlDividerTop.TabIndex = 9;
            this.pnlDividerTop.Paint += new System.Windows.Forms.PaintEventHandler(this.Divider_Paint);
            // 
            // flpItems
            // 
            this.flpItems.AutoSize = true;
            this.flpItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItems.Location = new System.Drawing.Point(16, 76);
            this.flpItems.Margin = new System.Windows.Forms.Padding(0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(0, 0);
            this.flpItems.TabIndex = 2;
            this.flpItems.WrapContents = false;
            // 
            // chkIncludeDeposit
            // 
            this.chkIncludeDeposit.AutoSize = true;
            this.chkIncludeDeposit.Checked = true;
            this.chkIncludeDeposit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIncludeDeposit.Font = new System.Drawing.Font("Consolas", 9F);
            this.chkIncludeDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.chkIncludeDeposit.Location = new System.Drawing.Point(16, 90);
            this.chkIncludeDeposit.Name = "chkIncludeDeposit";
            this.chkIncludeDeposit.Size = new System.Drawing.Size(266, 26);
            this.chkIncludeDeposit.TabIndex = 8;
            this.chkIncludeDeposit.Text = "return Security Deposit";
            this.chkIncludeDeposit.UseVisualStyleBackColor = true;
            this.chkIncludeDeposit.CheckedChanged += new System.EventHandler(this.chkIncludeDeposit_CheckedChanged);
            // 
            // pnlDivider
            // 
            this.pnlDivider.Location = new System.Drawing.Point(16, 116);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(448, 10);
            this.pnlDivider.TabIndex = 3;
            this.pnlDivider.Paint += new System.Windows.Forms.PaintEventHandler(this.Divider_Paint);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 130);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(150, 28);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "TOTAL";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblTotalValue.Location = new System.Drawing.Point(204, 126);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(260, 34);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDividerActions
            // 
            this.pnlDividerActions.Location = new System.Drawing.Point(16, 168);
            this.pnlDividerActions.Name = "pnlDividerActions";
            this.pnlDividerActions.Size = new System.Drawing.Size(448, 10);
            this.pnlDividerActions.TabIndex = 10;
            this.pnlDividerActions.Paint += new System.Windows.Forms.PaintEventHandler(this.Divider_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCancel.Location = new System.Drawing.Point(16, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(248, 182);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(216, 36);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblFooterNote
            // 
            this.lblFooterNote.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblFooterNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFooterNote.Location = new System.Drawing.Point(16, 226);
            this.lblFooterNote.Name = "lblFooterNote";
            this.lblFooterNote.Size = new System.Drawing.Size(448, 20);
            this.lblFooterNote.TabIndex = 7;
            this.lblFooterNote.Visible = false;
            // 
            // lblBillID
            // 
            this.lblBillID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.lblBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBillID.Location = new System.Drawing.Point(16, 2);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(448, 16);
            this.lblBillID.TabIndex = 13;
            this.lblBillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtrlBillSummary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "CtrlBillSummary";
            this.Size = new System.Drawing.Size(480, 260);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblItemCountBadge;
        private System.Windows.Forms.Panel pnlDividerTop;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.CheckBox chkIncludeDeposit;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlDividerActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblFooterNote;
        private System.Windows.Forms.Label lblBillID;

    }
}