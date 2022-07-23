using Dictionary.DAL;
using Dictionary.Helpers;
using Dictionary.Models.Response;
using Dictionary.Variables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Manager
{
    public class MyManager : BaseDAL
    {
        private string dbname { get; set; }

        public MyManager(string dataSource, string initialCatalog)
        {
            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder(@"Data Source= " + dataSource + ";Initial Catalog = " + initialCatalog + MyVariables.AuthDB);

            dbname = connBuilder.DataSource;
        }


        #region "FETCH"

        public List<obj_SetupScanstreetInfo> GetDBServerInfo()
        {
            List<obj_SetupScanstreetInfo> results = new List<obj_SetupScanstreetInfo>();

            try
            {
                Connect();
                using (SqlCommand mycmd = new SqlCommand("SELECT * FROM TDocGroupGlobalize", conn))
                {
                    mycmd.Parameters.Clear();
                    using (SqlDataReader rdr = mycmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                var result = AssignDBServerInfo(rdr);
                                results.Add(result);
                            }
                        }
                        rdr.Close();
                        rdr.Dispose();
                    }
                    mycmd.Dispose();
                }
                Disconnect();
            }
            catch (Exception ex)
            {

                MyVariables.Monitortxt += ex.Message + MyVariables.newline;
                MyVariables.Errortxt += MyHelpers.createErrorMsg("GetScanstreetInfoList : " + ex.Message);
            }


            return results;
        }

        public obj_SetupScanstreetInfo GetScanstreetDBInfo(string groupname)
        {
            obj_SetupScanstreetInfo results = new obj_SetupScanstreetInfo();
            try
            {
                Connect();
                using (SqlCommand mycmd = new SqlCommand("SELECT * FROM TDocGroupGlobalize WHERE GroupName=@groupname", conn))
                {
                    mycmd.Parameters.Clear();
                    mycmd.Parameters.Add(new SqlParameter("@groupname", groupname));
                    using (SqlDataReader rdr = mycmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                results = AssignDBServerInfo(rdr);

                            }
                        }
                        rdr.Close();
                        rdr.Dispose();
                    }
                    mycmd.Dispose();
                }
                Disconnect();
            }
            catch (Exception ex)
            {
                MyVariables.Monitortxt += ex.Message + MyVariables.newline;
                MyVariables.Errortxt += MyHelpers.createErrorMsg("GetScanstreetInfo : " + ex.Message);
            }
            return results;
        }



        //public obj_TEOLMessageIdsResponse GetTEOLMsgIdInfo(string eolId)
        //{
        //    obj_TEOLMessageIdsResponse results = new obj_TEOLMessageIdsResponse();
        //    try
        //    {
        //        Connect();
        //        using (SqlCommand mycmd = new SqlCommand("select * from TEOLMessageIds where EOLMessageId = @EOLMessageId", conn))
        //        {
        //            mycmd.Parameters.Clear();
        //            mycmd.Parameters.Add(new SqlParameter("@EOLMessageId", eolId));
        //            using (SqlDataReader rdr = mycmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        results = AssignTEOLMessageIds(rdr);
        //                    }
        //                }
        //                rdr.Close();
        //                rdr.Dispose();
        //            }

        //            mycmd.Dispose();
        //        }
        //        Disconnect();
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("GetScanstreetInfo : " + ex.Message);
        //    }
        //    return results;
        //}


        //public obj_TEOLSendingLogsResponse GetTEOLSendingLogsInfo(string batchnumber)
        //{
        //    obj_TEOLSendingLogsResponse results = new obj_TEOLSendingLogsResponse();
        //    try
        //    {
        //        Connect();
        //        using (SqlCommand mycmd = new SqlCommand("select TOP 1 * from TEOLSendingLog where BatchNumber like '%" + batchnumber + "%'", conn))
        //        {

        //            using (SqlDataReader rdr = mycmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        results = AssignTEOLSendingLogs(rdr);
        //                    }
        //                }
        //                else
        //                {
        //                    MyVariables.eoldeleted_batchnumber.Add(new obj_BatchNumber { batchnumber = batchnumber });
        //                }

        //                rdr.Close();
        //                rdr.Dispose();
        //            }

        //            mycmd.Dispose();
        //        }
        //        Disconnect();
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("GetTEOLSendingLogsInfo : " + ex.Message);
        //    }
        //    return results;
        //}

        //public obj_TEOLDeletedResponse GetTEOLDeletedInfo(string batchnumber)
        //{
        //    obj_TEOLDeletedResponse results = new obj_TEOLDeletedResponse();
        //    try
        //    {
        //        Connect();
        //        using (SqlCommand mycmd = new SqlCommand("select TOP 1 * from TEOLDeleted where BatchNumber like '%" + batchnumber + "%'", conn))
        //        {

        //            using (SqlDataReader rdr = mycmd.ExecuteReader())
        //            {
        //                if (rdr.HasRows)
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        results = AssignTEOLDeleted(rdr);
        //                    }
        //                }
        //                else
        //                {
        //                    MyVariables.prod_batchnumber.Add(new obj_BatchNumber { batchnumber = batchnumber });
        //                }

        //                rdr.Close();
        //                rdr.Dispose();
        //            }

        //            mycmd.Dispose();
        //        }
        //        Disconnect();
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("GetTEOLSendingLogsInfo : " + ex.Message);
        //    }
        //    return results;
        //}


        #endregion


        #region "ASSIGN"

        private obj_SetupScanstreetInfo AssignDBServerInfo(SqlDataReader rdr)
        {
            obj_SetupScanstreetInfo result = new obj_SetupScanstreetInfo();
            try
            {
                result = new obj_SetupScanstreetInfo();
                if (rdr != null)
                {
                    result.Id = rdr["Id"] == DBNull.Value ? 0 : (int)rdr["Id"];
                    result.GroupName = rdr["GroupName"] == DBNull.Value ? "" : (string)rdr["GroupName"];
                    result.SMTPServer = rdr["SMTPServer"] == DBNull.Value ? "" : (string)rdr["SMTPServer"];
                    result.SenderFrom = rdr["SenderFrom"] == DBNull.Value ? "" : (string)rdr["SenderFrom"];
                    result.SenderTo = rdr["SenderTo"] == DBNull.Value ? "" : (string)rdr["SenderTo"];
                    result.SenderCC = rdr["SenderCC"] == DBNull.Value ? "" : (string)rdr["SenderCC"];
                    result.SenderBCC = rdr["SenderBCC"] == DBNull.Value ? "" : (string)rdr["SenderBCC"];
                    result.DBServer = rdr["DBServer"] == DBNull.Value ? "" : (string)rdr["DBServer"];
                    result.DBServerDOC = rdr["DBServerDOC"] == DBNull.Value ? "" : (string)rdr["DBServerDOC"];
                    result.DBServerMFO = rdr["DBServerMFO"] == DBNull.Value ? "" : (string)rdr["DBServerMFO"];
                    result.DBServerIMPORT = rdr["DBServerIMPORT"] == DBNull.Value ? "" : (string)rdr["DBServerIMPORT"];
                    result.DBServerMAIL = rdr["DBServerMAIL"] == DBNull.Value ? "" : (string)rdr["DBServerMAIL"];
                    result.DBServerCBW = rdr["DBServerCBW"] == DBNull.Value ? "" : (string)rdr["DBServerCBW"];
                    result.DBServerMFODOCLIB = rdr["DBServerMFODOCLIB"] == DBNull.Value ? "" : (string)rdr["DBServerMFODOCLIB"];
                    result.DBServerINGENICO = rdr["DBServerINGENICO"] == DBNull.Value ? "" : (string)rdr["DBServerINGENICO"];
                    result.DBServerMASTER = rdr["DBServerMASTER"] == DBNull.Value ? "" : (string)rdr["DBServerMASTER"];
                    result.DBServerYCS = rdr["DBServerYCS"] == DBNull.Value ? "" : (string)rdr["DBServerYCS"];
                    result.DBServerBACKUP = rdr["DBServerBACKUP"] == DBNull.Value ? "" : (string)rdr["DBServerBACKUP"];
                    result.DBServerEXACT = rdr["DBServerEXACT"] == DBNull.Value ? "" : (string)rdr["DBServerEXACT"];
                    result.DBServerRESTORE = rdr["DBServerRESTORE"] == DBNull.Value ? "" : (string)rdr["DBServerRESTORE"];
                    result.DBLogin = rdr["DBLogin"] == DBNull.Value ? "" : (string)rdr["DBLogin"];
                    result.DBPassword = rdr["DBPassword"] == DBNull.Value ? "" : (string)rdr["DBPassword"];
                    result.IsDisable = rdr["IsDisable"] == DBNull.Value ? false : (bool)rdr["IsDisable"];
                    result.UseLoadBalance = rdr["UseLoadBalance"] == DBNull.Value ? false : (bool)rdr["UseLoadBalance"];
                    result.SendBookTo = rdr["SendBookTo"] == DBNull.Value ? "" : (string)rdr["SendBookTo"];
                    result.GlobalPrefix = rdr["GlobalPrefix"] == DBNull.Value ? "" : (string)rdr["GlobalPrefix"];
                    result.TypeOfService = rdr["TypeOfService"] == DBNull.Value ? 0 : (int)rdr["TypeOfService"];
                    result.TypeOfModLib = rdr["TypeOfModLib"] == DBNull.Value ? 0 : (int)rdr["TypeOfModLib"];
                    result.UseArchiveRotation = rdr["UseArchiveRotation"] == DBNull.Value ? false : (bool)rdr["UseArchiveRotation"];
                    result.DBServerIBA = rdr["DBServerIBA"] == DBNull.Value ? "" : (string)rdr["DBServerIBA"];
                    result.DBServerIBADOCLIB = rdr["DBServerIBADOCLIB"] == DBNull.Value ? "" : (string)rdr["DBServerIBADOCLIB"];
                    result.DBServerIBAGlobal = rdr["DBServerIBAGlobal"] == DBNull.Value ? "" : (string)rdr["DBServerIBAGlobal"];
                    result.LyaIN = rdr["LyaIN"] == DBNull.Value ? "" : (string)rdr["LyaIN"];
                    result.LyaOUT = rdr["LyaOUT"] == DBNull.Value ? "" : (string)rdr["LyaOUT"];
                    result.isSpecial = rdr["isSpecial"] == DBNull.Value ? true : (bool)rdr["isSpecial"];
                    result.DBCount = rdr["DBCount"] == DBNull.Value ? 0 : (int)rdr["DBCount"];
                    result.isForMonitoring = rdr["isForMonitoring"] == DBNull.Value ? 0 : (int)rdr["isForMonitoring"];
                    //result.EnvironmentGuid = rdr["EnvironmentGuid"] == DBNull.Value ? "" : (string)rdr["EnvironmentGuid"];
                }
            }
            catch (Exception ex)
            {
                MyVariables.Monitortxt += ex.Message + MyVariables.newline;
                MyVariables.Errortxt += MyHelpers.createErrorMsg("AssignDatabaseInfo : " + ex.Message);
            }
            return result;
        }

        //private obj_TEOLMessageIdsResponse AssignTEOLMessageIds(SqlDataReader rdr)
        //{
        //    obj_TEOLMessageIdsResponse result = new obj_TEOLMessageIdsResponse();
        //    try
        //    {
        //        result = new obj_TEOLMessageIdsResponse();
        //        if (rdr != null)
        //        {
        //            result.Id = rdr["Id"] == DBNull.Value ? 0 : (int)rdr["Id"];
        //            result.EOLMessageId = rdr["EOLMessageId"] == DBNull.Value ? "" : (string)rdr["EOLMessageId"];
        //            result.DownloadDateTime = rdr["DownloadDateTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["DownloadDateTime"];
        //            result.ResetNow = rdr["ResetNow"] == DBNull.Value ? false : (bool)rdr["ResetNow"];
        //            result.IsUpdated = rdr["IsUpdated"] == DBNull.Value ? false : (bool)rdr["IsUpdated"];
        //            result.BatchNumber = rdr["BatchNumber"] == DBNull.Value ? "" : (string)rdr["BatchNumber"];
        //            result.MailMsgName = rdr["MailMsgName"] == DBNull.Value ? "" : (string)rdr["MailMsgName"];
        //            result.jv_Name = rdr["jv_Name"] == DBNull.Value ? "" : (string)rdr["jv_Name"];
        //            result.ServerName = rdr["ServerName"] == DBNull.Value ? "" : (string)rdr["ServerName"];
        //            result.JobName = rdr["JobName"] == DBNull.Value ? "" : (string)rdr["JobName"];
        //            result.IsDownloaded = rdr["IsDownloaded"] == DBNull.Value ? false : (bool)rdr["IsDownloaded"];
        //            result.IsEOLStatusNotSet = rdr["IsEOLStatusNotSet"] == DBNull.Value ? false : (bool)rdr["IsEOLStatusNotSet"];
        //            result.ResendSubmitted = rdr["ResendSubmitted"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["ResendSubmitted"];
        //            result.EOLUploadDateTime = rdr["EOLUploadDateTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["EOLUploadDateTime"];
        //            result.IsEmpty = rdr["IsEmpty"] == DBNull.Value ? false : (bool)rdr["IsEmpty"];
        //            result.ErrorMessage = rdr["ErrorMessage"] == DBNull.Value ? "" : (string)rdr["ErrorMessage"];
        //            result.UpdStatExactMsg = rdr["UpdStatExactMsg"] == DBNull.Value ? "" : (string)rdr["UpdStatExactMsg"];
        //            result.AddedTime = rdr["AddedTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["AddedTime"];
        //            result.IsEuropeProcessing = rdr["IsEuropeProcessing"] == DBNull.Value ? false : (bool)rdr["IsEuropeProcessing"];
        //            result.lastRetStatus = rdr["lastRetStatus"] == DBNull.Value ? "" : (string)rdr["lastRetStatus"];
        //            result.CountryCode = rdr["CountryCode"] == DBNull.Value ? "" : (string)rdr["CountryCode"];
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("AssignTEOLMessageIds : " + ex.Message);
        //    }
        //    return result;
        //}


        //private obj_TEOLSendingLogsResponse AssignTEOLSendingLogs(SqlDataReader rdr)
        //{
        //    obj_TEOLSendingLogsResponse result = new obj_TEOLSendingLogsResponse();
        //    try
        //    {
        //        result = new obj_TEOLSendingLogsResponse();
        //        if (rdr != null)
        //        {
        //            result.Id = rdr["Id"] == DBNull.Value ? 0 : (int)rdr["Id"];
        //            result.BatchNumber = rdr["BatchNumber"] == DBNull.Value ? "" : (string)rdr["BatchNumber"];
        //            result.fk_batch_id = rdr["fk_batch_id"] == DBNull.Value ? 0 : (int)rdr["fk_batch_id"];
        //            result.fk_header_id = rdr["fk_header_id"] == DBNull.Value ? 0 : (int)rdr["fk_header_id"];
        //            result.ErrorCode = rdr["ErrorCode"] == DBNull.Value ? "" : (string)rdr["ErrorCode"];
        //            result.ErrorDescription = rdr["ErrorDescription"] == DBNull.Value ? "" : (string)rdr["ErrorDescription"];
        //            result.LoggingDate = rdr["LoggingDate"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["LoggingDate"];
        //            result.EOLMessageId = rdr["EOLMessageId"] == DBNull.Value ? "" : (string)rdr["EOLMessageId"];
        //            result.JVName = rdr["JVName"] == DBNull.Value ? "" : (string)rdr["JVName"];
        //            result.InstantsName = rdr["InstantsName"] == DBNull.Value ? "" : (string)rdr["InstantsName"];
        //            result.AddedTime = rdr["AddedTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["AddedTime"];
        //            result.ResentFailed = rdr["ResentFailed"] == DBNull.Value ? false : (bool)rdr["ResentFailed"];
        //            result.isAddedToSplunk = rdr["isAddedToSplunk"] == DBNull.Value ? "" : (string)rdr["isAddedToSplunk"];
        //            result.senderMail = rdr["senderMail"] == DBNull.Value ? "" : (string)rdr["senderMail"];
        //            result.ExactMessage = rdr["ExactMessage"] == DBNull.Value ? "" : (string)rdr["ExactMessage"];
        //            result.TotalNumInvoices = rdr["TotalNumInvoices"] == DBNull.Value ? false : (bool)rdr["TotalNumInvoices"];
        //            result.retCode = rdr["retCode"] == DBNull.Value ? "" : (string)rdr["retCode"];
        //            result.AddedTime = rdr["AddedTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["AddedTime"];
        //            result.retMessage = rdr["retMessage"] == DBNull.Value ? "" : (string)rdr["retMessage"];
        //            result.PagingLog = rdr["PagingLog"] == DBNull.Value ? "" : (string)rdr["PagingLog"];
        //            result.exactrecipient = rdr["exactrecipient"] == DBNull.Value ? "" : (string)rdr["exactrecipient"];
        //            result.firmname = rdr["firmname"] == DBNull.Value ? "" : (string)rdr["firmname"];
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("AssignTEOLMessageIds : " + ex.Message);
        //    }
        //    return result;
        //}


        //private obj_TEOLDeletedResponse AssignTEOLDeleted(SqlDataReader rdr)
        //{
        //    obj_TEOLDeletedResponse result = new obj_TEOLDeletedResponse();
        //    try
        //    {
        //        result = new obj_TEOLDeletedResponse();
        //        if (rdr != null)
        //        {
        //            result.Id = rdr["Id"] == DBNull.Value ? 0 : (int)rdr["Id"];
        //            result.jointventure = rdr["jointventure"] == DBNull.Value ? "" : (string)rdr["jointventure"];
        //            result.batchnumber = rdr["batchnumber"] == DBNull.Value ? "" : (string)rdr["batchnumber"];
        //            result.startdateTime = rdr["startdateTime"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["startdateTime"];
        //            result.retCode = rdr["retCode"] == DBNull.Value ? "" : (string)rdr["retCode"];
        //            result.RetMessage = rdr["RetMessage"] == DBNull.Value ? "" : (string)rdr["RetMessage"];
        //            result.issent = rdr["issent"] == DBNull.Value ? false : (bool)rdr["issent"];
        //            result.updateStatusDate = rdr["updateStatusDate"] == DBNull.Value ? DateTime.Now : (DateTime)rdr["updateStatusDate"];
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MyVariables.Monitortxt += ex.Message + MyVariables.newline;
        //        MyVariables.Errortxt += MyHelpers.createErrorMsg("AssignTEOLMessageIds : " + ex.Message);
        //    }
        //    return result;
        //}

        #endregion


        #region "UPDATE"






        #endregion
    }
}
