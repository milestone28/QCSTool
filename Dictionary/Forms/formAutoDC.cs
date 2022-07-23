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
using System.Text.RegularExpressions;

namespace Dictionary.Forms
{
    public partial class formAutoDC : Form
    {

        string path = ConfigurationManager.ConnectionStrings["MyConnectionAutoDC"].ConnectionString;
        SqlConnection con;

        string path2 = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con2;

        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        public int ID;
        public string _userName;
        public string Status;
        public string fullName;
        public string _status;
        public string UserName = "Unknown";

        public formAutoDC()
        {
            InitializeComponent();
            lblUser.Text = formMenu.MainUserName;
            con = new SqlConnection(path);
            con2 = new SqlConnection(path2);
            UserName = formMenu.MainUserName;
            display();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();

                con.Open();
                adpt = new SqlDataAdapter("select ID, FullName, IsDoubleCheck  , UserName, CreateDate from TUsers where FullName like '%" + txtSearch.Text+"%' order by CreateDate desc", con);
                adpt.Fill(dt);
                dgvList.DataSource = dt;
                dgvList.Columns["ID"].Visible = false;
                dgvList.Columns["IsDoubleCheck"].Visible = false;
                dgvList.Columns["CreateDate"].Visible = false;
                DataGridViewColumn ID_ColumnAlive1 = dgvList.Columns[1];
                ID_ColumnAlive1.Width = 180;
                DataGridViewColumn ID_ColumnAlive2 = dgvList.Columns[3];
                ID_ColumnAlive2.Width = 140;
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select Id, FullName, IsDoubleCheck  , UserName, CreateDate from TUsers order by CreateDate desc", con);
                adpt.Fill(dt);
                dgvList.DataSource = dt;
                dgvList.Columns["Id"].Visible = false;
                dgvList.Columns["IsDoubleCheck"].Visible = false;
                dgvList.Columns["CreateDate"].Visible = false;
                DataGridViewColumn ID_ColumnAlive1 = dgvList.Columns[1];
                ID_ColumnAlive1.Width = 180;
                DataGridViewColumn ID_ColumnAlive2 = dgvList.Columns[3];
                ID_ColumnAlive2.Width = 140;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---- move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                fullName = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                Status = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
                _userName = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblFullName.Text = fullName;
                txtSearch.Text = fullName;

                if (Status == "True")
                {
                    lblStatus.Text = "Is Auto DC";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = true;
                }

                else
                {
                    lblStatus.Text = "Is Not Auto DC";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = false;
                }

            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }



           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure?", "Set To DC", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SetToDc();
                txtSearch.Text = "";
                _status = "ADD";
                UserLogsDCset();
            }

        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure?", "Remove To DC", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RemoveToDc();
                txtSearch.Text = "";
                _status = "REMOVE";
                UserLogsDCset();
            }
        }

        public void SetToDc()
        {
            try
            {


                con.Open();


                cmd = new SqlCommand("exec sp_infra_AutoDCUser '" + _userName + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(fullName + "  Is Set to AutoDC ");
                lblStatus.Text = "Is Auto DC";
                lblStatus.ForeColor = System.Drawing.Color.Green;

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void RemoveToDc()
        {
            try
            {


                con.Open();

                cmd = new SqlCommand("exec sp_infra_RemoveAutoDCUser '" + _userName + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(fullName + "  Is Remove To AutoDC ");
                lblStatus.Text = "Is Not Auto DC";
                lblStatus.ForeColor = System.Drawing.Color.Red;

                btnAdd.Enabled = false;
                btnRemove.Enabled = false;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        public void UserLogsDCset()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand();
                con2.Open();

                cmd2 = new SqlCommand("insert into USER_REPORTING (UsernameADC, SetAutoDC, UpdateDateADC, StatusADC) VALUES " +
                                                             "(@Username, @SetAutoDC, getdate(), @Status)", con2);

                cmd2.Parameters.Add("@Username", SqlDbType.VarChar).Value = UserName;
                cmd2.Parameters.Add("@SetAutoDC", SqlDbType.VarChar).Value = fullName;
                cmd2.Parameters.Add("@Status", SqlDbType.VarChar).Value = _status;
                cmd2.ExecuteNonQuery();
                con2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con2.Close();
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
