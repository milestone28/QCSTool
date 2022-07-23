using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Dictionary.Forms
{
    public partial class formLogs : Form
    {
        public formLogs()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            var Start = new formMenu();
            Start.ShowDialog();
        }

        private void btnUserlogin_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Forms.UC_UsersLogin uo1 = new Forms.UC_UsersLogin();
            uo1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uo1);
        }

        // ---- move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formLogs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSetDCLogs_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Forms.UC_UsersSetDC uo1 = new Forms.UC_UsersSetDC();
            uo1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uo1);
        }

        private void btnResetToCp_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Forms.UC_ResetToCP uo1 = new Forms.UC_ResetToCP();
            uo1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uo1);
        }

        private void btnDeleteBatch_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Forms.UC_BatchDelete uo1 = new Forms.UC_BatchDelete();
            uo1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uo1);
        }
    }
}
