namespace HMS.reservations
{
    partial class FrmReservationHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if disposing managed resources should be disposed; otherwise, false.</param>
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
            this.ucReservationHistory1 = new HMS.reservations.UcReservationHistory();
            this.SuspendLayout();
            // 
            // ucReservationHistory1
            // 
            this.ucReservationHistory1.BackColor = System.Drawing.Color.White;
            this.ucReservationHistory1.Location = new System.Drawing.Point(3, 0);
            this.ucReservationHistory1.Margin = new System.Windows.Forms.Padding(4);
            this.ucReservationHistory1.Name = "ucReservationHistory1";
            this.ucReservationHistory1.Size = new System.Drawing.Size(1286, 837);
            this.ucReservationHistory1.TabIndex = 0;
            // 
            // FrmReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1291, 840);

            this.Controls.Add(this.ucReservationHistory1);

            this.Name = "FrmReservationHistory";
            this.Text = "Reservation History";

            // Disable minimize and maximize buttons
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Prevent resizing
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // Open form in the center of the screen
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Load += new System.EventHandler(this.FrmReservationHistory_Load);

            this.ResumeLayout(false);
        }

        #endregion

        private UcReservationHistory ucReservationHistory1;
    }
}