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
    public partial class UC_ResetToCP : UserControl
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;

        public UC_ResetToCP()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string sqlFormat = "yyyy-MM-dd HH:mm:ss.fff";
            //string date = dateTimePicker1.Value.ToString(sqlFormat);
            //string date2 = dateTimePicker2.Value.ToString(sqlFormat);



        }


        public void display()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select ID, UsernameRTCP, UpdateDateRTCP, StatusRTCP, batchNumberRTCP, ScanstreetRTCP, DossierCodeRTCP from USER_REPORTING where UpdateDateRTCP > getdate() - 7 order by UpdateDateADC asc", con);
                adpt.Fill(dt);
                dgvBatchList.DataSource = dt;
                dgvBatchList.Columns["ID"].Visible = false;
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string _batchnumber = txtSearch.Text;
            try
            {
                _batchnumber.Replace("111_", "").Replace("110_", "").Replace("101_", "").Replace("011_", "").Replace("[a-z]", "").Replace("[A-Z]", "").Replace(" ", "").Replace("000_", "").Replace("010_", "").Replace("100_", "").Replace("001_", "");
                txtSearch.Text = _batchnumber;

                DataSet ds = new DataSet();
                DataTable dt = new System.Data.DataTable();

                con.Open();
                adpt = new SqlDataAdapter("select ID, UsernameRTCP, UpdateDateRTCP, StatusRTCP, batchNumberRTCP, ScanstreetRTCP, DossierCodeRTCP from USER_REPORTING where batchNumberRTCP like '%" + txtSearch.Text + "%' order by UpdateDateRTCP asc", con);
                adpt.Fill(dt);
                dgvBatchList.DataSource = dt;
                dgvBatchList.Columns[1].HeaderText = "User Resetted";
                dgvBatchList.Columns[2].HeaderText = "Status";
                dgvBatchList.Columns[3].HeaderText = "BatchNumber";
                dgvBatchList.Columns[4].HeaderText = "Scanstreet";
                dgvBatchList.Columns[5].HeaderText = "DossierCode";
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
