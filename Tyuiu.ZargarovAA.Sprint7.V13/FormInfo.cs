using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ZargarovAA.Sprint7.V13
{
    public partial class FormInfo : Form
    {
        public FormInfo()

        {
            InitializeComponent();
        }

        private void buttonOKInfo_ZAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxBDInfo_ZAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxControlPanel_ZAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}