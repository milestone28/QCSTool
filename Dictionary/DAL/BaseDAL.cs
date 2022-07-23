using Dictionary.Variables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.DAL
{
    public class BaseDAL : IDisposable
    {


        protected SqlConnection conn;
        protected SqlTransaction trans;
        private bool hastrans = false;
        protected int connretries;
        protected int conncounter;

        //connection retries is set to 3 attempts
        public BaseDAL()
        {
            conn = null;
            trans = null;
            conncounter = 3;
        }

        protected internal bool Connect(bool isWithTrans = false)
        {
            bool valHastrans = hastrans;
            bool functionReturnValue = false;
            try
            {
                functionReturnValue = false;
                connretries = 0;
                if (conn == null)
                {

                    conn = new SqlConnection(@"Data Source= " + MyVariables.DataSource + ";Initial Catalog = " + MyVariables.InitialCatalog + MyVariables.AuthDB);
                    //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconn"].ConnectionString);
                }
                dbConnect();
                functionReturnValue = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return functionReturnValue;
        }

        private void dbConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                //'if there is error retry base on the counter.
                if (connretries == conncounter)
                {
                    throw ex;
                }
                else
                {
                    connretries += 1;
                    dbConnect();
                }
            }
        }

        protected internal void BeginTransaction()
        {

            try
            {
                trans = conn.BeginTransaction();
                hastrans = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected internal void CommitTransaction()
        {
            try
            {
                trans.Commit();
                hastrans = false;
                trans.Dispose();
                trans = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected internal void RollbackTransaction()
        {
            try
            {
                trans.Rollback();
                hastrans = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected internal bool Disconnect()
        {
            bool functionReturnValue = false;
            try
            {
                functionReturnValue = false;
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }
                functionReturnValue = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return functionReturnValue;
        }

        //protected internal bool ExecuteNonQuery(string strqry, List<SqlParameter> paramlist)
        //{
        //    bool functionReturnValue = false;
        //    try
        //    {
        //        functionReturnValue = false;
        //        SqlParameter mycmd = default(SqlParameter);
        //        if (trans != null)
        //        {
        //            mycmd = new SqlParameter(strqry, conn, trans);
        //        }
        //        else
        //        {
        //            mycmd = new SqlParameter(strqry, conn);
        //        }
        //        if (paramlist.Count > 0)
        //        {
        //            var _with1 = mycmd.Parameters;
        //            _with1.Clear();
        //            foreach (SqlParameter param in paramlist)
        //            {
        //                _with1.Add(param);
        //            }
        //        }
        //        if (mycmd.ExecuteNonQuery() > 0)
        //        {
        //            functionReturnValue = true;
        //        }
        //        mycmd.Dispose();
        //        functionReturnValue = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaction();
        //        throw ex;
        //    }
        //    return functionReturnValue;
        //}







        #region "IDisposable Support"
        // To detect redundant calls
        private bool disposedValue;

        // IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    conn.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                // TODO: set large fields to null.
            }
            this.disposedValue = true;
        }

        // TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        //Protected Overrides Sub Finalize()
        //    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        //    Dispose(False)
        //    MyBase.Finalize()
        //End Sub

        // This code added by Visual Basic to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
