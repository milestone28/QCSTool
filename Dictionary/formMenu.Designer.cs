namespace Dictionary
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBatchMGMT = new System.Windows.Forms.Button();
            this.btnAutoDC = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnTerminology = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBatchMGMT);
            this.panel1.Controls.Add(this.btnAutoDC);
            this.panel1.Controls.Add(this.btnLogs);
            this.panel1.Controls.Add(this.btnTerminology);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 123);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(112, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 21);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "USER";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1009, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 26);
            this.btnMinimize.TabIndex = 28;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(24, 4);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(82, 21);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "` Welcome";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1057, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 26);
            this.btnExit.TabIndex = 27;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBatchMGMT
            // 
            this.btnBatchMGMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBatchMGMT.Enabled = false;
            this.btnBatchMGMT.FlatAppearance.BorderSize = 0;
            this.btnBatchMGMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchMGMT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBatchMGMT.ForeColor = System.Drawing.Color.White;
            this.btnBatchMGMT.Image = global::Dictionary.Properties.Resources.administration;
            this.btnBatchMGMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatchMGMT.Location = new System.Drawing.Point(838, 33);
            this.btnBatchMGMT.Name = "btnBatchMGMT";
            this.btnBatchMGMT.Size = new System.Drawing.Size(184, 77);
            this.btnBatchMGMT.TabIndex = 3;
            this.btnBatchMGMT.Text = "              Batch MGMT";
            this.btnBatchMGMT.UseVisualStyleBackColor = false;
            this.btnBatchMGMT.Click += new System.EventHandler(this.btnResetToCP_Click);
            // 
            // btnAutoDC
            // 
            this.btnAutoDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAutoDC.Enabled = false;
            this.btnAutoDC.FlatAppearance.BorderSize = 0;
            this.btnAutoDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoDC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAutoDC.ForeColor = System.Drawing.Color.White;
            this.btnAutoDC.Image = global::Dictionary.Properties.Resources.double_tick;
            this.btnAutoDC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoDC.Location = new System.Drawing.Point(584, 33);
            this.btnAutoDC.Name = "btnAutoDC";
            this.btnAutoDC.Size = new System.Drawing.Size(184, 77);
            this.btnAutoDC.TabIndex = 2;
            this.btnAutoDC.Text = "          Auto DC";
            this.btnAutoDC.UseVisualStyleBackColor = false;
            this.btnAutoDC.Click += new System.EventHandler(this.btnAutoDC_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogs.Enabled = false;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Image = global::Dictionary.Properties.Resources.immigration1;
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(331, 33);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(184, 77);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "          Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnTerminology
            // 
            this.btnTerminology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTerminology.Enabled = false;
            this.btnTerminology.FlatAppearance.BorderSize = 0;
            this.btnTerminology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminology.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTerminology.ForeColor = System.Drawing.Color.White;
            this.btnTerminology.Image = ((System.Drawing.Image)(resources.GetObject("btnTerminology.Image")));
            this.btnTerminology.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminology.Location = new System.Drawing.Point(74, 33);
            this.btnTerminology.Name = "btnTerminology";
            this.btnTerminology.Size = new System.Drawing.Size(184, 77);
            this.btnTerminology.TabIndex = 0;
            this.btnTerminology.Text = "Terminology";
            this.btnTerminology.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminology.UseVisualStyleBackColor = false;
            this.btnTerminology.Click += new System.EventHandler(this.btnTerminology_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 659);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMenu_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerminology;
        private System.Windows.Forms.Button btnBatchMGMT;
        private System.Windows.Forms.Button btnAutoDC;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRole;
    }
}