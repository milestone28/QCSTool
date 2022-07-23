using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Dictionary.Forms
{
    public partial class formPDFVIEWER : Form
    {
        //1st
        public string BatchNumber;
        public string PathSource;
        //  public string PathTarget = @"\\srv-l-fs03\D$\DATA\Departments\DATAEXERIUS\_QCSToolTemp\";
        public string PathTarget = @"E:\DATAEXERIUS\_QCSToolTemp\";
        public string UserName = "Unknown";

        //2nd
        public string _filePathName;
        public string _fileName;

        //3rd
        public string _fileTargetPathName;

        public formPDFVIEWER()
        {
            InitializeComponent();
            BatchNumber = Forms.formResetToCP._batchnumberPDF;
            PathSource = Forms.formResetToCP._LyaOutPDF;
            UserName = formMenu.MainUserName;
            lblUsername.Text = UserName;
        }

    

        private void btnScan_Click(object sender, EventArgs e)
        {
            lblBatchnumber.Text = BatchNumber;
            lblPath.Text = PathSource;


            // 1st Search the filename
            string resultFilePath;

            if (findFilePath(PathSource, "*" + BatchNumber + ".zip", out resultFilePath))
            {

                lblFileNamePathSource.Text = resultFilePath;
                _filePathName = resultFilePath;

                // 2nd Get FileName
                string resultFileName;
                resultFileName = Path.GetFileName(_filePathName);
                lblFileNameSource.Text = _fileName;
                _fileName = resultFileName;

                // 3rd copy the .zip
                CopyFile();

                //4th extract the zip
                extractZip();

                //5th located the .pdf target path OR open file .pdf
                findPDFfileName();
                 MessageBox.Show("kindly check the filename above if correct batchnumber if no result scan again");
            }
        }

    private bool findFilePath(string directoryPath, string fileName, out string result)
        {
            // string fullPath = Path.Combine(directoryPath, fileName);
            string fullPath = Path.Combine(fileName);
            if (File.Exists(fullPath))
            {
                result = fullPath;
                return true;
            }

            // note this initialization required here
            // since 'result has been passed by reference using 'out
            result = string.Empty;

            try
            {
                result = Directory.EnumerateFiles(directoryPath, fileName, SearchOption.AllDirectories).First();
            }
            catch
            {
                // something went wrong ...
              //  MessageBox.Show(" File not found ");
                return false;
            }

            // valid result
            return true;
        }


        public void CopyFile()
        {
            string sourceFile = System.IO.Path.Combine(PathSource, _fileName);
            string destFile = System.IO.Path.Combine(PathTarget+UserName, _fileName);
          

            System.IO.Directory.CreateDirectory(PathTarget + UserName);

            System.IO.File.Copy(sourceFile, destFile, true);

        }

        public void extractZip()
        {
            string ExistingZipFile = PathTarget + UserName +"\\"+ _fileName;
            string TargetDirectory = PathTarget + UserName;


            using (ZipFile zip = ZipFile.Read(ExistingZipFile))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(TargetDirectory, ExtractExistingFileAction.OverwriteSilently);  // overwrite == true
                }
            }
        }

        public void findPDFfileName()
        {
            string resultFilePath;

            if (findFilePath(PathTarget + UserName, "*.pdf", out resultFilePath))
            {
                _fileTargetPathName = resultFilePath;

                //6th open PDF in form
                showPDF();
            }

            // converting .jpg .tiff .png

            if (findFilePath(PathTarget, "*.jpg", out resultFilePath) || findFilePath(PathTarget, "*.png", out resultFilePath) || findFilePath(PathTarget, "*.tiff", out resultFilePath))
            {
                string _fileToConvert;
                // 1st get target Path
                _fileToConvert = resultFilePath;


                // 2nd Get FileName without extension
                string resultFileName;
                resultFileName = Path.ChangeExtension(_fileToConvert, null);


                // 3rd convertion
                ConvertImageToPdf(_fileToConvert, resultFileName + ".pdf");

                _fileTargetPathName = resultFileName + ".pdf";

                //6th open PDF in form
                showPDF();
            }
        }


        public void showPDF()
        {
            axAcroPDF1.src = _fileTargetPathName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            delete();
            this.Close();
        }


        public void delete()
        {
            // Delete a directory and all subdirectories with Directory static method...
            if (System.IO.Directory.Exists(PathTarget + UserName))
            {
                try
                {
                    System.IO.Directory.Delete(PathTarget + UserName, true);
                }

                catch (System.IO.IOException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        public static void ConvertImageToPdf(string srcFilename, string dstFilename)
        {
            iTextSharp.text.Rectangle pageSize = null;

            using (var srcImage = new Bitmap(srcFilename))
            {
                pageSize = new iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height);
            }
            using (var ms = new MemoryStream())
            {
                var document = new iTextSharp.text.Document(pageSize, 0, 0, 0, 0);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression();
                document.Open();
                var image = iTextSharp.text.Image.GetInstance(srcFilename);
                document.Add(image);
                document.Close();

                File.WriteAllBytes(dstFilename, ms.ToArray());
            }
        }

  
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            delete();
            this.Close();
        }

    }
}
