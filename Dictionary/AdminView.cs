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
using WindowsFormsApp2;
using Dictionary;

namespace LyantheTEST
{
    public partial class AdminView : Form
    {
        public string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public string ConnectionString = "Data Source= DTAP-L-SQL01\\LYADEV01;Initial Catalog = MFO_DICTIONARY;Persist Security Info=True;User ID=MFOLogin;Password=wr4e4pla*";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public AdminView()
        {
            InitializeComponent();
            Check_WORDS_IN_DB();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            lbUser.Text = userName;
        }
        public void Check_WORDS_IN_DB()
        {
            try
            {

                SqlConnection conn;
                conn = new SqlConnection(ConnectionString);

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
                SubmenuAdd.Visible = false;
                btnClose.Visible = false;
                pictureBox4.Visible = false;

                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertNew();
            SubmenuAdd.Visible = false;
        }
        public void InsertNew()
        {
            try
            {
                if (tbWord.Text != "" && tbWord.Text != " " && tbWord.Text != "  " && tbWord.Text != "   " && rtbDescription.Text != "" && rtbDescription.Text != " " && rtbDescription.Text != "  " && rtbDescription.Text != "   ")
                {
                    SqlConnection conn;
                    conn = new SqlConnection(ConnectionString);

                    conn.Open();
                    //MessageBox.Show("conected");
                    
                    SqlCommand commandscan2;
                    SqlDataAdapter adapterscan2 = new SqlDataAdapter();
                    DataSet dsScan2 = new DataSet();
                    commandscan2 = new SqlCommand(
                         "INSERT INTO [dbo].[TWordDescription] ([Word],[Description],[CreDate],[CreUser],[UpdDate],[UpdUser],[IsDeleted],[DeletedBy],[DeletedDateTime]) VALUES " +
                         "(@Word1, @Description1, GETDATE(),'" + UserName + "', NULL, NULL, 0, NULL, NULL)", conn);
                    commandscan2.Parameters.Add("@Word1", SqlDbType.VarChar).Value = tbWord.Text;
                    commandscan2.Parameters.Add("@Description1", SqlDbType.VarChar).Value = rtbDescription.Text;
                    adapterscan2.SelectCommand = commandscan2;
                    adapterscan2.Fill(dsScan2, "SQL Temp Table");
                    adapterscan2.Dispose();
                    commandscan2.Dispose();


                    MessageBox.Show("New Word has been added!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    tbWord.Clear();
                    Check_WORDS_IN_DB();

                    SubmenuAdd.Visible = false;
                }
                else
                {
                    MessageBox.Show("WORD AND DESCRIPTION IS REQUIRED!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    Check_WORDS_IN_DB();
                    tbWord.Clear();
                    SubmenuAdd.Visible = false;
                    btnClose.Visible = false;
                    pictureBox4.Visible = false;
                }
            }

            catch (Exception ex)
            {
                SubmenuAdd.Visible = false;
                btnClose.Visible = false;
                pictureBox4.Visible = false;

                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
         private void button3_Click(object sender, EventArgs e)
        {
            
            
            UpdateDesc();
        }
        public void UpdateDesc()
        {
            try
            {
                if (cbList.Text != "")
                {

                    SqlConnection conn;
                    conn = new SqlConnection(ConnectionString);

                    
                    conn.Open();
                    //MessageBox.Show("conected");

                    SqlCommand commandscan;
                    SqlDataAdapter adapterscan = new SqlDataAdapter();
                    DataSet dsScan = new DataSet();
                    commandscan = new SqlCommand(
                         "UPDATE TWordDescription " +
                         "SET Word = @Word, Description = @Description, UpdUser = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "', " +
                         "UpdDate = GETDATE() " +
                         "WHERE Word like '%" + cbList.Text + "%'", conn);
                    commandscan.Parameters.Add("@Word", SqlDbType.VarChar).Value = tbWord.Text;
                    commandscan.Parameters.Add("@Description", SqlDbType.VarChar).Value = rtbDescription.Text;


                    adapterscan.SelectCommand = commandscan;
                    adapterscan.Fill(dsScan, "SQL Temp Table");
                    adapterscan.Dispose();
                    commandscan.Dispose();

                    MessageBox.Show("Description has been UPDATED!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    Check_WORDS_IN_DB();
                    tbWord.Clear();

                    SubmenuAdd.Visible = false;

 
                }
                else
                {
                    MessageBox.Show("NO ITEM SELECTED!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    Check_WORDS_IN_DB();
                    tbWord.Clear();

                    SubmenuAdd.Visible = false;
                    btnClose.Visible = false;
                    pictureBox4.Visible = false;
                }
            }

            catch (Exception ex)
            {
                SubmenuAdd.Visible = false;
                btnClose.Visible = false;
                pictureBox4.Visible = false;

                MessageBox.Show(ex.Message);
            }
        }


        public void Delete()
        {
            try
            {

                if (cbList.Text != "")
                {

                    SqlConnection conn;
                    conn = new SqlConnection(ConnectionString);

                    conn.Open();
                    //MessageBox.Show("conected");

                    SqlCommand commandscan;
                    SqlDataAdapter adapterscan = new SqlDataAdapter();
                    DataSet dsScan = new DataSet();
                    commandscan = new SqlCommand(
                         "UPDATE TWordDescription " +
                         "SET IsDeleted = 1, DeletedBy = '" + UserName + "', " +
                         "DeletedDateTime = GETDATE() " +
                         "WHERE Word like '%" + cbList.Text + "%'", conn);
                    adapterscan.SelectCommand = commandscan;
                    adapterscan.Fill(dsScan, "SQL Temp Table");
                    adapterscan.Dispose();
                    commandscan.Dispose();



                    MessageBox.Show("DELETE SUCCESSFULLY!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    Check_WORDS_IN_DB();
                    tbWord.Clear();
                }
                else {
                    MessageBox.Show("NO ITEM SELECTED!");
                    cbList.Refresh();
                    Check_WORDS_IN_DB();
                    rtbDescription.Clear();
                    cbList.Text = "";
                    cbList.Items.Clear();
                    Check_WORDS_IN_DB();
                    tbWord.Clear();
                    SubmenuAdd.Visible = false;
                    btnClose.Visible = false;
                    pictureBox4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                SubmenuAdd.Visible = false;
                btnClose.Visible = false;
                pictureBox4.Visible = false;

                MessageBox.Show(ex.Message);
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cbList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn;
                conn = new SqlConnection(ConnectionString);

                conn.Open();



                SqlCommand commandscan;
                SqlDataAdapter adapterscan = new SqlDataAdapter();
                DataSet dsScan = new DataSet();
                commandscan = new SqlCommand(
                     "SELECT * FROM TWORDDESCRIPTION " +
                     "WHERE Word like '" + cbList.Text + "'", conn);
                adapterscan.SelectCommand = commandscan;
                adapterscan.Fill(dsScan, "SQL Temp Table");
                adapterscan.Dispose();
                commandscan.Dispose();

                //if (dsScan.Tables.Count >= 0)
                //{
                //    MessageBox.Show("No Word Available.");
                //}

              //  rtbDescription.Text = dsScan.Tables[0].Rows[0]["Description"].ToString();
              //  tbWord.Text = dsScan.Tables[0].Rows[0]["Word"].ToString();

                if (cbList.Text == "")
                {
                    rtbDescription.Clear();
                    tbWord.Clear();
                }
            }
            catch (Exception)
            {
             //   MessageBox.Show("No Word Available.");
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

        private void tbWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bndAdd_Click(object sender, EventArgs e)
        {
            
            SubmenuAdd.Visible = true;
            pictureBox4.Visible = true;
            btnClose.Visible = true;

            cbList.Refresh();
            Check_WORDS_IN_DB();
            rtbDescription.Clear();
            cbList.Text = "";
            cbList.Items.Clear();
            Check_WORDS_IN_DB();
            tbWord.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SubmenuAdd.Visible = false;
            btnClose.Visible = false;
            pictureBox4.Visible = false;

            cbList.Refresh();
            Check_WORDS_IN_DB();
            rtbDescription.Clear();
            cbList.Text = "";
            cbList.Items.Clear();
            Check_WORDS_IN_DB();
            tbWord.Clear();
        }


        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }


        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //show you menu when user is logged 
            var Start1 = new Users();
            Start1.Show();
        }

        private void AdminView_Load(object sender, EventArgs e)
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

        private void AdminView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void cbList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                SqlConnection conn;
                conn = new SqlConnection(ConnectionString);

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
                SubmenuAdd.Visible = false;
                btnClose.Visible = false;
                pictureBox4.Visible = false;

                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbList.Text == "")
            {
                MessageBox.Show("Select Words");
            }
            else

            try { 
                SqlConnection conn;
                conn = new SqlConnection(ConnectionString);

                conn.Open();



                SqlCommand commandscan;
                SqlDataAdapter adapterscan = new SqlDataAdapter();
                DataSet dsScan = new DataSet();
                commandscan = new SqlCommand(
                     "SELECT * FROM TWORDDESCRIPTION " +
                     "WHERE Word like '" + cbList.Text + "' AND IsDeleted = 0", conn);
                adapterscan.SelectCommand = commandscan;
                adapterscan.Fill(dsScan, "SQL Temp Table");
                adapterscan.Dispose();
                commandscan.Dispose();

            //if (dsScan.Tables.Count == 0)
            //{
            //    MessageBox.Show("No Word Available.");
            //}

            rtbDescription.Text = dsScan.Tables[0].Rows[0]["Description"].ToString();
            tbWord.Text = dsScan.Tables[0].Rows[0]["Word"].ToString();

            if (cbList.Text == "")
                {
                    rtbDescription.Clear();
                    tbWord.Clear();
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
