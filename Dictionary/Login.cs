using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Configuration;
using Microsoft.SqlServer.Server;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dictionary
{
    public partial class Login : Form
    {
        string path = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public int error;
        public static int TriggerAdmin = 0;
        public static string UserLogin = "";

        [DllImport("advapi32.dll")]
        public static extern bool LogonUser(string name, string domain, string pass, int logType, int logpv, ref IntPtr pht);

        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //read out app.config Params
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, ConfigurationManager.AppSettings["DOMEIN"]);
            GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, ConfigurationManager.AppSettings["GROEP"]);
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, txtUserName.Text);

            IntPtr th = IntPtr.Zero;
            bool log = LogonUser(txtUserName.Text, ConfigurationManager.AppSettings["DOMEIN"], txtPassword.Text, 2, 0, ref th);
            if (log)

            {
                if (user != null)
                {
                    if (user.IsMemberOf(group))
                    {
                        
                        UserLogin = txtUserName.Text;

                        try
                        {
                            con.Open();
                            cmd = new SqlCommand("insert into TUserlogin (Username, LoginDate, Status) VALUES (@Name, getdate(), 'QCS')", con);
                            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtUserName.Text;
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        TriggerAdmin = 1;
                        this.Hide();
                        var Start = new formMenu();
                        Start.Show();
                     
                    }


                    else
                    {

                        try
                        {
                            con.Open();
                            cmd = new SqlCommand("insert into TUserlogin (Username, LoginDate, Status) VALUES (@Name, getdate(), 'VF')", con);
                            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtUserName.Text;
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        TriggerAdmin = 0;
                        this.Hide();
                        var Start = new Forms.formVFView();
                        Start.Show();
                  
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid User or Password");

            }

        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }



        private void txtUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}