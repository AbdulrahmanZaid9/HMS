namespace HMS.reservations
{
    partial class FrmCurrentReservation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ctrlCurrentReservation1 = new HMS.reservations.Controls.CtrlCurrentReservation();
            this.SuspendLayout();
            // 
            // ctrlCurrentReservation1
            // 
            this.ctrlCurrentReservation1.BackColor = System.Drawing.Color.White;
            this.ctrlCurrentReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCurrentReservation1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCurrentReservation1.Name = "ctrlCurrentReservation1";
            this.ctrlCurrentReservation1.Size = new System.Drawing.Size(700, 673);
            this.ctrlCurrentReservation1.TabIndex = 0;
            // 
            // FrmCurrentReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 673);
            this.Controls.Add(this.ctrlCurrentReservation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCurrentReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current Reservation — Grand Palace HMS";
            this.ResumeLayout(false);

        }

        #endregion

        private HMS.reservations.Controls.CtrlCurrentReservation ctrlCurrentReservation1;
    }
}