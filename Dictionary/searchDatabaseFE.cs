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

namespace Dictionary.Forms
{
    public class searchDatabaseFE
    {

        public string path = "";


        public searchDatabaseFE(string connectionStringFE)
        {
            this.path = connectionStringFE;
            // create a database connection perhaps
        }


        public bool execute(string queryFE)
        {

            SqlConnection con = new SqlConnection(path);
            try
            {
                con.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adpt = new SqlDataAdapter(queryFE, con);
                adpt.Fill(ds);

                Forms.formResetToCP.batchnumberFE = ds.Tables[0].Rows[0]["BatchNumber"].ToString();
                Forms.formResetToCP.companyID = ds.Tables[0].Rows[0]["fk_company_id"].ToString();

                con.Close();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        internal object execute(object query)
        {
            throw new NotImplementedException();
        }

    }
}
