using System.Windows.Forms;

namespace HMS.reservations
{
    partial class FrmReservationDetailsCheckOut
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 778);
            this.Controls.Add(this.ctrlReservationOverview1);

            // New properties
            this.MaximizeBox = false;                      // Disable maximize button
            this.MinimizeBox = false;                      // Disable minimize button
            this.StartPosition = FormStartPosition.CenterScreen; // Open in the center
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Prevent resizing

            this.Name = "FrmReservationDetailsCheckOut";
            this.Text = "Reservation Details";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtrlReservationOverview ctrlReservationOverview1;
    }
}