namespace HMS.reservations
{
    partial class FrmCheckOut
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

            this.ctrlBillSummary1 = new HMS.reservations.Controls.CtrlBillSummary();
            this.SuspendLayout();
            // 
            // ctrlBillSummary1
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ctrlBillSummary1.AutoScroll = false;
            this.ctrlBillSummary1.AutoSize = true;
            this.ctrlBillSummary1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlBillSummary1.Location = new System.Drawing.Point(6, 6);
            this.ctrlBillSummary1.Name = "ctrlBillSummary1";
            this.ctrlBillSummary1.TabIndex = 0;
            // NOTE: no explicit Size assignment here. CtrlBillSummary's own
            // constructor already computes its real width/height once all the
            // line items are added. Overwriting it here with a hardcoded value
            // (as before) stomped that correct size with a stale one, which is
            // what caused the sizing/gap problems.
            // 
            // FrmCheckOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = false;
            this.AutoSize = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.Add(this.ctrlBillSummary1);
            this.Name = "FrmCheckOut";
            this.Text = "FrmCheckOut";
            // Size the window exactly to the control's real, already-computed
            // bounds instead of trusting Form AutoSize to guess it correctly.
            this.ClientSize = new System.Drawing.Size(
                this.ctrlBillSummary1.Right + 6,
                this.ctrlBillSummary1.Bottom + 6);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlBillSummary ctrlBillSummary1;
    }
}