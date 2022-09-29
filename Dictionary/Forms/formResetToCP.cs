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
using Dictionary.Variables;
using Dictionary.Manager;
using Dictionary.Models.Response;
using Dictionary.Helpers;

namespace Dictionary.Forms
{
    public partial class formResetToCP : Form
    {

        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public string UserName = "Unknown";
        public int ID;
        public int ID_FE;
        string _batchnumber;
        public string _status;
        public int _typeOfService;
        public string _databaseBE;
        public string _databaseFE;
        public int _doctypeNumber;
        public int _moduleNumber;
        public static DataSet __ds;
        public static DataTable _dataTable;
        public static SqlConnection con;
        public static SqlDataAdapter adpt;
        DataTable dt;

        public static string batchnumberFE;
        public static string companyID;

        public static string _batchnumberPDF;
        public static string _LyaOutPDF;

        public formResetToCP()
        {
            InitializeComponent();
            lblUser.Text = formMenu.MainUserName;
            con = new SqlConnection(path);
            UserName = formMenu.MainUserName;
            displayList();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            var Start = new formMenu();
            Start.ShowDialog();
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

        private void btnScan_Click(object sender, EventArgs e)
        {
           if (cmbScanstreet.Text == "")
            {
                MessageBox.Show(" Select Scanstreet ");
            }
           
           else
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show(" Input Batchnumber ");
                }

                else
                { 
                        Tlogging();
                }
            }
        }

        private void manageServersToolStripMenuItem_Click(object sender, EventArgs e)
        {
               if (lblUser.Text == "SRV\admgyu")
            {
                var Start = new Forms.formServerManagement();
                Start.Show();
            }
               else
            {
                MessageBox.Show(" Unauthorize ");
            }
        }


