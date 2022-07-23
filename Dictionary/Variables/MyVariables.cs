using Dictionary.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Variables
{
    static class MyVariables
    {
        public static string Monitortxt { get; set; }
        public static readonly string newline = "\r\n";
        public static string DBServer { get; set; }
        public static string Errortxt = "";
        public static string DataSource = @"SRV-L-SQLB18\I01";
        public static string InitialCatalog = "MFO_SETTINGS";
        public static string AuthDB = @";Persist Security Info=True;User ID=MFOLogin;Password=wr4e4pla*; TrustServerCertificate=True;";

        public static List<obj_SetupScanstreetInfo> DBGlobalizeInfoList = new List<obj_SetupScanstreetInfo>();
        public static obj_SetupScanstreetInfo ServerInfo = new obj_SetupScanstreetInfo();
    }
}
