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
    public partial class formTerminology : Form
    {
        string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;

        int TriggerCreation = 0;

        public formTerminology()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            lblUser.Text = UserName;
        }


        public void searchWord()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();

                con.Open();

                adpt = new SqlDataAdapter("select Id, Word, Description, CreUser, CreDate from TWordDescription where Word like '%" + txtSearch.Text + "%'", con);
                adpt.Fill(dt);
                dgvWords.DataSource = dt;
                con.Close();

            }

            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
                con.Close();
            }
        }




        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select Id, Word, Description, CreUser, CreDate from TWordDescription order by creDate desc", con);
                adpt.Fill(dt);
                dgvWords.DataSource = dt;
                dgvWords.Columns["Id"].Visible = false;
                dgvWords.Columns["Description"].Visible = false;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            var Start = new formMenu();
            Start.ShowDialog();

        }

        private void dgvWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dgvWords.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtWord.Text = dgvWords.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtbDesc.Text = dgvWords.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                TriggerCreation = 0;
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            searchWord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                TriggerCreation = 1;
                txtSearch.Text = "";
                txtWord.Text = " input Word here ";
                rtbDesc.Text = " input Description here ";
                dgvWords.ClearSelection();
                btnUpdate.Enabled = true;
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtWord.Text == "" || rtbDesc.Text == "")
            {
               
                MessageBox.Show(" Input Data ");
            }
            else
            {
                if (TriggerCreation == 1)
                {
                    save();
                }
                else
                {
                    update();
                }
               
            }
        }

        public void save()
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("INSERT INTO [dbo].[TWordDescription] ([Word],[Description],[CreDate],[CreUser],[UpdDate],[UpdUser],[IsDeleted],[DeletedBy],[DeletedDateTime]) VALUES " +
                         "(@Word, @Description, GETDATE(),'" + UserName + "', NULL, NULL, 0, NULL, NULL)", con);

                cmd.Parameters.Add("@Word", SqlDbType.VarChar).Value = txtWord.Text;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = rtbDesc.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been saved !!! ");
                display();
                clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void update()
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("UPDATE TWordDescription " +
                         "SET Word = @Word, Description = @Description, UpdUser = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "', " +
                         "UpdDate = GETDATE() " +
                         "WHERE Id = " + ID, con);

                cmd.Parameters.Add("@Word", SqlDbType.VarChar).Value = txtWord.Text;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = rtbDesc.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been updated !!! ");
                display();
                clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void delete()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from TWordDescription where Id = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been Deleted !!! ");
                display();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtWord.Text = "";
            rtbDesc.Text = "";
            txtSearch.Text = "";
            ID = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Delete Permanent User?", " WARNING ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                delete();
            }
        }
        // ---- move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formTerminology_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnVFview_Click(object sender, EventArgs e)
        {
            var Start = new Forms.formVFView();
            Start.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
