namespace Mac_Middle_School_Portal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usernameLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.addressField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.macNews = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.classroomBtn = new System.Windows.Forms.Button();
            this.slidesBtn = new System.Windows.Forms.Button();
            this.docsBtn = new System.Windows.Forms.Button();
            this.todoBtn = new System.Windows.Forms.Button();
            this.lunchmenuBtn = new System.Windows.Forms.Button();
            this.mmsCalendar = new System.Windows.Forms.Button();
            this.mindplayBtn = new System.Windows.Forms.Button();
            this.pivotBtn = new System.Windows.Forms.Button();
            this.prodigyBtn = new System.Windows.Forms.Button();
            this.macBtn = new System.Windows.Forms.Button();
            this.skywardBtn = new System.Windows.Forms.Button();
            this.desmosBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.handbookBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.themeBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.memoryPic = new System.Windows.Forms.PictureBox();
            this.memoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.infoPanel.SuspendLayout();
            this.memoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryPic)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(12, 73);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(149, 38);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Welcome!";
            // 
            // goBtn
            // 
            this.goBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.goBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.goBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.goBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBtn.Location = new System.Drawing.Point(1024, 120);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(59, 34);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // addressField
            // 
            this.addressField.Depth = 0;
            this.addressField.Hint = "Search the web...";
            this.addressField.Location = new System.Drawing.Point(631, 126);
            this.addressField.MaxLength = 32767;
            this.addressField.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressField.Name = "addressField";
            this.addressField.PasswordChar = '\0';
            this.addressField.SelectedText = "";
            this.addressField.SelectionLength = 0;
            this.addressField.SelectionStart = 0;
            this.addressField.Size = new System.Drawing.Size(387, 28);
            this.addressField.TabIndex = 4;
            this.addressField.TabStop = false;
            this.addressField.UseSystemPasswordChar = false;
            this.addressField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressField_KeyPress);
            // 
            // macNews
            // 
            this.macNews.AllowNavigation = false;
            this.macNews.IsWebBrowserContextMenuEnabled = false;
            this.macNews.Location = new System.Drawing.Point(2, 114);
            this.macNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.macNews.Name = "macNews";
            this.macNews.ScriptErrorsSuppressed = true;
            this.macNews.Size = new System.Drawing.Size(445, 544);
            this.macNews.TabIndex = 5;
            this.macNews.Url = new System.Uri("http://macbraves.com", System.UriKind.Absolute);
            this.macNews.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MacNews_DocumentCompleted);
            this.macNews.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.MacNews_Navigated);
            this.macNews.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.MacNews_Navigating);
            this.macNews.NewWindow += new System.ComponentModel.CancelEventHandler(this.MacNews_NewWindow);
            this.macNews.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.MacNews_ProgressChanged);
            this.macNews.LocationChanged += new System.EventHandler(this.MacNews_LocationChanged);
            // 
            // classroomBtn
            // 
            this.classroomBtn.BackColor = System.Drawing.Color.Transparent;
            this.classroomBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.Classroom;
            this.classroomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.classroomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classroomBtn.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::Mac_Middle_School_Portal.Properties.Settings.Default, "classroomVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.classroomBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "classroomLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.classroomBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.classroomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.classroomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.classroomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classroomBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.classroomLocation;
            this.classroomBtn.Name = "classroomBtn";
            this.classroomBtn.Size = new System.Drawing.Size(94, 94);
            this.classroomBtn.TabIndex = 6;
            this.classroomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.classroomBtn, "Google Classroom");
            this.classroomBtn.UseVisualStyleBackColor = false;
            this.classroomBtn.Visible = global::Mac_Middle_School_Portal.Properties.Settings.Default.classroomVisible;
            this.classroomBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.classroomBtn.Click += new System.EventHandler(this.ClassroomBtn_Click_1);
            this.classroomBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.classroomBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_Click);
            // 
            // slidesBtn
            // 
            this.slidesBtn.BackColor = System.Drawing.Color.Transparent;
            this.slidesBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.slides;
            this.slidesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slidesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidesBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "slidesBtn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slidesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.slidesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.slidesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.slidesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidesBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.slidesBtn;
            this.slidesBtn.Name = "slidesBtn";
            this.slidesBtn.Size = new System.Drawing.Size(94, 94);
            this.slidesBtn.TabIndex = 18;
            this.slidesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.slidesBtn, "Google Slides");
            this.slidesBtn.UseVisualStyleBackColor = false;
            this.slidesBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.slidesBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.slidesBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_Click_2);
            // 
            // docsBtn
            // 
            this.docsBtn.BackColor = System.Drawing.Color.Transparent;
            this.docsBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.docs1;
            this.docsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docsBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "docsLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.docsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.docsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.docsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.docsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docsBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.docsLocation;
            this.docsBtn.Name = "docsBtn";
            this.docsBtn.Size = new System.Drawing.Size(94, 94);
            this.docsBtn.TabIndex = 17;
            this.docsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.docsBtn, "Google Docs");
            this.docsBtn.UseVisualStyleBackColor = false;
            this.docsBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.docsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.docsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_Click_2);
            // 
            // todoBtn
            // 
            this.todoBtn.BackColor = System.Drawing.Color.Transparent;
            this.todoBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.todo;
            this.todoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.todoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "todoBtn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.todoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.todoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.todoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.todoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.todoBtn;
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(94, 94);
            this.todoBtn.TabIndex = 16;
            this.todoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.todoBtn, "To-Do List");
            this.todoBtn.UseVisualStyleBackColor = false;
            this.todoBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.todoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.todoBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_Click);
            // 
            // lunchmenuBtn
            // 
            this.lunchmenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.lunchmenuBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.lunchmenu;
            this.lunchmenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lunchmenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lunchmenuBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "lunchmenuLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lunchmenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lunchmenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.lunchmenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lunchmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchmenuBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.lunchmenuLocation;
            this.lunchmenuBtn.Name = "lunchmenuBtn";
            this.lunchmenuBtn.Size = new System.Drawing.Size(94, 94);
            this.lunchmenuBtn.TabIndex = 15;
            this.lunchmenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lunchmenuBtn, "Lunch Menu");
            this.lunchmenuBtn.UseVisualStyleBackColor = false;
            this.lunchmenuBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.lunchmenuBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.lunchmenuBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LunchMenu_Click);
            // 
            // mmsCalendar
            // 
            this.mmsCalendar.BackColor = System.Drawing.Color.Transparent;
            this.mmsCalendar.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.calendar;
            this.mmsCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mmsCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mmsCalendar.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "mmsLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mmsCalendar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mmsCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.mmsCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mmsCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mmsCalendar.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.mmsLocation;
            this.mmsCalendar.Name = "mmsCalendar";
            this.mmsCalendar.Size = new System.Drawing.Size(94, 94);
            this.mmsCalendar.TabIndex = 14;
            this.mmsCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.mmsCalendar, "MMS Calendar");
            this.mmsCalendar.UseVisualStyleBackColor = false;
            this.mmsCalendar.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.mmsCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.mmsCalendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MmsCalendar_Click);
            // 
            // mindplayBtn
            // 
            this.mindplayBtn.BackColor = System.Drawing.Color.Transparent;
            this.mindplayBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.mindplay_logo;
            this.mindplayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mindplayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mindplayBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "mindplayLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mindplayBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mindplayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.mindplayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mindplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mindplayBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.mindplayLocation;
            this.mindplayBtn.Name = "mindplayBtn";
            this.mindplayBtn.Size = new System.Drawing.Size(94, 94);
            this.mindplayBtn.TabIndex = 13;
            this.mindplayBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.mindplayBtn, "Mindplay");
            this.mindplayBtn.UseVisualStyleBackColor = false;
            this.mindplayBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.mindplayBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.mindplayBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MindplayBtn_Click);
            // 
            // pivotBtn
            // 
            this.pivotBtn.BackColor = System.Drawing.Color.Transparent;
            this.pivotBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.pivot_logo;
            this.pivotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pivotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pivotBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "pivotLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pivotBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pivotBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.pivotBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.pivotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pivotBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.pivotLocation;
            this.pivotBtn.Name = "pivotBtn";
            this.pivotBtn.Size = new System.Drawing.Size(94, 94);
            this.pivotBtn.TabIndex = 12;
            this.pivotBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.pivotBtn, "Maconaquah Pivot ");
            this.pivotBtn.UseVisualStyleBackColor = false;
            this.pivotBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.pivotBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.pivotBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PivotBtn_Click);
            // 
            // prodigyBtn
            // 
            this.prodigyBtn.BackColor = System.Drawing.Color.Transparent;
            this.prodigyBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.logo_prodigy;
            this.prodigyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prodigyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prodigyBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "prodigyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.prodigyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.prodigyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.prodigyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.prodigyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodigyBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.prodigyLocation;
            this.prodigyBtn.Name = "prodigyBtn";
            this.prodigyBtn.Size = new System.Drawing.Size(94, 94);
            this.prodigyBtn.TabIndex = 11;
            this.prodigyBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.prodigyBtn, "Prodigy Math Game");
            this.prodigyBtn.UseVisualStyleBackColor = false;
            this.prodigyBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.prodigyBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.prodigyBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_Click_1);
            // 
            // macBtn
            // 
            this.macBtn.BackColor = System.Drawing.Color.Transparent;
            this.macBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.maconaquah;
            this.macBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.macBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "macLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.macBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.macBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.macBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.macBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.macBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.macLocation;
            this.macBtn.Name = "macBtn";
            this.macBtn.Size = new System.Drawing.Size(94, 94);
            this.macBtn.TabIndex = 8;
            this.macBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.macBtn, "Maconaquah Middle School Website");
            this.macBtn.UseVisualStyleBackColor = false;
            this.macBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.macBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.macBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_Click_1);
            // 
            // skywardBtn
            // 
            this.skywardBtn.BackColor = System.Drawing.Color.Transparent;
            this.skywardBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.skywardlogo;
            this.skywardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skywardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skywardBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "skywardLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.skywardBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.skywardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.skywardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.skywardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skywardBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.skywardLocation;
            this.skywardBtn.Name = "skywardBtn";
            this.skywardBtn.Size = new System.Drawing.Size(94, 94);
            this.skywardBtn.TabIndex = 7;
            this.skywardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.skywardBtn, "Maconaquah Skyward");
            this.skywardBtn.UseVisualStyleBackColor = false;
            this.skywardBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.skywardBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.skywardBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SkywardBtn_Click);
            // 
            // desmosBtn
            // 
            this.desmosBtn.BackColor = System.Drawing.Color.Transparent;
            this.desmosBtn.BackgroundImage = global::Mac_Middle_School_Portal.Properties.Resources.macDesmos;
            this.desmosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.desmosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desmosBtn.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Mac_Middle_School_Portal.Properties.Settings.Default, "desmosLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.desmosBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.desmosBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.desmosBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.desmosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desmosBtn.Location = global::Mac_Middle_School_Portal.Properties.Settings.Default.desmosLocation;
            this.desmosBtn.Name = "desmosBtn";
            this.desmosBtn.Size = new System.Drawing.Size(94, 94);
            this.desmosBtn.TabIndex = 3;
            this.desmosBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.desmosBtn, "Desmos Scientific Calculator");
            this.desmosBtn.UseVisualStyleBackColor = false;
            this.desmosBtn.LocationChanged += new System.EventHandler(this.PivotBtn_LocationChanged);
            this.desmosBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassroomBtn_MouseDown);
            this.desmosBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoPanel.Controls.Add(this.handbookBtn);
            this.infoPanel.Controls.Add(this.resetBtn);
            this.infoPanel.Controls.Add(this.themeBtn);
            this.infoPanel.Controls.Add(this.aboutBtn);
            this.infoPanel.Controls.Add(this.currentTime);
            this.infoPanel.Location = new System.Drawing.Point(-59, 660);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1452, 187);
            this.infoPanel.TabIndex = 10;
            // 
            // handbookBtn
            // 
            this.handbookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handbookBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.handbookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.handbookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.handbookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.handbookBtn.Location = new System.Drawing.Point(907, 9);
            this.handbookBtn.Name = "handbookBtn";
            this.handbookBtn.Size = new System.Drawing.Size(96, 40);
            this.handbookBtn.TabIndex = 14;
            this.handbookBtn.Text = "Handbook";
            this.handbookBtn.UseVisualStyleBackColor = true;
            this.handbookBtn.Click += new System.EventHandler(this.HandbookBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Location = new System.Drawing.Point(1009, 9);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(96, 40);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reset Icons";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // themeBtn
            // 
            this.themeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.themeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.themeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.themeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeBtn.Location = new System.Drawing.Point(1111, 9);
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Size = new System.Drawing.Size(96, 40);
            this.themeBtn.TabIndex = 12;
            this.themeBtn.Text = "Theme";
            this.themeBtn.UseVisualStyleBackColor = true;
            this.themeBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Location = new System.Drawing.Point(1213, 9);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(96, 40);
            this.aboutBtn.TabIndex = 11;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::Mac_Middle_School_Portal.Properties.Settings.Default, "currentTimeVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.currentTime.Location = new System.Drawing.Point(74, 20);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(93, 20);
            this.currentTime.TabIndex = 10;
            this.currentTime.Text = "currentTime";
            this.currentTime.Visible = global::Mac_Middle_School_Portal.Properties.Settings.Default.currentTimeVisible;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // memoryPanel
            // 
            this.memoryPanel.Controls.Add(this.memoryPic);
            this.memoryPanel.Controls.Add(this.memoryLbl);
            this.memoryPanel.Controls.Add(this.label1);
            this.memoryPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryPanel.Location = new System.Drawing.Point(504, 210);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(694, 152);
            this.memoryPanel.TabIndex = 20;
            this.memoryPanel.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // memoryPic
            // 
            this.memoryPic.BackColor = System.Drawing.Color.Transparent;
            this.memoryPic.Image = global::Mac_Middle_School_Portal.Properties.Resources.Classroom;
            this.memoryPic.Location = new System.Drawing.Point(0, 0);
            this.memoryPic.Name = "memoryPic";
            this.memoryPic.Size = new System.Drawing.Size(157, 152);
            this.memoryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.memoryPic.TabIndex = 19;
            this.memoryPic.TabStop = false;
            this.memoryPic.Click += new System.EventHandler(this.MemoryPic_Click);
            // 
            // memoryLbl
            // 
            this.memoryLbl.AutoSize = true;
            this.memoryLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mac_Middle_School_Portal.Properties.Settings.Default, "lastProgram", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memoryLbl.Font = new System.Drawing.Font("Open Sans", 10F);
            this.memoryLbl.Location = new System.Drawing.Point(165, 67);
            this.memoryLbl.Name = "memoryLbl";
            this.memoryLbl.Size = new System.Drawing.Size(0, 23);
            this.memoryLbl.TabIndex = 1;
            this.memoryLbl.Text = global::Mac_Middle_School_Portal.Properties.Settings.Default.lastProgram;
            this.memoryLbl.Click += new System.EventHandler(this.MemoryLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick up where you left off";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1328, 299);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 715);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.macNews);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.memoryPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.classroomBtn);
            this.Controls.Add(this.slidesBtn);
            this.Controls.Add(this.docsBtn);
            this.Controls.Add(this.todoBtn);
            this.Controls.Add(this.lunchmenuBtn);
            this.Controls.Add(this.mmsCalendar);
            this.Controls.Add(this.mindplayBtn);
            this.Controls.Add(this.pivotBtn);
            this.Controls.Add(this.prodigyBtn);
            this.Controls.Add(this.macBtn);
            this.Controls.Add(this.skywardBtn);
            this.Controls.Add(this.desmosBtn);
            this.Font = new System.Drawing.Font("Open Sans", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1262, 796);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Portal_FormClosing);
            this.Load += new System.EventHandler(this.Portal_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.memoryPanel.ResumeLayout(false);
            this.memoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button desmosBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField addressField;
        private System.Windows.Forms.WebBrowser macNews;
        private System.Windows.Forms.Button classroomBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button skywardBtn;
        private System.Windows.Forms.Button macBtn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button prodigyBtn;
        private System.Windows.Forms.Button pivotBtn;
        private System.Windows.Forms.Button mindplayBtn;
        private System.Windows.Forms.Button mmsCalendar;
        private System.Windows.Forms.Button lunchmenuBtn;
        private System.Windows.Forms.Button todoBtn;
        private System.Windows.Forms.Button docsBtn;
        private System.Windows.Forms.Button slidesBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.PictureBox memoryPic;
        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.Label memoryLbl;
        private System.Windows.Forms.Button themeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button resetBtn;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label currentTime;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button handbookBtn;
    }
}

