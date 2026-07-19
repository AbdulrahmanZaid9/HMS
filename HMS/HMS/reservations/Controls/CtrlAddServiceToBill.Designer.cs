namespace HMS.reservations.Controls
{
    partial class CtrlAddServiceToBill
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustIdBadge = new System.Windows.Forms.Label();
            this.lblBillIdBadge = new System.Windows.Forms.Label();
            this.lblSelectedCountBadge = new System.Windows.Forms.Label();
            this.pnlServices = new System.Windows.Forms.Panel();
            this.lblServicesSectionHeader = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryHeader = new System.Windows.Forms.Label();
            this.lblSelectedIcon = new System.Windows.Forms.Label();
            this.lblSelectedCaption = new System.Windows.Forms.Label();
            this.lblSelectedServices = new System.Windows.Forms.Label();
            this.lblTotalIcon = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalSelectedPrice = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ResverstaionID = new System.Windows.Forms.Label();
            this.BillID = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.BillID);
            this.pnlHeader.Controls.Add(this.ResverstaionID);
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblCustomerName);
            this.pnlHeader.Controls.Add(this.lblCustIdBadge);
            this.pnlHeader.Controls.Add(this.lblBillIdBadge);
            this.pnlHeader.Controls.Add(this.lblSelectedCountBadge);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.picIcon.ForeColor = System.Drawing.Color.White;
            this.picIcon.Location = new System.Drawing.Point(14, 10);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(36, 38);
            this.picIcon.TabIndex = 0;
            this.picIcon.Text = "🛎";
            this.picIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(56, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Service to Bill";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoEllipsis = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCustomerName.Location = new System.Drawing.Point(58, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(150, 20);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Emma Wilson";
            // 
            // lblCustIdBadge
            // 
            this.lblCustIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCustIdBadge.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblCustIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblCustIdBadge.Location = new System.Drawing.Point(205, 36);
            this.lblCustIdBadge.Name = "lblCustIdBadge";
            this.lblCustIdBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblCustIdBadge.Size = new System.Drawing.Size(73, 23);
            this.lblCustIdBadge.TabIndex = 3;
            this.lblCustIdBadge.Text = "RES #";
            this.lblCustIdBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillIdBadge
            // 
            this.lblBillIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblBillIdBadge.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblBillIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblBillIdBadge.Location = new System.Drawing.Point(391, 34);
            this.lblBillIdBadge.Name = "lblBillIdBadge";
            this.lblBillIdBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblBillIdBadge.Size = new System.Drawing.Size(100, 23);
            this.lblBillIdBadge.TabIndex = 4;
            this.lblBillIdBadge.Text = "BILL #";
            this.lblBillIdBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedCountBadge
            // 
            this.lblSelectedCountBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedCountBadge.AutoSize = true;
            this.lblSelectedCountBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblSelectedCountBadge.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(247)))), ((int)(((byte)(208)))));
            this.lblSelectedCountBadge.Location = new System.Drawing.Point(750, 16);
            this.lblSelectedCountBadge.Name = "lblSelectedCountBadge";
            this.lblSelectedCountBadge.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblSelectedCountBadge.Size = new System.Drawing.Size(100, 28);
            this.lblSelectedCountBadge.TabIndex = 5;
            this.lblSelectedCountBadge.Text = "3 Selected";
            // 
            // pnlServices
            // 
            this.pnlServices.BackColor = System.Drawing.Color.White;
            this.pnlServices.Controls.Add(this.lblServicesSectionHeader);
            this.pnlServices.Controls.Add(this.txtSearch);
            this.pnlServices.Controls.Add(this.lblSearchIcon);
            this.pnlServices.Controls.Add(this.cmbCategoryFilter);
            this.pnlServices.Controls.Add(this.dgvServices);
            this.pnlServices.Location = new System.Drawing.Point(0, 60);
            this.pnlServices.Name = "pnlServices";
            this.pnlServices.Size = new System.Drawing.Size(880, 420);
            this.pnlServices.TabIndex = 1;
            // 
            // lblServicesSectionHeader
            // 
            this.lblServicesSectionHeader.AutoSize = true;
            this.lblServicesSectionHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblServicesSectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblServicesSectionHeader.Location = new System.Drawing.Point(16, 10);
            this.lblServicesSectionHeader.Name = "lblServicesSectionHeader";
            this.lblServicesSectionHeader.Size = new System.Drawing.Size(159, 20);
            this.lblServicesSectionHeader.TabIndex = 0;
            this.lblServicesSectionHeader.Text = "AVAILABLE SERVICES";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtSearch.Location = new System.Drawing.Point(415, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search by name ...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(377, 8);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(20, 24);
            this.lblSearchIcon.TabIndex = 1;
            this.lblSearchIcon.Text = "🔍";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(649, 7);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(211, 31);
            this.cmbCategoryFilter.TabIndex = 3;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServices.ColumnHeadersHeight = 34;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.dgvServices.Location = new System.Drawing.Point(16, 40);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 62;
            this.dgvServices.RowTemplate.Height = 30;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(848, 370);
            this.dgvServices.TabIndex = 4;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.MinimumWidth = 8;
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 40;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlSummary.Controls.Add(this.lblSummaryHeader);
            this.pnlSummary.Controls.Add(this.lblSelectedIcon);
            this.pnlSummary.Controls.Add(this.lblSelectedCaption);
            this.pnlSummary.Controls.Add(this.lblSelectedServices);
            this.pnlSummary.Controls.Add(this.lblTotalIcon);
            this.pnlSummary.Controls.Add(this.lblTotalCaption);
            this.pnlSummary.Controls.Add(this.lblTotalSelectedPrice);
            this.pnlSummary.Location = new System.Drawing.Point(0, 480);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(880, 90);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblSummaryHeader
            // 
            this.lblSummaryHeader.AutoSize = true;
            this.lblSummaryHeader.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSummaryHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSummaryHeader.Location = new System.Drawing.Point(16, 8);
            this.lblSummaryHeader.Name = "lblSummaryHeader";
            this.lblSummaryHeader.Size = new System.Drawing.Size(168, 20);
            this.lblSummaryHeader.TabIndex = 0;
            this.lblSummaryHeader.Text = "SELECTION SUMMARY";
            // 
            // lblSelectedIcon
            // 
            this.lblSelectedIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.lblSelectedIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSelectedIcon.Location = new System.Drawing.Point(16, 40);
            this.lblSelectedIcon.Name = "lblSelectedIcon";
            this.lblSelectedIcon.Size = new System.Drawing.Size(20, 20);
            this.lblSelectedIcon.TabIndex = 1;
            this.lblSelectedIcon.Text = "✅";
            this.lblSelectedIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedCaption
            // 
            this.lblSelectedCaption.AutoSize = true;
            this.lblSelectedCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSelectedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSelectedCaption.Location = new System.Drawing.Point(40, 43);
            this.lblSelectedCaption.Name = "lblSelectedCaption";
            this.lblSelectedCaption.Size = new System.Drawing.Size(129, 21);
            this.lblSelectedCaption.TabIndex = 2;
            this.lblSelectedCaption.Text = "Services Selected";
            // 
            // lblSelectedServices
            // 
            this.lblSelectedServices.AutoEllipsis = true;
            this.lblSelectedServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSelectedServices.Location = new System.Drawing.Point(16, 64);
            this.lblSelectedServices.Name = "lblSelectedServices";
            this.lblSelectedServices.Size = new System.Drawing.Size(200, 22);
            this.lblSelectedServices.TabIndex = 3;
            this.lblSelectedServices.Text = "3 Services";
            // 
            // lblTotalIcon
            // 
            this.lblTotalIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.lblTotalIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalIcon.Location = new System.Drawing.Point(737, 34);
            this.lblTotalIcon.Name = "lblTotalIcon";
            this.lblTotalIcon.Size = new System.Drawing.Size(20, 20);
            this.lblTotalIcon.TabIndex = 4;
            this.lblTotalIcon.Text = "💰";
            this.lblTotalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(761, 36);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCaption.TabIndex = 5;
            this.lblTotalCaption.Text = "Total Price";
            // 
            // lblTotalSelectedPrice
            // 
            this.lblTotalSelectedPrice.AutoEllipsis = true;
            this.lblTotalSelectedPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalSelectedPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblTotalSelectedPrice.Location = new System.Drawing.Point(737, 58);
            this.lblTotalSelectedPrice.Name = "lblTotalSelectedPrice";
            this.lblTotalSelectedPrice.Size = new System.Drawing.Size(124, 26);
            this.lblTotalSelectedPrice.TabIndex = 6;
            this.lblTotalSelectedPrice.Text = "$225.00";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnAddSelected);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 570);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(880, 60);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(463, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSelected.FlatAppearance.BorderSize = 0;
            this.btnAddSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnAddSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnAddSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSelected.ForeColor = System.Drawing.Color.White;
            this.btnAddSelected.Location = new System.Drawing.Point(630, 11);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(230, 38);
            this.btnAddSelected.TabIndex = 1;
            this.btnAddSelected.Text = "➕ Add Selected Services";
            this.btnAddSelected.UseVisualStyleBackColor = false;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // ResverstaionID
            // 
            this.ResverstaionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ResverstaionID.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ResverstaionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.ResverstaionID.Location = new System.Drawing.Point(290, 35);
            this.ResverstaionID.Name = "ResverstaionID";
            this.ResverstaionID.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.ResverstaionID.Size = new System.Drawing.Size(78, 23);
            this.ResverstaionID.TabIndex = 6;
            this.ResverstaionID.Text = "?";
            this.ResverstaionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillID
            // 
            this.BillID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.BillID.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.BillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.BillID.Location = new System.Drawing.Point(503, 35);
            this.BillID.Name = "BillID";
            this.BillID.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.BillID.Size = new System.Drawing.Size(84, 23);
            this.BillID.TabIndex = 7;
            this.BillID.Text = "?";
            this.BillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtrlAddServiceToBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlServices);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CtrlAddServiceToBill";
            this.Size = new System.Drawing.Size(880, 630);
            this.Load += new System.EventHandler(this.CtrlAddServiceToBill_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlServices.ResumeLayout(false);
            this.pnlServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label picIcon;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.Label lblCustIdBadge;
        public System.Windows.Forms.Label lblBillIdBadge;
        public System.Windows.Forms.Label lblSelectedCountBadge;

        // Services list
        private System.Windows.Forms.Panel pnlServices;
        private System.Windows.Forms.Label lblServicesSectionHeader;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        public System.Windows.Forms.ComboBox cmbCategoryFilter;
        public System.Windows.Forms.DataGridView dgvServices;

        // Selection summary
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryHeader;
        private System.Windows.Forms.Label lblSelectedIcon;
        private System.Windows.Forms.Label lblSelectedCaption;
        public System.Windows.Forms.Label lblSelectedServices;
        private System.Windows.Forms.Label lblTotalIcon;
        private System.Windows.Forms.Label lblTotalCaption;
        public System.Windows.Forms.Label lblTotalSelectedPrice;

        // Footer
        private System.Windows.Forms.Panel pnlFooter;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        public System.Windows.Forms.Label ResverstaionID;
        public System.Windows.Forms.Label BillID;
    }
}