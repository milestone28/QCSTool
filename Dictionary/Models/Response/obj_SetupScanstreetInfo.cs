using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Models.Response
{
    public class obj_SetupScanstreetInfo
    {
        private int _Id;
        private string _GroupName;
        private string _SMTPServer;
        private string _SenderFrom;
        private string _SenderTo;
        private string _SenderCC;
        private string _SenderBCC;
        private string _DBServer;
        private string _DBServerDOC;
        private string _DBServerMFO;
        private string _DBServerIMPORT;
        private string _DBServerMAIL;
        private string _DBServerCBW;
        private string _DBServerMFODOCLIB;
        private string _DBServerINGENICO;
        private string _DBServerMASTER;
        private string _DBServerYCS;
        private string _DBServerBACKUP;
        private string _DBServerEXACT;
        private string _DBServerRESTORE;
        private string _DBLogin;
        private string _DBPassword;
        private bool _IsDisable;
        private bool _UseLoadBalance;
        private string _SendBookTo;
        private string _GlobalPrefix;
        private int _TypeOfService;
        private int _TypeOfModLib;
        private bool _UseArchiveRotation;
        private string _DBServerIBA;
        private string _DBServerIBADOCLIB;
        private string _DBServerIBAGlobal;
        private string _LyaIN;
        private string _LyaOUT;
        private bool _isSpecial;
        private int _DBCount;
        private int _isForMonitoring;
        private string _EnvironmentGuid;




        [Key]
        [Column(Order = 1)]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string GroupName
        {
            get { return _GroupName; }
            set { _GroupName = value; }
        }

        public string SMTPServer
        {
            get { return _SMTPServer; }
            set { _SMTPServer = value; }
        }

        public string SenderFrom
        {
            get { return _SenderFrom; }
            set { _SenderFrom = value; }
        }

        public string SenderTo
        {
            get { return _SenderTo; }
            set { _SenderTo = value; }
        }

        public string SenderCC
        {
            get { return _SenderCC; }
            set { _SenderCC = value; }
        }

        public string SenderBCC
        {
            get { return _SenderBCC; }
            set { _SenderBCC = value; }
        }

        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        public string DBServerDOC
        {
            get { return _DBServerDOC; }
            set { _DBServerDOC = value; }
        }


        public string DBServerMFO
        {
            get { return _DBServerMFO; }
            set { _DBServerMFO = value; }
        }

        public string DBServerIMPORT
        {
            get { return _DBServerIMPORT; }
            set { _DBServerIMPORT = value; }
        }

        public string DBServerMAIL
        {
            get { return _DBServerMAIL; }
            set { _DBServerMAIL = value; }
        }

        public string DBServerCBW
        {
            get { return _DBServerCBW; }
            set { _DBServerCBW = value; }
        }

        public string DBServerMFODOCLIB
        {
            get { return _DBServerMFODOCLIB; }
            set { _DBServerMFODOCLIB = value; }
        }

        public string DBServerINGENICO
        {
            get { return _DBServerINGENICO; }
            set { _DBServerINGENICO = value; }
        }

        public string DBServerMASTER
        {
            get { return _DBServerMASTER; }
            set { _DBServerMASTER = value; }
        }

        public string DBServerYCS
        {
            get { return _DBServerYCS; }
            set { _DBServerYCS = value; }
        }

        public string DBServerBACKUP
        {
            get { return _DBServerBACKUP; }
            set { _DBServerBACKUP = value; }
        }

        public string DBServerEXACT
        {
            get { return _DBServerEXACT; }
            set { _DBServerEXACT = value; }
        }

        public string DBServerRESTORE
        {
            get { return _DBServerRESTORE; }
            set { _DBServerRESTORE = value; }
        }

        public string DBLogin
        {
            get { return _DBLogin; }
            set { _DBLogin = value; }
        }

        public string DBPassword
        {
            get { return _DBPassword; }
            set { _DBPassword = value; }
        }


        public bool IsDisable
        {
            get { return _IsDisable; }
            set { _IsDisable = value; }
        }

        public bool UseLoadBalance
        {
            get { return _UseLoadBalance; }
            set { _UseLoadBalance = value; }
        }

        public string SendBookTo
        {
            get { return _SendBookTo; }
            set { _SendBookTo = value; }
        }

        public string GlobalPrefix
        {
            get { return _GlobalPrefix; }
            set { _GlobalPrefix = value; }
        }

        public int TypeOfService
        {
            get { return _TypeOfService; }
            set { _TypeOfService = value; }
        }

        public int TypeOfModLib
        {
            get { return _TypeOfModLib; }
            set { _TypeOfModLib = value; }
        }

        public bool UseArchiveRotation
        {
            get { return _UseArchiveRotation; }
            set { _UseArchiveRotation = value; }
        }

        public string DBServerIBA
        {
            get { return _DBServerIBA; }
            set { _DBServerIBA = value; }
        }

        public string DBServerIBADOCLIB
        {
            get { return _DBServerIBADOCLIB; }
            set { _DBServerIBADOCLIB = value; }
        }

        public string DBServerIBAGlobal
        {
            get { return _DBServerIBAGlobal; }
            set { _DBServerIBAGlobal = value; }
        }

        public string LyaIN
        {
            get { return _LyaIN; }
            set { _LyaIN = value; }
        }

        public string LyaOUT
        {
            get { return _LyaOUT; }
            set { _LyaOUT = value; }
        }

        public bool isSpecial
        {
            get { return _isSpecial; }
            set { _isSpecial = value; }
        }

        public int DBCount
        {
            get { return _DBCount; }
            set { _DBCount = value; }
        }

        public int isForMonitoring
        {
            get { return _isForMonitoring; }
            set { _isForMonitoring = value; }
        }

        public string EnvironmentGuid
        {
            get { return _EnvironmentGuid; }
            set { _EnvironmentGuid = value; }
        }


    }
}
