namespace HMS.Users
{
    partial class FrmViewProfile
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
            this.ctrlViewUserProfile1 = new HMS.Users.Controls.CtrlViewUserProfile();
            this.SuspendLayout();
            // 
            // ctrlViewUserProfile1
            // 
            this.ctrlViewUserProfile1.BackColor = System.Drawing.Color.White;
            this.ctrlViewUserProfile1.Location = new System.Drawing.Point(3, 3);
            this.ctrlViewUserProfile1.Name = "ctrlViewUserProfile1";
            this.ctrlViewUserProfile1.Size = new System.Drawing.Size(680, 510);
            this.ctrlViewUserProfile1.TabIndex = 0;
            // 
            // FrmViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 519);
            this.Controls.Add(this.ctrlViewUserProfile1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewProfile";
            this.Text = "FrmViewProfile";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtrlViewUserProfile ctrlViewUserProfile1;
    }
}