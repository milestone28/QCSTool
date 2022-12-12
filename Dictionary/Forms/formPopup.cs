using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms
{


    public partial class formPopup : Form
    {

        public static string words;
        public formPopup()
        {
            InitializeComponent();
            label1.Text = words;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
