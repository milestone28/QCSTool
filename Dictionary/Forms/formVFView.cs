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
        int messageNo = 0;
        int messageNoMax = 0;
        public formVFView()
        {
            InitializeComponent();
            lblUsername.Text = UserName;
            con = new SqlConnection(path);
            display();
            maxLenght();
            //message();
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

            search(txtSearch.Text);
        }



        public void search(string word)
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select Id, Word, Description from TWordDescription where Word like '%" + word + "%'", con);
                adpt.Fill(dt);
                dgvWords.DataSource = dt;
                dgvWords.Columns["Id"].Visible = false;
                dgvWords.Columns["Description"].Visible = false;
                // dgvWords.Columns["Word"].Width = 2100;
                dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void message(int i)
        {
            try
            {
                con.Open();
                using (SqlCommand mycmd = new SqlCommand("select Message from TMessage where id = " + i, con))
                {
                    
                    mycmd.Parameters.Clear();
                    using (SqlDataReader rdr = mycmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                // MessageBox.Show(rdr[0].ToString());
                                formPopup.words = rdr[0].ToString();
                            }
                            formPopup f = new formPopup();
                            f.ShowDialog(this);
                        }
                        else
                        {
                            messageNo = 1;
                        }
                        rdr.Close();
                        rdr.Dispose();
                    }
                    mycmd.Dispose();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void maxLenght()
        {
            try
            {
                con.Open();
                using (SqlCommand mycmd = new SqlCommand("select COUNT (Message) from TMessage", con))
                {
                    mycmd.Parameters.Clear();

                    using (SqlDataReader rdr = mycmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            if (rdr.Read())
                            {
                                //  MessageBox.Show(rdr[0].ToString());
                                messageNoMax = Convert.ToInt32(rdr[0]);
                            }
                        }
                        rdr.Close();
                        rdr.Dispose();
                    }
                    mycmd.Dispose();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                // dgvWords.Columns[0].Width = 200;
                dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Generate 5 random numbers with 0-100 without duplicate
            var rand = new Random();

            List<int> possible = Enumerable.Range(1, messageNoMax).ToList();
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < messageNoMax; i++)
            {
                int index = rand.Next(0, possible.Count);
                listNumbers.Add(possible[index]);
                possible.RemoveAt(index);
                //}
                timer1.Enabled = false;
                // MessageBox.Show(messageNo.ToString());
            }
            messageNo = listNumbers[0];
            message(messageNo);
        }
    }
}
