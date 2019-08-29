using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Xml;
using System.Threading;
using System.Drawing;

namespace Mac_Middle_School_Portal
{
    public partial class Form1 : MaterialForm
    {
        static int ready = 0;

        public Form1()
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Dpi;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            memoryLbl.Text = Properties.Settings.Default.lastProgram;

            if (Properties.Settings.Default.colorScheme == "Blue")
            {
                skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            }
            else
            {
                skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
        }

        private void Portal_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (button != goBtn)
                    {
                        ControlExtension.Draggable(button, true);
                    }
                }
            }
            
            //when form loads
            memLoad();
            usernameLbl.Text = "Welcome back, " + Environment.UserName + "!";
            ready = 1;
            macNews.AllowNavigation = true;
            
        }
        
        public void memLoad()
        {
            label1.Text = "Pick up where you left off";

            if (memoryLbl.Text == "Google Classroom")
            {
                memoryPic.Image = Properties.Resources.Classroom;
            }

            else if (memoryLbl.Text == "Maconaquah Middle School Website")
            {
                memoryPic.Image = Properties.Resources.maconaquah;
            }

            else if (memoryLbl.Text == "Maconaquah Skyward")
            {
                memoryPic.Image = Properties.Resources.skywardlogo;
            }

            else if (memoryLbl.Text == "Desmos Scientific Calculator")
            {
                memoryPic.Image = Properties.Resources.macDesmos;
            }

            else if (memoryLbl.Text == "Prodigy Math Game")
            {
                memoryPic.Image = Properties.Resources.logo_prodigy;
            }

            else if (memoryLbl.Text == "Maconaquah Pivot")
            {
                memoryPic.Image = Properties.Resources.pivot_logo;
            }

            else if (memoryLbl.Text == "Mindplay")
            {
                memoryPic.Image = Properties.Resources.mindplay_logo;
            }

            else if (memoryLbl.Text == "MMS Calendar")
            {
                memoryPic.Image = Properties.Resources.calendar;
            }
            else if (memoryLbl.Text == "Lunch Menu")
            {
                memoryPic.Image = Properties.Resources.lunchmenu;
            }

            else if (memoryLbl.Text == "To-Do List")
            {
                memoryPic.Image = Properties.Resources.todo;
            }

            else if (memoryLbl.Text == "Google Docs")
            {
                memoryPic.Image = Properties.Resources.docs1;
            }

            else if (memoryLbl.Text == "Google Slides")
            {
                memoryPic.Image = Properties.Resources.slides;
            }

            else
            {
                memoryPic.Image = null;
            }
        }

        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            if (addressField.Text == "")
            {

            }
            else
            {
                Nav();
            }
        }

        public void Nav()
        {
            //navigates to adress or google
            if (addressField.Text.Contains(".") == true)
            {
                if (addressField.Text.Contains("://"))
                {
                    //navigate to website
                    Process.Start(addressField.Text);
                }
                else
                {
                    //add http:// and then navigate to website
                    Process.Start("http://" + addressField.Text);
                }
            }
            else
            {
                //search google
                Process.Start("http://google.com/search?q=" + addressField.Text);
            }

            addressField.Text = "";
        }

        private void AddressField_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when enter pressed
            if (e.KeyChar == 13)
            {
                if (addressField.Text == "")
                {

                }
                else
                {
                    Nav();
                }
            }
        }

        private void MacNews_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (ready == 1)
            {
                if (e.Url.ToString() == ("javascript:false") == false)
                {
                    if (e.Url.ToString().Contains("facebook") == false)
                    {
                        Process.Start(e.Url.ToString());
                        e.Cancel = true;
                        if (macNews.CanGoBack)
                            macNews.GoBack();
                    }
                    else
                    {
                        e.Cancel = true;
                        if (macNews.CanGoBack)
                            macNews.GoBack();
                    }
                    
                }
                else
                {
                    e.Cancel = true;
                    if (macNews.CanGoBack)
                        macNews.GoBack();
                }
            }
            else
            {
                e.Cancel = true;
                if (macNews.CanGoBack)
                    macNews.GoBack();
            }
        }

        private void MacNews_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {



        }

        private void MacNews_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Button2_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //desmos
                Process.Start("http://desmos.com/scientific");
                memoryLbl.Text = "Desmos Scientific Calculator";
                memoryPic.Image = Properties.Resources.macDesmos;
                Properties.Settings.Default.lastProgram = "Desmos Scientific Calculator";
            }
        }

        private void ClassroomBtn_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //classroom
                Process.Start("http://classroom.google.com");
                memoryLbl.Text = "Google Classroom";
                memoryPic.Image = Properties.Resources.Classroom;
                Properties.Settings.Default.lastProgram = "Google Classroom";
            }
        }

        private void Button2_Click_1(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //maconaquah website
                Process.Start("http://mms.maconaquah.k12.in.us");
                memoryLbl.Text = "Maconaquah Middle School Website";
                memoryPic.Image = Properties.Resources.maconaquah;
                Properties.Settings.Default.lastProgram = "Maconaquah Middle School Website";
            }
        }

        private void Button1_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                Schedule schedule = new Schedule();
                schedule.Show();
                memoryLbl.Text = "To-Do List";
                memoryPic.Image = Properties.Resources.todo;
                Properties.Settings.Default.lastProgram = "To-Do List";
            }
        }

        private void MacNews_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().Contains("facebook"))
            {
                macNews.Stop();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //update time
            currentTime.Text = DateTime.Now.ToString();
        }

        private void Button1_Click_1(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //prodigy math game
                Process.Start("http://prodigygame.com/play");
                memoryLbl.Text = "Prodigy Math Game";
                Properties.Settings.Default.lastProgram = "Prodigy Math Game";
                memoryPic.Image = Properties.Resources.logo_prodigy;
            }
        }

        private void LunchMenu_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //lunch menu
                Process.Start("http://maconaquah.k12.in.us/lunches");
                memoryLbl.Text = "Lunch Menu";
                Properties.Settings.Default.lastProgram = "Lunch Menu";
                memoryPic.Image = Properties.Resources.lunchmenu;
            }
        }

        private void PivotBtn_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //pivot
                Process.Start("http://maconaquah.five-starpivot.com/login");
                memoryLbl.Text = "Maconaquah Pivot";
                Properties.Settings.Default.lastProgram = "Maconaquah Pivot";
                memoryPic.Image = Properties.Resources.pivot_logo;
            }
        }

        private void MindplayBtn_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                   && Y == button.Location.Y)
            {
                //mindplay
                Process.Start("http://mindplay.com");
                memoryLbl.Text = "Mindplay";
                Properties.Settings.Default.lastProgram = "Mindplay";
                memoryPic.Image = Properties.Resources.mindplay_logo;
            }
        }

        private void MmsCalendar_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //mac calendar
                Process.Start("http://mms.maconaquah.k12.in.us/calendar");
                memoryLbl.Text = "MMS Calendar";
                Properties.Settings.Default.lastProgram = "MMS Calendar";
                memoryPic.Image = Properties.Resources.calendar;
            }
        }

        private void Button1_Click_2(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //google docs
                Process.Start("http://docs.google.com/document");
                memoryLbl.Text = "Google Docs";
                Properties.Settings.Default.lastProgram = "Google Docs";
                memoryPic.Image = Properties.Resources.docs1;
            }
        }

        private void Button2_Click_2(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            if (X == button.Location.X
                && Y == button.Location.Y)
            {
                //google slides
                Process.Start("https://docs.google.com/presentation");
                memoryLbl.Text = "Google Slides";
                Properties.Settings.Default.lastProgram = "Google Slides";
                memoryPic.Image = Properties.Resources.slides;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //about
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            MemoryStart();
        }

        public void MemoryStart()
        {
            if (memoryLbl.Text == "Google Classroom")
            {
                Process.Start("http://classroom.google.com");
            }

            else if (memoryLbl.Text == "Maconaquah Middle School Website")
            {
                Process.Start("http://mms.maconaquah.k12.in.us");
            }

            else if (memoryLbl.Text == "Maconaquah Skyward")
            {
                Process.Start(@"https://skyward.iscorp.com/scripts/wsisa.dll/WService=wsedumaconaquahin/seplog01.w");
            }

            else if (memoryLbl.Text == "Desmos Scientific Calculator")
            {
                Process.Start("http://desmos.com/scientific");
            }

            else if (memoryLbl.Text == "Prodigy Math Game")
            {
                Process.Start("http://prodigygame.com/play");
            }

            else if (memoryLbl.Text == "Maconaquah Pivot")
            {
                Process.Start("http://maconaquah.five-starpivot.com/login");
            }

            else if (memoryLbl.Text == "Mindplay")
            {
                Process.Start("http://mindplay.com");
            }

            else if (memoryLbl.Text == "MMS Calendar")
            {
                Process.Start("http://mms.maconaquah.k12.in.us/calendar");
            }

            else if (memoryLbl.Text == "Lunch Menu")
            {
                Process.Start("http://maconaquah.k12.in.us/lunches");
            }

            else if (memoryLbl.Text == "To-Do List")
            {
                //show to-do list
                Schedule schedule = new Schedule();
                schedule.Show();
            }

            else if (memoryLbl.Text == "Google Docs")
            {
                Process.Start("http://docs.google.com");
            }

            else if (memoryLbl.Text == "Google Slides")
            {
                Process.Start("http://slides.google.com");
            }
            
            else
            {
                //do nothing
            }
        }

        private void SkywardBtn_Click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BringToFront();
            //skyward
            if (X == button.Location.X 
                && Y == button.Location.Y)
            {
                Process.Start(@"https://skyward.iscorp.com/scripts/wsisa.dll/WService=wsedumaconaquahin/seplog01.w");
                memoryLbl.Text = "Maconaquah Skyward";
                Properties.Settings.Default.lastProgram = "Maconaquah Skyward";
                memoryPic.Image = Properties.Resources.skywardlogo;
            }
        }

        private void MemoryPic_Click(object sender, EventArgs e)
        {
            MemoryStart();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            MemoryStart();
        }

        private void MemoryLbl_Click(object sender, EventArgs e)
        {
            MemoryStart();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            //settings
            Theme settings = new Theme();
            settings.Show();
        }

        private void MacNews_LocationChanged(object sender, EventArgs e)
        {

        }

        private void MacNews_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }

        public void buttonLocationChanged()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {

                    Point point = new Point();

                    if (button == classroomBtn)
                    {
                        //504, 402
                        point.X = 504;
                        point.Y = 402;
                    }

                    if (button == macBtn)
                    {
                        //624, 402
                        point.X = 624;
                        point.Y = 402;
                    }

                    if (button == skywardBtn)
                    {
                        //744, 402
                        point.X = 744;
                        point.Y = 402;
                    }

                    if (button == desmosBtn)
                    {
                        //864, 402
                        point.X = 864;
                        point.Y = 402;
                    }

                    if (button == prodigyBtn)
                    {
                        //984, 402
                        point.X = 984;
                        point.Y = 402;
                    }

                    if (button == pivotBtn)
                    {
                        //1104, 402
                        point.X = 1104;
                        point.Y = 402;
                    }

                    if (button == mindplayBtn)
                    {
                        //504, 522
                        point.X = 504;
                        point.Y = 522;
                    }

                    if (button == mmsCalendar)
                    {
                        //624, 522
                        point.X = 624;
                        point.Y = 522;
                    }

                    if (button == lunchmenuBtn)
                    {
                        //744, 522
                        point.X = 744;
                        point.Y = 522;
                    }

                    if (button == todoBtn)
                    {
                        //864, 522
                        point.X = 864;
                        point.Y = 522;
                    }

                    if (button == docsBtn)
                    {
                        //984, 522
                        point.X = 984;
                        point.Y = 522;
                    }

                    if (button == slidesBtn)
                    {
                        //1104, 522
                        point.X = 1104;
                        point.Y = 522;
                    }

                    if (button != goBtn)
                    {
                        if (button.Location.Y < 385)
                        {
                            button.BringToFront();
                            button.Location = point;
                        }

                        if (button.Location.X < 447)
                        {
                            button.BringToFront();
                            button.Location = point;
                        }

                        if (button.Location.Y > 590)
                        {
                            button.BringToFront();
                            button.Location = point;
                        }
                    }
                }
            }
        }

        private void PivotBtn_LocationChanged(object sender, EventArgs e)
        {
            buttonLocationChanged();
        }


        public int X;
        public int Y;


        private void ClassroomBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            X = button.Location.X;
            Y = button.Location.Y;
            button.BringToFront();
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ClassroomBtn_Click_1(object sender, EventArgs e)
        {

        }

        public void ResetIcons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (button != goBtn)
                    {
                        button.Hide();

                        Point point = new Point();
                        point.X = 10;
                        point.Y = 30;
                        button.Location = point;

                        buttonLocationChanged();

                        button.Show();
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetIcons();
        }

        private void HandbookBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://mms.maconaquah.k12.in.us/student_policy__forms");
        }
    }
}