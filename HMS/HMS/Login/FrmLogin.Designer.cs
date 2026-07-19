using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HMS.Login
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlIconBox = new System.Windows.Forms.Panel();
            this.lblHotelIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUsernameBorder = new System.Windows.Forms.Panel();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPasswordBorder = new System.Windows.Forms.Panel();
            this.lblLockIcon = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEye = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlIconBox.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlUsernameBorder.SuspendLayout();
            this.pnlPasswordBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.pnlBody);
            this.pnlCard.Location = new System.Drawing.Point(395, 145);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(310, 460);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.pnlIconBox);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(310, 160);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlIconBox
            // 
            this.pnlIconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlIconBox.Controls.Add(this.lblHotelIcon);
            this.pnlIconBox.Location = new System.Drawing.Point(128, 22);
            this.pnlIconBox.Name = "pnlIconBox";
            this.pnlIconBox.Size = new System.Drawing.Size(54, 54);
            this.pnlIconBox.TabIndex = 0;
            // 
            // lblHotelIcon
            // 
            this.lblHotelIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblHotelIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblHotelIcon.Location = new System.Drawing.Point(5, 5);
            this.lblHotelIcon.Name = "lblHotelIcon";
            this.lblHotelIcon.Size = new System.Drawing.Size(44, 44);
            this.lblHotelIcon.TabIndex = 0;
            this.lblHotelIcon.Text = "🏢";
            this.lblHotelIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(97, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Grand Palace";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(88, 116);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(227, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Hotel Management System";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblStaffLogin);
            this.pnlBody.Controls.Add(this.lblUsername);
            this.pnlBody.Controls.Add(this.pnlUsernameBorder);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.pnlPasswordBorder);
            this.pnlBody.Controls.Add(this.chkRememberMe);
            this.pnlBody.Controls.Add(this.btnSignIn);
            this.pnlBody.Controls.Add(this.lblVersion);
            this.pnlBody.Location = new System.Drawing.Point(0, 160);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(310, 300);
            this.pnlBody.TabIndex = 1;
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStaffLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStaffLogin.Location = new System.Drawing.Point(105, 18);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(148, 36);
            this.lblStaffLogin.TabIndex = 0;
            this.lblStaffLogin.Text = "Staff Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblUsername.Location = new System.Drawing.Point(28, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pnlUsernameBorder
            // 
            this.pnlUsernameBorder.BackColor = System.Drawing.Color.White;
            this.pnlUsernameBorder.Controls.Add(this.lblUserIcon);
            this.pnlUsernameBorder.Controls.Add(this.txtUsername);
            this.pnlUsernameBorder.Location = new System.Drawing.Point(28, 72);
            this.pnlUsernameBorder.Name = "pnlUsernameBorder";
            this.pnlUsernameBorder.Size = new System.Drawing.Size(254, 40);
            this.pnlUsernameBorder.TabIndex = 2;
            this.pnlUsernameBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUsernameBorder_Paint);
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUserIcon.Location = new System.Drawing.Point(6, 2);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(28, 36);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtUsername.Location = new System.Drawing.Point(38, 11);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPassword.Location = new System.Drawing.Point(28, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // pnlPasswordBorder
            // 
            this.pnlPasswordBorder.BackColor = System.Drawing.Color.White;
            this.pnlPasswordBorder.Controls.Add(this.lblLockIcon);
            this.pnlPasswordBorder.Controls.Add(this.txtPassword);
            this.pnlPasswordBorder.Controls.Add(this.lblEye);
            this.pnlPasswordBorder.Location = new System.Drawing.Point(28, 143);
            this.pnlPasswordBorder.Name = "pnlPasswordBorder";
            this.pnlPasswordBorder.Size = new System.Drawing.Size(254, 40);
            this.pnlPasswordBorder.TabIndex = 4;
            this.pnlPasswordBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPasswordBorder_Paint);
            // 
            // lblLockIcon
            // 
            this.lblLockIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblLockIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblLockIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLockIcon.Location = new System.Drawing.Point(6, 2);
            this.lblLockIcon.Name = "lblLockIcon";
            this.lblLockIcon.Size = new System.Drawing.Size(28, 36);
            this.lblLockIcon.TabIndex = 0;
            this.lblLockIcon.Text = "🔒";
            this.lblLockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.Location = new System.Drawing.Point(38, 11);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblEye
            // 
            this.lblEye.BackColor = System.Drawing.Color.Transparent;
            this.lblEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblEye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEye.Location = new System.Drawing.Point(226, 2);
            this.lblEye.Name = "lblEye";
            this.lblEye.Size = new System.Drawing.Size(24, 36);
            this.lblEye.TabIndex = 2;
            this.lblEye.Text = "👁";
            this.lblEye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEye.Click += new System.EventHandler(this.lblEye_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.White;
            this.chkRememberMe.Checked = true;
            this.chkRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.chkRememberMe.Location = new System.Drawing.Point(28, 194);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(204, 29);
            this.chkRememberMe.TabIndex = 5;
            this.chkRememberMe.Text = "Remember Password";
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(28, 228);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(254, 42);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVersion.Location = new System.Drawing.Point(48, 278);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(309, 20);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Grand Palace Hotel Management System v1.0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Palace HMS";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlIconBox.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlUsernameBorder.ResumeLayout(false);
            this.pnlUsernameBorder.PerformLayout();
            this.pnlPasswordBorder.ResumeLayout(false);
            this.pnlPasswordBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pnlUsernameBorder_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(220, 224, 232), 1.5f))
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlUsernameBorder.Width - 1, this.pnlUsernameBorder.Height - 1);
        }

        private void pnlPasswordBorder_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.FromArgb(220, 224, 232), 1.5f))
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlPasswordBorder.Width - 1, this.pnlPasswordBorder.Height - 1);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlIconBox;
        private System.Windows.Forms.Label lblHotelIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblStaffLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsernameBorder;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPasswordBorder;
        private System.Windows.Forms.Label lblLockIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEye;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblVersion;
        private ErrorProvider errorProvider1;
    }
}