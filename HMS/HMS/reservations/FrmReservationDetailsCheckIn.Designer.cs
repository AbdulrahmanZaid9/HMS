namespace HMS.reservations
{
    partial class FrmReservationDetailsCheckIn
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
            this.ctrlReservationOverview1 = new HMS.reservations.Controls.CtrlReservationOverview();
            this.SuspendLayout();
            // 
            // ctrlReservationOverview1
            // 
            this.ctrlReservationOverview1.AutoScroll = true;
            this.ctrlReservationOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ctrlReservationOverview1.Location = new System.Drawing.Point(5, 4);
            this.ctrlReservationOverview1.Name = "ctrlReservationOverview1";
            this.ctrlReservationOverview1.Size = new System.Drawing.Size(969, 770);
            this.ctrlReservationOverview1.TabIndex = 0;
            // 
            // FrmReservationDetailsCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(977, 789);
            this.Controls.Add(this.ctrlReservationOverview1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservationDetailsCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservationDetails";
            this.ResumeLayout(false);

        }
        #endregion

        private Controls.CtrlReservationOverview ctrlReservationOverview1;
    }
}