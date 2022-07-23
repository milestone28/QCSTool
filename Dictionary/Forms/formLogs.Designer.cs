namespace Dictionary.Forms
{
    partial class formLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogs));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteBatch = new System.Windows.Forms.Button();
            this.btnResetToCp = new System.Windows.Forms.Button();
            this.btnSetDCLogs = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUserlogin = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnDeleteBatch);
            this.panel2.Controls.Add(this.btnResetToCp);
            this.panel2.Controls.Add(this.btnSetDCLogs);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnUserlogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 578);
            this.panel2.TabIndex = 8;
            // 
            // btnDeleteBatch
            // 
            this.btnDeleteBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDeleteBatch.FlatAppearance.BorderSize = 0;
            this.btnDeleteBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBatch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteBatch.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBatch.Image = global::Dictionary.Properties.Resources.remove__2_;
            this.btnDeleteBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBatch.Location = new System.Drawing.Point(3, 340);
            this.btnDeleteBatch.Name = "btnDeleteBatch";
            this.btnDeleteBatch.Size = new System.Drawing.Size(184, 77);
            this.btnDeleteBatch.TabIndex = 8;
            this.btnDeleteBatch.Text = "                 Batch Deleted";
            this.btnDeleteBatch.UseVisualStyleBackColor = false;
            this.btnDeleteBatch.Click += new System.EventHandler(this.btnDeleteBatch_Click);
            // 
            // btnResetToCp
            // 
            this.btnResetToCp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnResetToCp.FlatAppearance.BorderSize = 0;
            this.btnResetToCp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetToCp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnResetToCp.ForeColor = System.Drawing.Color.White;
            this.btnResetToCp.Image = global::Dictionary.Properties.Resources.reset;
            this.btnResetToCp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetToCp.Location = new System.Drawing.Point(3, 240);
            this.btnResetToCp.Name = "btnResetToCp";
            this.btnResetToCp.Size = new System.Drawing.Size(184, 77);
            this.btnResetToCp.TabIndex = 7;
            this.btnResetToCp.Text = "                 Reset To CP";
            this.btnResetToCp.UseVisualStyleBackColor = false;
            this.btnResetToCp.Click += new System.EventHandler(this.btnResetToCp_Click);
            // 
            // btnSetDCLogs
            // 
            this.btnSetDCLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSetDCLogs.FlatAppearance.BorderSize = 0;
            this.btnSetDCLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDCLogs.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSetDCLogs.ForeColor = System.Drawing.Color.White;
            this.btnSetDCLogs.Image = global::Dictionary.Properties.Resources.network_50px;
            this.btnSetDCLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetDCLogs.Location = new System.Drawing.Point(3, 140);
            this.btnSetDCLogs.Name = "btnSetDCLogs";
            this.btnSetDCLogs.Size = new System.Drawing.Size(184, 77);
            this.btnSetDCLogs.TabIndex = 6;
            this.btnSetDCLogs.Text = "            User Set DC";
            this.btnSetDCLogs.UseVisualStyleBackColor = false;
            this.btnSetDCLogs.Click += new System.EventHandler(this.btnSetDCLogs_Click);
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
            this.btnHome.Location = new System.Drawing.Point(3, 532);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(184, 43);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "          Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUserlogin
            // 
            this.btnUserlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUserlogin.FlatAppearance.BorderSize = 0;
            this.btnUserlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserlogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUserlogin.ForeColor = System.Drawing.Color.White;
            this.btnUserlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnUserlogin.Image")));
            this.btnUserlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserlogin.Location = new System.Drawing.Point(3, 40);
            this.btnUserlogin.Name = "btnUserlogin";
            this.btnUserlogin.Size = new System.Drawing.Size(184, 77);
            this.btnUserlogin.TabIndex = 4;
            this.btnUserlogin.Text = "             User Login";
            this.btnUserlogin.UseVisualStyleBackColor = false;
            this.btnUserlogin.Click += new System.EventHandler(this.btnUserlogin_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 4);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(121, 21);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Users Logs QCS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 32);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackgroundImage = global::Dictionary.Properties.Resources.firmbee_com_jrh5lAq_mIs_unsplash;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(193, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(759, 578);
            this.mainPanel.TabIndex = 9;
            // 
            // formLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogs";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogs_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUserlogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnSetDCLogs;
        private System.Windows.Forms.Button btnResetToCp;
        private System.Windows.Forms.Button btnDeleteBatch;
    }
}