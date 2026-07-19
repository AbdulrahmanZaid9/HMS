namespace HMS.ServicesBooking
{
    partial class FrmEditServiceBooking
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
            this.ucEditServiceBooking1 = new HMS.ServicesBooking.UcEditServiceBooking();
            this.SuspendLayout();
            // 
            // ucEditServiceBooking1
            // 
            this.ucEditServiceBooking1.BackColor = System.Drawing.Color.White;
            this.ucEditServiceBooking1.Location = new System.Drawing.Point(1, 2);
            this.ucEditServiceBooking1.Margin = new System.Windows.Forms.Padding(4);
            this.ucEditServiceBooking1.Name = "ucEditServiceBooking1";
            this.ucEditServiceBooking1.Size = new System.Drawing.Size(560, 400);
            this.ucEditServiceBooking1.TabIndex = 0;
            // 
            // FrmEditServiceBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 404);
            this.Controls.Add(this.ucEditServiceBooking1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            this.Name = "FrmEditServiceBooking";
            this.Text = "Edit Service Booking";
            this.ResumeLayout(false);
        }

        #endregion

        private UcEditServiceBooking ucEditServiceBooking1;
    }
}