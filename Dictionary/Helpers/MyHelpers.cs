using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Helpers
{
    public static class MyHelpers
    {
        public static readonly string newline = "\r\n";

        public static string createErrorMsg(string message)
        {
            string returnmsg = "";
            returnmsg = DateTime.Now.ToString() + newline;
            returnmsg += message + newline;
            return returnmsg;
        }

        public static void WriteLogFile(string message)
        {
            string mypath = Application.StartupPath;
            bool issavelogs = false;

            FileStream file;
            StreamWriter writer;
            Directory.CreateDirectory(mypath + @"\ErrorLogs\" + DateTime.Now.ToString("yyyyMMdd"));
            do
            {
                try
                {
                    string filename = mypath + @"\ErrorLogs\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + "Logs_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.Hour.ToString() + ".txt";
                    file = new FileStream(filename, FileMode.Append, FileAccess.Write);
                    writer = new StreamWriter(file);
                    writer.WriteLine(message);
                    writer.Close();
                    writer.Dispose();
                    file.Close();
                    file.Dispose();
                    issavelogs = true;
                }
                catch
                {
                }
            } while (issavelogs == false);
        }

    }
}
