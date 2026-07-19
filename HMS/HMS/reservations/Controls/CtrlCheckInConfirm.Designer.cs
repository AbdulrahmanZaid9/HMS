namespace HMS.reservations.Controls
{
    partial class CtrlCheckInConfirm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmCheckIn = new System.Windows.Forms.Button();
            this.ctrlSummary = new HMS.reservations.Controls.CtrlCheckInSummary();
            this.ctrlSecurityDeposit1 = new HMS.reservations.Controls.CtrlSecurityDeposit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInfo.Location = new System.Drawing.Point(0, 422);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(480, 56);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "This will mark the reservation as Checked-In and set the room status to Occupied." +
    "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCancel.Location = new System.Drawing.Point(180, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmCheckIn
            // 
            this.btnConfirmCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnConfirmCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckIn.FlatAppearance.BorderSize = 0;
            this.btnConfirmCheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.btnConfirmCheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(63)))));
            this.btnConfirmCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCheckIn.Location = new System.Drawing.Point(292, 486);
            this.btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            this.btnConfirmCheckIn.Size = new System.Drawing.Size(172, 40);
            this.btnConfirmCheckIn.TabIndex = 4;
            this.btnConfirmCheckIn.Text = "→]  Confirm Check-In";
            this.btnConfirmCheckIn.UseVisualStyleBackColor = false;
            this.btnConfirmCheckIn.Click += new System.EventHandler(this.btnConfirmCheckIn_Click);
            // 
            // ctrlSummary
            // 
            this.ctrlSummary.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSummary.Location = new System.Drawing.Point(0, 0);
            this.ctrlSummary.Name = "ctrlSummary";
            this.ctrlSummary.Size = new System.Drawing.Size(480, 290);
            this.ctrlSummary.TabIndex = 0;
            // 
            // ctrlSecurityDeposit1
            // 
            this.ctrlSecurityDeposit1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlSecurityDeposit1.Enabled = false;
            this.ctrlSecurityDeposit1.Location = new System.Drawing.Point(1, 304);
            this.ctrlSecurityDeposit1.Name = "ctrlSecurityDeposit1";
            this.ctrlSecurityDeposit1.Size = new System.Drawing.Size(480, 100);
            this.ctrlSecurityDeposit1.TabIndex = 5;
            // 
            // CtrlCheckInConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.ctrlSummary);
            this.Controls.Add(this.ctrlSecurityDeposit1);
            this.Controls.Add(this.btnConfirmCheckIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInfo);
            this.Name = "CtrlCheckInConfirm";
            this.Size = new System.Drawing.Size(480, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlCheckInSummary ctrlSummary;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmCheckIn;
        private CtrlSecurityDeposit ctrlSecurityDeposit1;
    }
}