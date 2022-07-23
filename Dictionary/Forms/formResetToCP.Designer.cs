namespace Dictionary.Forms
{
    partial class formResetToCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResetToCP));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewPdf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnResetToCp = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblServernameBE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbScanstreet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSQLLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBatchNumber = new System.Windows.Forms.TextBox();
            this.tbJointVenture = new System.Windows.Forms.TextBox();
            this.tbDocFilename = new System.Windows.Forms.TextBox();
            this.tbDossierCode = new System.Windows.Forms.TextBox();
            this.tbApplicationName = new System.Windows.Forms.TextBox();
            this.tbDocType = new System.Windows.Forms.TextBox();
            this.lblServernameFE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(199, 194);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(332, 397);
            this.dgvList.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnViewPdf);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnResetToCp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 554);
            this.panel2.TabIndex = 17;
            // 
            // btnViewPdf
            // 
            this.btnViewPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnViewPdf.Enabled = false;
            this.btnViewPdf.FlatAppearance.BorderSize = 0;
            this.btnViewPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPdf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnViewPdf.ForeColor = System.Drawing.Color.White;
            this.btnViewPdf.Image = global::Dictionary.Properties.Resources.pdf;
            this.btnViewPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPdf.Location = new System.Drawing.Point(3, 170);
            this.btnViewPdf.Name = "btnViewPdf";
            this.btnViewPdf.Size = new System.Drawing.Size(184, 77);
            this.btnViewPdf.TabIndex = 7;
            this.btnViewPdf.Text = "               View PDF";
            this.btnViewPdf.UseVisualStyleBackColor = false;
            this.btnViewPdf.Click += new System.EventHandler(this.btnViewPdf_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Dictionary.Properties.Resources.remove__2_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(3, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 77);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "               Logo Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 508);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(184, 43);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "          Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnResetToCp
            // 
            this.btnResetToCp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnResetToCp.Enabled = false;
            this.btnResetToCp.FlatAppearance.BorderSize = 0;
            this.btnResetToCp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetToCp.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnResetToCp.ForeColor = System.Drawing.Color.White;
            this.btnResetToCp.Image = global::Dictionary.Properties.Resources.reset;
            this.btnResetToCp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetToCp.Location = new System.Drawing.Point(3, 41);
            this.btnResetToCp.Name = "btnResetToCp";
            this.btnResetToCp.Size = new System.Drawing.Size(184, 77);
            this.btnResetToCp.TabIndex = 1;
            this.btnResetToCp.Text = "             Reset To Cp";
            this.btnResetToCp.UseVisualStyleBackColor = false;
            this.btnResetToCp.Click += new System.EventHandler(this.btnSetToDC_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 4);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(125, 21);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Reset To CP QCS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 32);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(149, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 21);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "USER";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(870, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(917, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(544, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Batchnumber :";
            // 
            // lblServernameBE
            // 
            this.lblServernameBE.AutoSize = true;
            this.lblServernameBE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServernameBE.ForeColor = System.Drawing.Color.Black;
            this.lblServernameBE.Location = new System.Drawing.Point(673, 63);
            this.lblServernameBE.Name = "lblServernameBE";
            this.lblServernameBE.Size = new System.Drawing.Size(91, 25);
            this.lblServernameBE.TabIndex = 22;
            this.lblServernameBE.Text = "Back End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(572, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "DBServerBE :";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnScan.Enabled = false;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.Location = new System.Drawing.Point(312, 153);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(116, 36);
            this.btnScan.TabIndex = 25;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbScanstreet
            // 
            this.cmbScanstreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanstreet.FormattingEnabled = true;
            this.cmbScanstreet.Location = new System.Drawing.Point(332, 62);
            this.cmbScanstreet.Name = "cmbScanstreet";
            this.cmbScanstreet.Size = new System.Drawing.Size(204, 23);
            this.cmbScanstreet.TabIndex = 28;
            this.cmbScanstreet.SelectedIndexChanged += new System.EventHandler(this.cmbScanstreet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(199, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Scanstreet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "BatchNumber";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(208, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 23);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageServersToolStripMenuItem,
            this.manageSQLLoginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // manageServersToolStripMenuItem
            // 
            this.manageServersToolStripMenuItem.Name = "manageServersToolStripMenuItem";
            this.manageServersToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manageServersToolStripMenuItem.Text = "Manage Servers";
            this.manageServersToolStripMenuItem.Click += new System.EventHandler(this.manageServersToolStripMenuItem_Click);
            // 
            // manageSQLLoginToolStripMenuItem
            // 
            this.manageSQLLoginToolStripMenuItem.Name = "manageSQLLoginToolStripMenuItem";
            this.manageSQLLoginToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manageSQLLoginToolStripMenuItem.Text = "Manage SQL Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(546, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Joint Venture :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(544, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Doc File Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(546, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Dossier Code :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(546, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Status :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(546, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 21);
            this.label14.TabIndex = 37;
            this.label14.Text = "Doc Type :";
            // 
            // tbBatchNumber
            // 
            this.tbBatchNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBatchNumber.Location = new System.Drawing.Point(678, 162);
            this.tbBatchNumber.Name = "tbBatchNumber";
            this.tbBatchNumber.ReadOnly = true;
            this.tbBatchNumber.Size = new System.Drawing.Size(252, 29);
            this.tbBatchNumber.TabIndex = 41;
            // 
            // tbJointVenture
            // 
            this.tbJointVenture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJointVenture.Location = new System.Drawing.Point(678, 199);
            this.tbJointVenture.Name = "tbJointVenture";
            this.tbJointVenture.ReadOnly = true;
            this.tbJointVenture.Size = new System.Drawing.Size(252, 29);
            this.tbJointVenture.TabIndex = 42;
            // 
            // tbDocFilename
            // 
            this.tbDocFilename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocFilename.Location = new System.Drawing.Point(678, 274);
            this.tbDocFilename.Name = "tbDocFilename";
            this.tbDocFilename.ReadOnly = true;
            this.tbDocFilename.Size = new System.Drawing.Size(252, 29);
            this.tbDocFilename.TabIndex = 44;
            // 
            // tbDossierCode
            // 
            this.tbDossierCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDossierCode.Location = new System.Drawing.Point(678, 237);
            this.tbDossierCode.Name = "tbDossierCode";
            this.tbDossierCode.ReadOnly = true;
            this.tbDossierCode.Size = new System.Drawing.Size(252, 29);
            this.tbDossierCode.TabIndex = 43;
            // 
            // tbApplicationName
            // 
            this.tbApplicationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplicationName.Location = new System.Drawing.Point(678, 348);
            this.tbApplicationName.Name = "tbApplicationName";
            this.tbApplicationName.ReadOnly = true;
            this.tbApplicationName.Size = new System.Drawing.Size(252, 29);
            this.tbApplicationName.TabIndex = 46;
            // 
            // tbDocType
            // 
            this.tbDocType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocType.Location = new System.Drawing.Point(678, 311);
            this.tbDocType.Name = "tbDocType";
            this.tbDocType.ReadOnly = true;
            this.tbDocType.Size = new System.Drawing.Size(252, 29);
            this.tbDocType.TabIndex = 45;
            // 
            // lblServernameFE
            // 
            this.lblServernameFE.AutoSize = true;
            this.lblServernameFE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServernameFE.ForeColor = System.Drawing.Color.Black;
            this.lblServernameFE.Location = new System.Drawing.Point(673, 93);
            this.lblServernameFE.Name = "lblServernameFE";
            this.lblServernameFE.Size = new System.Drawing.Size(95, 25);
            this.lblServernameFE.TabIndex = 48;
            this.lblServernameFE.Text = "Front End";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(572, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "DBServerFE :";
            // 
            // formResetToCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.lblServernameFE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbApplicationName);
            this.Controls.Add(this.tbDocType);
            this.Controls.Add(this.tbDocFilename);
            this.Controls.Add(this.tbDossierCode);
            this.Controls.Add(this.tbJointVenture);
            this.Controls.Add(this.tbBatchNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbScanstreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblServernameBE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formResetToCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formResetToCP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnResetToCp;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblServernameBE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbScanstreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSQLLoginToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbBatchNumber;
        private System.Windows.Forms.TextBox tbJointVenture;
        private System.Windows.Forms.TextBox tbDocFilename;
        private System.Windows.Forms.TextBox tbDossierCode;
        private System.Windows.Forms.TextBox tbApplicationName;
        private System.Windows.Forms.TextBox tbDocType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblServernameFE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewPdf;
    }
}