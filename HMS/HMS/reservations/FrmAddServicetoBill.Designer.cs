namespace HMS.reservations
{
    partial class FrmAddServicetoBill
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
            this.ctrlAddServiceToBill1 = new HMS.reservations.Controls.CtrlAddServiceToBill();
            this.SuspendLayout();
            // 
            // ctrlAddServiceToBill1
            // 
            this.ctrlAddServiceToBill1.AutoScroll = true;
            this.ctrlAddServiceToBill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ctrlAddServiceToBill1.Location = new System.Drawing.Point(4, 3);
            this.ctrlAddServiceToBill1.Name = "ctrlAddServiceToBill1";
            this.ctrlAddServiceToBill1.Size = new System.Drawing.Size(880, 630);
            this.ctrlAddServiceToBill1.TabIndex = 0;
            // 
            // FrmAddServicetoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 643);
            this.Controls.Add(this.ctrlAddServiceToBill1);

            // Form Settings
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.Name = "FrmAddServicetoBill";
            this.Text = "Add Services to Bill";
            this.ResumeLayout(false);
        }

        #endregion

        private Controls.CtrlAddServiceToBill ctrlAddServiceToBill1;
    }
}