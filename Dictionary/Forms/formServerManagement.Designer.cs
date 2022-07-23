namespace Dictionary.Forms
{
    partial class formServerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formServerManagement));
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInstance = new System.Windows.Forms.TextBox();
            this.btnNewserver = new System.Windows.Forms.Button();
            this.btnSaveServer = new System.Windows.Forms.Button();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.dgvServerList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTypeofservice = new System.Windows.Forms.TextBox();
            this.tbLyaOUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(16, 29);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(122, 20);
            this.tbServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instance";
            // 
            // tbInstance
            // 
            this.tbInstance.Location = new System.Drawing.Point(146, 29);
            this.tbInstance.Name = "tbInstance";
            this.tbInstance.Size = new System.Drawing.Size(113, 20);
            this.tbInstance.TabIndex = 2;
            // 
            // btnNewserver
            // 
            this.btnNewserver.Location = new System.Drawing.Point(16, 82);
            this.btnNewserver.Name = "btnNewserver";
            this.btnNewserver.Size = new System.Drawing.Size(98, 23);
            this.btnNewserver.TabIndex = 4;
            this.btnNewserver.Text = "New Server";
            this.btnNewserver.UseVisualStyleBackColor = true;
            this.btnNewserver.Click += new System.EventHandler(this.btnNewserver_Click);
            // 
            // btnSaveServer
            // 
            this.btnSaveServer.Location = new System.Drawing.Point(146, 82);
            this.btnSaveServer.Name = "btnSaveServer";
            this.btnSaveServer.Size = new System.Drawing.Size(98, 23);
            this.btnSaveServer.TabIndex = 5;
            this.btnSaveServer.Text = "Save Server";
            this.btnSaveServer.UseVisualStyleBackColor = true;
            this.btnSaveServer.Click += new System.EventHandler(this.btnSaveServer_Click);
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Location = new System.Drawing.Point(280, 82);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveServer.TabIndex = 6;
            this.btnRemoveServer.Text = "Remove Server";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
            // 
            // dgvServerList
            // 
            this.dgvServerList.AllowUserToAddRows = false;
            this.dgvServerList.AllowUserToDeleteRows = false;
            this.dgvServerList.AllowUserToResizeColumns = false;
            this.dgvServerList.AllowUserToResizeRows = false;
            this.dgvServerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServerList.Location = new System.Drawing.Point(16, 111);
            this.dgvServerList.Name = "dgvServerList";
            this.dgvServerList.ReadOnly = true;
            this.dgvServerList.RowHeadersVisible = false;
            this.dgvServerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvServerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServerList.Size = new System.Drawing.Size(362, 382);
            this.dgvServerList.TabIndex = 7;
            this.dgvServerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServerList_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type of Service";
            // 
            // tbTypeofservice
            // 
            this.tbTypeofservice.Location = new System.Drawing.Point(265, 29);
            this.tbTypeofservice.Name = "tbTypeofservice";
            this.tbTypeofservice.Size = new System.Drawing.Size(113, 20);
            this.tbTypeofservice.TabIndex = 8;
            this.tbTypeofservice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTypeofservice_KeyPress);
            // 
            // tbLyaOUT
            // 
            this.tbLyaOUT.Location = new System.Drawing.Point(88, 56);
            this.tbLyaOUT.Name = "tbLyaOUT";
            this.tbLyaOUT.Size = new System.Drawing.Size(290, 20);
            this.tbLyaOUT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "LYA OUT :";
            // 
            // formServerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLyaOUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTypeofservice);
            this.Controls.Add(this.dgvServerList);
            this.Controls.Add(this.btnRemoveServer);
            this.Controls.Add(this.btnSaveServer);
            this.Controls.Add(this.btnNewserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInstance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formServerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInstance;
        private System.Windows.Forms.Button btnNewserver;
        private System.Windows.Forms.Button btnSaveServer;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.DataGridView dgvServerList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTypeofservice;
        private System.Windows.Forms.TextBox tbLyaOUT;
        private System.Windows.Forms.Label label4;
    }
}