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
    public partial class formServerManagement : Form
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public int ID;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;


        public formServerManagement()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewserver_Click(object sender, EventArgs e)
        {
            tbInstance.Text = "";
            tbServerName.Text = "";
            tbTypeofservice.Text = "";
            tbLyaOUT.Text = "";
        }

        private void dgvServerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(dgvServerList.Rows[e.RowIndex].Cells[0].Value.ToString());
                tbServerName.Text = dgvServerList.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbInstance.Text = dgvServerList.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTypeofservice.Text = dgvServerList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void tbTypeofservice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            if (tbTypeofservice.Text == "" || tbServerName.Text == "" || tbInstance.Text=="" || tbLyaOUT.Text == "")
            {

                MessageBox.Show(" Input Data ");
            }
            else
            {
                save();
            }
        }

        public void save()
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("INSERT INTO [dbo].[tdocgroup] ([Groupname],[DBServerBE],[TypeofService],[LYAOUT]) VALUES " +
                         "(@Groupname, @DBServerBE, @TypeofService, @LYAOUT)", con);

                cmd.Parameters.Add("@Groupname", SqlDbType.VarChar).Value = tbServerName.Text;
                cmd.Parameters.Add("@DBServerBE", SqlDbType.VarChar).Value = tbInstance.Text;
                cmd.Parameters.Add("@TypeofService", SqlDbType.VarChar).Value = tbTypeofservice.Text;
                cmd.Parameters.Add("@LYAOUT", SqlDbType.VarChar).Value = tbLyaOUT.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been saved !!! ");
                display();
                btnNewserver.PerformClick();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRemoveServer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Delete Permanent?", " WARNING ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tbTypeofservice.Text == "" || tbServerName.Text == "" || tbInstance.Text == "" || tbLyaOUT.Text == "")
                {
                    MessageBox.Show(" select server to fill the box ");
                }
                else
                {
                    delete();
                }
                   
            }
        }

        public void delete()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from tdocgroup where Id = " + ID, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been Deleted !!! ");
                display();
                btnNewserver.PerformClick();

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

                adpt = new SqlDataAdapter("select Id, Groupname, DBserverBE, typeofservice, LYAOUT from tdocgroup order by typeofservice asc", con);
                adpt.Fill(dt);
                dgvServerList.DataSource = dt;
                dgvServerList.Columns["Id"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
