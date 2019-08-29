using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Mac_Middle_School_Portal
{
    partial class AboutBox1 : MaterialForm
    {
        public AboutBox1()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {

        }

        private void LabelCompanyName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tectrasystems.org");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
