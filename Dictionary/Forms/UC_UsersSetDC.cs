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
    public partial class UC_UsersSetDC : UserControl
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        

        public UC_UsersSetDC()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sqlFormat = "yyyy-MM-dd HH:mm:ss.fff";
            string date = dateTimePicker1.Value.ToString(sqlFormat);
            string date2 = dateTimePicker2.Value.ToString(sqlFormat);



            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();

                con.Open();
                adpt = new SqlDataAdapter("select ID, UsernameADC, SetAutoDC, UpdateDateADC, StatusADC from USER_REPORTING where UsernameADC like '%" + txtSearch.Text + "%' AND UpdateDateADC BETWEEN '" + date + "' AND '" + date2 + "' order by UpdateDateADC desc", con);
                adpt.Fill(dt);
                dgvUserlist.DataSource = dt;
                dgvUserlist.Columns["ID"].Visible = false;
                DataGridViewColumn ID_ColumnAlive1 = dgvUserlist.Columns[1];
                ID_ColumnAlive1.Width = 130;
                DataGridViewColumn ID_ColumnAlive2 = dgvUserlist.Columns[2];
                ID_ColumnAlive2.Width = 120;
                DataGridViewColumn ID_ColumnAlive3 = dgvUserlist.Columns[3];
                ID_ColumnAlive3.Width = 130;
                DataGridViewColumn ID_ColumnAlive4 = dgvUserlist.Columns[4];
                ID_ColumnAlive4.Width = 90;
                dgvUserlist.Columns[1].HeaderText = "DC Set By";
                dgvUserlist.Columns[2].HeaderText = "DC Set To";
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
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select ID, UsernameADC, SetAutoDC, UpdateDateADC, StatusADC from USER_REPORTING where UpdateDateADC > getdate() - 7 order by UpdateDateADC desc", con);
                adpt.Fill(dt);
                dgvUserlist.DataSource = dt;
                dgvUserlist.Columns["ID"].Visible = false;
                DataGridViewColumn ID_ColumnAlive1 = dgvUserlist.Columns[1];
                ID_ColumnAlive1.Width = 130;
                DataGridViewColumn ID_ColumnAlive2 = dgvUserlist.Columns[2];
                ID_ColumnAlive2.Width = 120;
                DataGridViewColumn ID_ColumnAlive3 = dgvUserlist.Columns[3];
                ID_ColumnAlive3.Width = 130;
                DataGridViewColumn ID_ColumnAlive4 = dgvUserlist.Columns[4];
                ID_ColumnAlive4.Width = 90;
                dgvUserlist.Columns[1].HeaderText = "DC Set By";
                dgvUserlist.Columns[2].HeaderText = "DC Set To";
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
