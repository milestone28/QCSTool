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
    public class searchDatabase
    {

        public string path = "";


        public searchDatabase(string connectionString)
        {
            this.path = connectionString;
            // create a database connection perhaps
        }


        public bool execute(string query)
    {

            SqlConnection con = new SqlConnection(path);
            try
            {
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(query, con);



                DataTable dt = new DataTable();
                adpt.Fill(dt);


                Forms.formResetToCP._dataTable = dt;


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
