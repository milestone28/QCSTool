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
    
    public partial class formVFView : Form
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;

        public formVFView()
        {
            InitializeComponent();
            lblUsername.Text = UserName;
            con = new SqlConnection(path);
            display();

            if (formMenu.triggerVFMenu == 1)
            {
                btnHome.Enabled = true;
            }

        }

        // ---- move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formVFView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display();
        }



        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select Id, Word, Description from TWordDescription order by creDate desc", con);
                adpt.Fill(dt);
                dgvWords.DataSource = dt;
                dgvWords.Columns["Id"].Visible = false;
                dgvWords.Columns["Description"].Visible = false;
                dgvWords.Columns[0].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dgvWords.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblWord.Text = dgvWords.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtbDesc.Text = dgvWords.Rows[e.RowIndex].Cells[2].Value.ToString();

            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Login.TriggerAdmin == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            var Start = new formMenu();
            Start.ShowDialog();
        }
    }
}