        public void displayList()
        {
            try
            {
                MyManager mgr = new MyManager(MyVariables.DataSource, MyVariables.InitialCatalog);
                MyVariables.DBGlobalizeInfoList = mgr.GetDBServerInfo();
                foreach (obj_SetupScanstreetInfo rr in MyVariables.DBGlobalizeInfoList)
                {
                    cmbScanstreet.Items.Add(rr.Id + " - " + rr.GroupName);
                    cmbScanstreet.SelectedIndex = 0;

                    //cmb_opsList.Items.Add(rr.Id + " - " + rr.GroupName);
                    //cmb_opsList.SelectedIndex = 0;
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();

                adpt = new SqlDataAdapter("select Groupname, DBserverBE, typeofservice from tdocgroup order by typeofservice asc", con);
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

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            btnScan.Enabled = true;
            string copyBatchnumber = Clipboard.GetText();
           
            _batchnumber = copyBatchnumber.Replace("111_", "").Replace("110_", "").Replace("101_", "").Replace("011_", "").Replace("[a-z]", "").Replace("[A-Z]", "").Replace(" ", "").Replace("000_", "").Replace("010_", "").Replace("100_", "").Replace("001_", "");

            Regex regex = new Regex("^[0-9,_]+$");

            txtSearch.Text = _batchnumber;

            if (regex.IsMatch(_batchnumber))
            {
                txtSearch.Text = _batchnumber;
                btnScan.Enabled = true;
            }


            else
            {
                MessageBox.Show("invalid batchnumber");
            }
        }

        public void searchOnDatabasesFE(string queryFE)
        {

            try
            {
                searchDatabaseFE con1 = new searchDatabaseFE(@"Data Source = " + _databaseFE + ";Initial Catalog = M01_MODULES; Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                searchDatabaseFE con2 = new searchDatabaseFE(@"Data Source = " + _databaseFE + ";Initial Catalog = M02_MODULES; Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                searchDatabaseFE con3 = new searchDatabaseFE(@"Data Source = " + _databaseFE + ";Initial Catalog = M03_MODULES; Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                searchDatabaseFE con4 = new searchDatabaseFE(@"Data Source = " + _databaseFE + ";Initial Catalog = M04_MODULES; Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                searchDatabaseFE con5 = new searchDatabaseFE(@"Data Source = " + _databaseFE + ";Initial Catalog = M05_MODULES; Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");

                searchDatabaseFE[] cons = new searchDatabaseFE[] { con1, con2, con3, con4, con5 };

                var serverFE = 1; //var for the server 

                foreach (searchDatabaseFE con in cons)
                {
                    var result = con.execute(queryFE);
                    if (result)
                    {

                        if (result == true)
                        {
                            _moduleNumber = serverFE;
                              break; //----- pinaka importante sa tanan pota
                        }

                        if (serverFE == 6)
                        {
                            MessageBox.Show(" batchFE not found ");
                            break;
                        }


                    }


                    serverFE++; // this will locate the server from foreach
                }
            }


            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }

        }

        public void searchInTScansServer()
        {


              this.searchOnDatabasesFE("select * from TScansMonitor where BatchNumber like '%" + tbBatchNumber.Text + "%'");

              if (batchnumberFE != "")
             {
                UserLogsDeleteBatchFE();
             }
              

        }


        public void searchOnDatabases(string query)
        {

            try
            {

             
                searchDatabase con1 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC01_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con2 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC02_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con3 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC03_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con4 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC04_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con5 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC05_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);

                searchDatabase con6 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC06_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con7 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC07_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con8 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC08_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con9 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC09_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);
                searchDatabase con10 = new searchDatabase(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC10_" + _typeOfService.ToString().PadLeft(6, '0') + MyVariables.AuthDB);

                searchDatabase[] cons = new searchDatabase[] { con1, con2, con3, con4, con5, con6, con7, con8, con9, con10 };

                var server = 1; //var for the server 
               
                foreach (searchDatabase con in cons)
                {
                 
                        var result = con.execute(query);
                        if (result)
                        {

                            if (_dataTable.Rows.Count >= 1)
                            {
                                    _doctypeNumber = server;

                                    break; //----- pinaka importante sa tanan pota

                               }

                             if (server == 11)
                            {
                                MessageBox.Show(" batch not found ");
                                break;
                            }


                        }
                  

                    server++; // this will locate the server from foreach
           
                }
               
            }


            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
           
        }


        public void Tlogging()
        {
            this.searchOnDatabases("select ID, BatchNumber, JointVenture, DossierCode, DocFileName, DocType, ApplicationName from TLogging where BatchNumber like '%" + txtSearch.Text+"%'");

            dgvList.DataSource = _dataTable;
            //dgvList.Columns["ID"].Visible = false;
            lblServernameBE.Text = _databaseBE;
            lblServernameFE.Text = _databaseFE;
            ID = int.Parse(dgvList.Rows[0].Cells[0].Value.ToString());
            tbBatchNumber.Text = dgvList.Rows[0].Cells[1].Value.ToString().Replace("111_", "").Replace("110_", "").Replace("101_", "").Replace("011_", "").Replace("[a-z]", "").Replace("[A-Z]", "").Replace(" ", "").Replace("000_", "").Replace("010_", "").Replace("100_", "").Replace("001_", "");
            tbJointVenture.Text = dgvList.Rows[0].Cells[2].Value.ToString();
            tbDossierCode.Text = dgvList.Rows[0].Cells[3].Value.ToString();
            tbDocFilename.Text = dgvList.Rows[0].Cells[4].Value.ToString();
            tbDocType.Text = dgvList.Rows[0].Cells[5].Value.ToString();
            tbApplicationName.Text = dgvList.Rows[0].Cells[6].Value.ToString();
            _batchnumberPDF = tbBatchNumber.Text;

            if (tbApplicationName.Text == "cas")
            {
                btnResetToCp.Enabled = false;
                tbApplicationName.BackColor = Color.Green;
            }
            else
            {
                btnResetToCp.Enabled = true;
                tbApplicationName.BackColor = Color.Red;
            }

            if (_dataTable.Rows.Count == 0)
            {
                dgvList.DataSource = null;

            }
            btnViewPdf.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        //public void getServerDetails(string serverInfo)
        //{
        //    try
        //    {
        //        con.Open();

        //       DataSet ds = new DataSet();

        //        adpt = new SqlDataAdapter(@"select * from [SRV-L-SQLB18\I01].MFO_SETTINGS.dbo.TDocGroup where GroupName = '" + serverInfo+"'", con);
        //        adpt.Fill(ds);

        //        _typeOfService = int.Parse(ds.Tables[0].Rows[0]["TypeOfService"].ToString());
        //        _databaseBE = ds.Tables[0].Rows[0]["DBServerBE"].ToString();
        //        _databaseFE = ds.Tables[0].Rows[0]["DBServerFE"].ToString();
        //        _LyaOutPDF = ds.Tables[0].Rows[0]["LYAOUT"].ToString();
        //        con.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }

        //}


        public void clear()
        {
            lblServernameBE.Text = "";
            tbBatchNumber.Text = "";
            tbJointVenture.Text = "";
            tbDossierCode.Text = "";
            tbDocFilename.Text = "";
            tbDocType.Text = "";
            tbApplicationName.Text = "";
            txtSearch.Text = "";
            _typeOfService = 000000;
            lblServernameFE.Text = "";
            cmbScanstreet.Text = "";
            dgvList.DataSource = null;
        }

        private void btnSetToDC_Click(object sender, EventArgs e)
        {
            if (cmbScanstreet.Text == "" || txtSearch.Text == "" || tbBatchNumber.Text == "")
            {
                MessageBox.Show(" input errors ");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show( "Are You Sure?", "Reset To CP", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetToCP();
                    btnScan.PerformClick();
                    _status = "ResetToCP";
                    UserLogsResetToCP();
                }

            }
        }


        public void resetToCP()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC" + _doctypeNumber.ToString().PadLeft(2, '0') + "_" + _typeOfService.ToString().PadLeft(6, '0') + ";Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                con.Open();


                SqlCommand  cmd = new SqlCommand("exec sp_Infra_ResetToDocpage '" + tbBatchNumber.Text + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Batch successfully back to cp ");

                con.Close();
                btnResetToCp.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void UserLogsResetToCP()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();

                cmd = new SqlCommand("insert into USER_REPORTING (UsernameRTCP, UpdateDateRTCP, StatusRTCP, batchNumberRTCP, ScanstreetRTCP, DossierCodeRTCP) VALUES " +
                                                             "(@UsernameRTCP, getdate(), @StatusRTCP, @batchNumberRTCP, @ScanstreetRTCP, @DossierCodeRTCP)", con);

                cmd.Parameters.Add("@UsernameRTCP", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@batchNumberRTCP", SqlDbType.VarChar).Value = tbBatchNumber.Text;
                cmd.Parameters.Add("@StatusRTCP", SqlDbType.VarChar).Value = _status;
                cmd.Parameters.Add("@ScanstreetRTCP", SqlDbType.VarChar).Value = cmbScanstreet.Text;
                cmd.Parameters.Add("@DossierCodeRTCP", SqlDbType.VarChar).Value = tbDossierCode.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure?", "Delete Batch", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // UserLogsDeleteBatchBE();
              

                if (_typeOfService == 5 || _typeOfService == 13)
                {
                    UserLogsDeleteBatchBE();
                 
                }
                else
                {
                    searchInTScansServer();
                    UserLogsDeleteBatchFE();
                    UserLogsDeleteBatchBE();
                }

            }
            
        }



        public void UserLogsDeleteBatchBE()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source = " + _databaseBE + ";Initial Catalog = MFO_DOC" + _doctypeNumber.ToString().PadLeft(2, '0') + "_" + _typeOfService.ToString().PadLeft(6, '0') + ";Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                con.Open();


                SqlCommand cmd = new SqlCommand(@"INSERT  [DTA-L-SQLB01\D01].MFO_DICTIONARY.dbo.TLogging (BatchNumber, JointVenture, DossierCode, ApplicationName,DocFileName,DeletedDate, DeletedBy, Scanstreet) " +
                    "SELECT BatchNumber, JointVenture, DossierCode, ApplicationName, DocFileName, " +
                    "getdate(), @UsernameRTCP, @Scanstreet FROM TLogging where BatchNumber like '%" + tbBatchNumber.Text + "%'", con);

                cmd.Parameters.Add("@UsernameRTCP", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@Scanstreet", SqlDbType.VarChar).Value = cmbScanstreet.Text;
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                SqlCommand cmd2 = new SqlCommand(@"exec sp_Infra_DeleteBatch '"+tbBatchNumber.Text+"'", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                btnDelete.Enabled = false;
                btnResetToCp.Enabled = false;
                btnScan.Enabled = false;
                clear();
                MessageBox.Show(" Batchnumber Deleted ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UserLogsDeleteBatchFE()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source = " + _databaseFE + ";Initial Catalog = M" + _moduleNumber.ToString().PadLeft(2, '0') + "_MODULES;Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                con.Open();


                SqlCommand cmd = new SqlCommand(@"INSERT  [DTA-L-SQLB01\D01].MFO_DICTIONARY.dbo.TScansMonitor (fk_company_id, BatchNumber, fk_doctype_id, fk_user_id,Status,fk_journal_id, PageCount, VerifiedCount, IsInvoice, DeletedDate, DeletedBy, Scanstreet) " +
                    "SELECT fk_company_id, BatchNumber, fk_doctype_id, fk_user_id,Status,fk_journal_id, PageCount, VerifiedCount, IsInvoice, getdate(), @UsernameRTCP, @Scanstreet"  +
                    " FROM TScansMonitor where BatchNumber like '%" + tbBatchNumber.Text + "%'", con);

                cmd.Parameters.Add("@UsernameRTCP", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@Scanstreet", SqlDbType.VarChar).Value = cmbScanstreet.Text;
                cmd.ExecuteNonQuery();
                con.Close();

                DeleteBatchFE();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void DeleteBatchFE()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source = " + _databaseFE + ";Initial Catalog = M" + _moduleNumber.ToString().PadLeft(2, '0') + "_MODULES;Persist Security Info = True; User ID = MFOLogin; Password = wr4e4pla*");
                con.Open();


                SqlCommand cmd = new SqlCommand(@"exec sp_infra_DeleteBatchFE '" + tbBatchNumber.Text + "'", con);


                cmd.ExecuteNonQuery();
                con.Close();

                //btnDelete.Enabled = false;
                //btnResetToCp.Enabled = false;
                //btnScan.Enabled = false;
                //clear();
                //MessageBox.Show(" Batchnumber Deleted ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnViewPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you get error please install adobe reader");
            var Start = new Forms.formPDFVIEWER();
             Start.Show();
        }

        private void cmbScanstreet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            var serverValue = int.Parse(cmbScanstreet.Text.Substring(0, 2));

            try
            {
                foreach (obj_SetupScanstreetInfo rr in MyVariables.DBGlobalizeInfoList)
                {
                    if (serverValue == rr.Id)
                    {
                                _typeOfService = rr.TypeOfService;
                                _databaseBE = rr.DBServerDOC;
                                _databaseFE = rr.DBServer;
                                _LyaOutPDF = rr.LyaOUT;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                MyVariables.Errortxt += MyHelpers.createErrorMsg("cmbScanstreet_SelectedIndexChanged : " + ex.ToString());
            }
        }
    }
}
