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
    public partial class UC_BatchDelete : UserControl
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;

        public UC_BatchDelete()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

         
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
                DataTable dt2 = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select Id, BatchNumber, DeletedBy, DeletedDate, DossierCode, JointVenture, Scanstreet from TLogging where BatchNumber like '%" + txtSearch.Text + "%'", con);
                adpt.Fill(dt);
                dgvBE.DataSource = dt;
                con.Close();

                con.Open();
                SqlDataAdapter adpt2 = new SqlDataAdapter("select Id, BatchNumber, DeletedBy, DeletedDate from tscansmonitor where BatchNumber like '%" + txtSearch.Text + "%'", con);
                adpt2.Fill(dt2);
                dgvFE.DataSource = dt2;
                con.Close();

            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
