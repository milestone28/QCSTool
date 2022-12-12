using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class formMenu : Form
    {
        string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public static string MainUserName = "Unknown User";
        public static int triggerVFMenu = 0;
        public formMenu()
        {
            InitializeComponent();
            lblUser.Text = UserName;
            MainUserName = UserName;


            if (lblUser.Text == @"SRV\apptestuser" || lblUser.Text == @"SRV\j.villamor" || lblUser.Text == @"SRV\p.lara" || lblUser.Text == @"SRV\e.banghe" || lblUser.Text == @"SRV\admgyu")
            {
                btnAutoDC.Enabled = true;
                btnBatchMGMT.Enabled = true;
                btnLogs.Enabled = true;
                btnTerminology.Enabled = true;
            }

            else
            {
                btnAutoDC.Enabled = true;
                btnBatchMGMT.Enabled = true;
                btnTerminology.Enabled = true;
                triggerVFMenu = 1;
            }


        }

        private void btnTerminology_Click(object sender, EventArgs e)
        {
            if (lblUser.Text == @"SRV\apptestuser" || lblUser.Text == @"SRV\j.villamor" || lblUser.Text == @"SRV\p.lara" || lblUser.Text == @"SRV\e.banghe" || lblUser.Text == @"SRV\admgyu")
            {
                var Start = new Forms.formTerminology();
                Start.Show();
                this.Hide();
            }

            else
            {
                var Start = new Forms.formVFView();
                Start.Show();
                this.Hide();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formMenu_MouseDown(object sender, MouseEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            var Start = new Forms.formLogs();
            Start.Show();
            this.Hide();
        }

        private void btnAutoDC_Click(object sender, EventArgs e)
        {
            var Start = new Forms.formAutoDC();
            Start.Show();
            this.Hide();
        }

        private void btnResetToCP_Click(object sender, EventArgs e)
        {
            var Start = new Forms.formResetToCP();
            Start.Show();
            this.Hide();
        }
    }
}
