namespace HMS.reservations.Controls
{
    partial class CtrlSecurityDeposit
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
            this.picShieldIcon = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblDepositCaption = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlCard.Controls.Add(this.txtDepositAmount);
            this.pnlCard.Controls.Add(this.picShieldIcon);
            this.pnlCard.Controls.Add(this.lblHeaderTitle);
            this.pnlCard.Controls.Add(this.lblDepositCaption);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(480, 100);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // picShieldIcon
            // 
            this.picShieldIcon.Location = new System.Drawing.Point(16, 16);
            this.picShieldIcon.Name = "picShieldIcon";
            this.picShieldIcon.Size = new System.Drawing.Size(22, 22);
            this.picShieldIcon.TabIndex = 0;
            this.picShieldIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.picShieldIcon_Paint);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(46, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(183, 30);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Security Deposit";
            // 
            // lblDepositCaption
            // 
            this.lblDepositCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDepositCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblDepositCaption.Location = new System.Drawing.Point(16, 58);
            this.lblDepositCaption.Name = "lblDepositCaption";
            this.lblDepositCaption.Size = new System.Drawing.Size(146, 32);
            this.lblDepositCaption.TabIndex = 2;
            this.lblDepositCaption.Text = "Deposit Amount ($)";
            this.lblDepositCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(104, 56);
            this.txtDepositAmount.Multiline = true;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(247, 32);
            this.txtDepositAmount.TabIndex = 3;
            this.txtDepositAmount.Text = "100";
            // 
            // CtrlSecurityDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "CtrlSecurityDeposit";
            this.Size = new System.Drawing.Size(480, 100);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel picShieldIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblDepositCaption;
        private System.Windows.Forms.TextBox txtDepositAmount;
    }
}