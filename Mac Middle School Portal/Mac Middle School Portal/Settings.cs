using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Mac_Middle_School_Portal
{
    public partial class Theme : MaterialForm
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.colorScheme == "Blue")
                themeBox.SelectedIndex = 0; //blue
            else
                themeBox.SelectedIndex = 1; //red
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            if (themeBox.SelectedIndex == 0) //blue
            {
                Properties.Settings.Default.colorScheme = "Blue"; //sets color scheme to blue
                skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            }
        

            if (themeBox.SelectedIndex == 1) //red
            {
                Properties.Settings.Default.colorScheme = "Red"; //sets color scheme to red
                skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }

            Properties.Settings.Default.Save();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
