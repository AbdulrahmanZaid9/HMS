using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class FrmRoom
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar.SuspendLayout();
            this.pnlFilterBar.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1100, 70);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room Management";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(68, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "???????";
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFilterBar.Controls.Add(this.pnlSearchBox);
            this.pnlFilterBar.Controls.Add(this.cmbStatus);
            this.pnlFilterBar.Controls.Add(this.cmbType);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(0, 70);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(1100, 56);
            this.pnlFilterBar.TabIndex = 1;
            this.pnlFilterBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilterBar_Paint);
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.BackColor = System.Drawing.Color.White;
            this.pnlSearchBox.Controls.Add(this.lblSearchIcon);
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Location = new System.Drawing.Point(24, 12);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(680, 32);
            this.pnlSearchBox.TabIndex = 4;
            this.pnlSearchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchBox_Paint);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(6, 4);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(24, 24);
            this.lblSearchIcon.TabIndex = 4;
            this.lblSearchIcon.Text = "🔍";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txtSearch.Location = new System.Drawing.Point(36, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search by room number";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cmbStatus.Location = new System.Drawing.Point(720, 13);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(170, 33);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cmbType.Location = new System.Drawing.Point(902, 13);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(170, 33);
            this.cmbType.TabIndex = 2;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlCards.Controls.Add(this.flowCards);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCards.Location = new System.Drawing.Point(0, 126);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1100, 634);
            this.pnlCards.TabIndex = 2;
            // 
            // flowCards
            // 
            this.flowCards.AutoScroll = true;
            this.flowCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCards.Location = new System.Drawing.Point(0, 0);
            this.flowCards.Name = "flowCards";
            this.flowCards.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.flowCards.Size = new System.Drawing.Size(1100, 634);
            this.flowCards.TabIndex = 4;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlFilterBar);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Palace — Room Management";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.Shown += new System.EventHandler(this.FrmRoom_Shown);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel pnlCards;
        private FlowLayoutPanel flowCards;
    }
}