using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using LyantheTEST;
using Dictionary;

namespace WindowsFormsApp2
{
    
    public partial class Users : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Users()
        {
            InitializeComponent();
            Check_memory_DB();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            lbUser.Text = userName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Check_memory_DB()
        {
            try
            {

                SqlConnection conn;
                conn = new SqlConnection("Data Source= DTAP-L-SQL01\\LYADEV01;Initial Catalog = MFO_DICTIONARY;Persist Security Info=True;User ID=MFOLogin;Password=wr4e4pla*");

                conn.Open();

                SqlCommand commandscan;
                SqlDataAdapter adapterscan = new SqlDataAdapter();
                DataSet dsScan = new DataSet();
                commandscan = new SqlCommand(
                     "SELECT * FROM TWORDDESCRIPTION " +
                     "WHERE IsDeleted = 0", conn);
                adapterscan.SelectCommand = commandscan;
                adapterscan.Fill(dsScan, "SQL Temp Table");
                adapterscan.Dispose();
                commandscan.Dispose();

                for (int i = 0; i < dsScan.Tables[0].Rows.Count; i++)
                {
                    cbList.Items.Add(dsScan.Tables[0].Rows[i]["Word"]);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void cbList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn;
                conn = new SqlConnection("Data Source= DTAP-L-SQL01\\LYADEV01;Initial Catalog = MFO_DICTIONARY;Persist Security Info=True;User ID=MFOLogin;Password=wr4e4pla*");

                conn.Open();

                SqlCommand commandscan1;
                SqlDataAdapter adapterscan1 = new SqlDataAdapter();
                DataSet dsScan1 = new DataSet();
                commandscan1 = new SqlCommand(
                     "SELECT * FROM TWORDDESCRIPTION " +
                     "WHERE Word like '" + cbList.Text + "' AND IsDeleted = 0", conn);
                adapterscan1.SelectCommand = commandscan1;
                adapterscan1.Fill(dsScan1, "SQL Temp Table");
                adapterscan1.Dispose();
                commandscan1.Dispose();

              //  rtbDescription.Text = dsScan1.Tables[0].Rows[0]["Description"].ToString();

                if (cbList.Text == "")
                {
                    rtbDescription.Text = "";
                }
            }
            catch (Exception)
            {
              //  MessageBox.Show("No Word Available.");
            }
        }
        private void cbList_Click(object sender, EventArgs e)
        {
            if (cbList.Text == "")
            {
                rtbDescription.Clear();
            }
            rtbDescription.Clear();
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //hide window 
            this.Hide();
            //show you menu when user is logged 
            var Start = new AdminView();
            Start.Show();
            // MessageBox.Show("memer");
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (Login.TriggerAdmin == 1)
            {
                bunifuFlatButton1.Enabled = true;
            }

            else
            {
                bunifuFlatButton1.Enabled = false;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void Users_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbList.Text == "")
            {
                MessageBox.Show("Select Words");
            }
            else

                try
                {
                    SqlConnection conn;
                    conn = new SqlConnection("Data Source= DTAP-L-SQL01\\LYADEV01;Initial Catalog = MFO_DICTIONARY;Persist Security Info=True;User ID=MFOLogin;Password=wr4e4pla*");

                    conn.Open();

                    SqlCommand commandscan1;
                    SqlDataAdapter adapterscan1 = new SqlDataAdapter();
                    DataSet dsScan1 = new DataSet();
                    commandscan1 = new SqlCommand(
                         "SELECT * FROM TWORDDESCRIPTION " +
                         "WHERE Word like '" + cbList.Text + "' AND IsDeleted = 0", conn);
                    adapterscan1.SelectCommand = commandscan1;
                    adapterscan1.Fill(dsScan1, "SQL Temp Table");
                    adapterscan1.Dispose();
                    commandscan1.Dispose();

                    rtbDescription.Text = dsScan1.Tables[0].Rows[0]["Description"].ToString();

                    if (cbList.Text == "")
                    {
                        rtbDescription.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No Word Available.");
                    rtbDescription.Clear();
                }
        }
        }
}
