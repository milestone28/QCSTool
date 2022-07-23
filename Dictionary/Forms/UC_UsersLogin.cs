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
    public partial class UC_UsersLogin : UserControl
    {

        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        string sqlFormat = "yyyy-MM-dd HH:mm:ss.fff";


        public UC_UsersLogin()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            if (cmbRole.Text == "")
            {

                MessageBox.Show(" Select Role ");
                txtSearch.Clear();

            }

            else
            {
                string date = dateTimePicker1.Value.ToString(sqlFormat);
                string date2 = dateTimePicker2.Value.ToString(sqlFormat);

                if (cmbRole.Text == "QCS")
                {

                    try
                    {
                        DataSet ds = new DataSet();
                        DataTable dt = new System.Data.DataTable();

                        con.Open();

                        adpt = new SqlDataAdapter("select * from TUserlogin where status = 'QCS' and Username like '%"+txtSearch.Text+"%' and LoginDate BETWEEN '"+date+ "' AND '" + date2 + "' order by LoginDate desc", con);
                        adpt.Fill(dt);
                        dgvUserlist.DataSource = dt;
                        dgvUserlist.Columns["ID"].Visible = false;
                        DataGridViewColumn ID_ColumnAlive1 = dgvUserlist.Columns[1];
                        ID_ColumnAlive1.Width = 150;
                        DataGridViewColumn ID_ColumnAlive2 = dgvUserlist.Columns[2];
                        ID_ColumnAlive2.Width = 150;
                        DataGridViewColumn ID_ColumnAlive3 = dgvUserlist.Columns[3];
                        ID_ColumnAlive3.Width = 150;
                        dgvUserlist.Columns[3].HeaderText = "Role";
                        con.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }

                if (cmbRole.Text == "VF")
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        DataTable dt = new System.Data.DataTable();
                        con.Open();

                        adpt = new SqlDataAdapter("select * from TUserlogin where status = 'VF' and Username like '%" + txtSearch.Text + "%' and LoginDate BETWEEN '" + date + "' AND '" + date2 + "' order by LoginDate desc", con);
                        adpt.Fill(dt);
                        dgvUserlist.DataSource = dt;
                        dgvUserlist.Columns["ID"].Visible = false;
                        DataGridViewColumn ID_ColumnAlive1 = dgvUserlist.Columns[1];
                        ID_ColumnAlive1.Width = 150;
                        DataGridViewColumn ID_ColumnAlive2 = dgvUserlist.Columns[2];
                        ID_ColumnAlive2.Width = 150;
                        DataGridViewColumn ID_ColumnAlive3 = dgvUserlist.Columns[3];
                        ID_ColumnAlive3.Width = 150;
                        dgvUserlist.Columns[3].HeaderText = "Role";
                        con.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }


               
            }
        }

        public void display()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select TOP(50) * from TUserlogin where LoginDate > getdate() - 30 order by LoginDate desc", con);
                adpt.Fill(dt);
                dgvUserlist.DataSource = dt;
                dgvUserlist.Columns["ID"].Visible = false;
                DataGridViewColumn ID_ColumnAlive1 = dgvUserlist.Columns[1];
                ID_ColumnAlive1.Width = 150;
                DataGridViewColumn ID_ColumnAlive2 = dgvUserlist.Columns[2];
                ID_ColumnAlive2.Width = 150;
                DataGridViewColumn ID_ColumnAlive3 = dgvUserlist.Columns[3];
                ID_ColumnAlive3.Width = 150;
                dgvUserlist.Columns[3].HeaderText = "Role";
                con.Close();
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

      
    }
}
