namespace HMS.Customers
{
    partial class FrmViewCustomerInfo
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
            this.ctrlViewCusomterProfile1 = new HMS.Customers.Controls.CtrlViewCusomterProfile();
            this.SuspendLayout();
            // 
            // ctrlViewCusomterProfile1
            // 
            this.ctrlViewCusomterProfile1.BackColor = System.Drawing.Color.White;
            this.ctrlViewCusomterProfile1.Location = new System.Drawing.Point(-1, 1);
            this.ctrlViewCusomterProfile1.Name = "ctrlViewCusomterProfile1";
            this.ctrlViewCusomterProfile1.Size = new System.Drawing.Size(680, 446);
            this.ctrlViewCusomterProfile1.TabIndex = 0;
            // 
            // FrmViewCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 452);
            this.Controls.Add(this.ctrlViewCusomterProfile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Profile — Grand Palace HMS";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtrlViewCusomterProfile ctrlViewCusomterProfile1;
    }
}