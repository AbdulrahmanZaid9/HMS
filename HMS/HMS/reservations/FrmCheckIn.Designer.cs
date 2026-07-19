namespace HMS.reservations
{
    partial class FrmCheckIn
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
            this.ctrlCheckInConfirm1 = new HMS.reservations.Controls.CtrlCheckInConfirm();
            this.SuspendLayout();
            // 
            // ctrlCheckInConfirm1
            // 
            this.ctrlCheckInConfirm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));

            this.ctrlCheckInConfirm1.Location = new System.Drawing.Point(7, 5);
            this.ctrlCheckInConfirm1.Name = "ctrlCheckInConfirm1";
            this.ctrlCheckInConfirm1.Size = new System.Drawing.Size(480, 526);
            this.ctrlCheckInConfirm1.TabIndex = 0;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 535);
            this.Controls.Add(this.ctrlCheckInConfirm1);

            // Disable Maximize and Minimize
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Open the form in the center of the screen
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // (Optional) Prevent resizing completely
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.Name = "FrmCheckIn";
            this.Text = "FrmCheckIn";
            this.ResumeLayout(false);
        }

        #endregion

        private Controls.CtrlCheckInConfirm ctrlCheckInConfirm1;
    }
}