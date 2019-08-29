namespace Mac_Middle_School_Portal
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.eventsBox = new System.Windows.Forms.ListBox();
            this.selectedEvent = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.events = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createNew = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateandtime = new System.Windows.Forms.DateTimePicker();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.downBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.events.SuspendLayout();
            this.createNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsBox
            // 
            this.eventsBox.Font = new System.Drawing.Font("Open Sans", 12F);
            this.eventsBox.FormattingEnabled = true;
            this.eventsBox.ItemHeight = 27;
            this.eventsBox.Location = new System.Drawing.Point(492, 112);
            this.eventsBox.Name = "eventsBox";
            this.eventsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.eventsBox.Size = new System.Drawing.Size(382, 328);
            this.eventsBox.TabIndex = 0;
            this.eventsBox.Click += new System.EventHandler(this.EventsBox_Click);
            this.eventsBox.SelectedIndexChanged += new System.EventHandler(this.EventsBox_SelectedIndexChanged);
            this.eventsBox.SelectedValueChanged += new System.EventHandler(this.EventsBox_SelectedValueChanged);
            this.eventsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventsBox_Click);
            // 
            // selectedEvent
            // 
            this.selectedEvent.BackColor = System.Drawing.Color.White;
            this.selectedEvent.Font = new System.Drawing.Font("Open Sans", 9F);
            this.selectedEvent.Location = new System.Drawing.Point(31, 195);
            this.selectedEvent.Multiline = true;
            this.selectedEvent.Name = "selectedEvent";
            this.selectedEvent.ReadOnly = true;
            this.selectedEvent.Size = new System.Drawing.Size(370, 214);
            this.selectedEvent.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Open Sans", 9F);
            this.addBtn.Location = new System.Drawing.Point(766, 477);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 38);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Event";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Open Sans", 9F);
            this.removeBtn.Location = new System.Drawing.Point(652, 477);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(108, 38);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Open Sans", 9F);
            this.clearBtn.Location = new System.Drawing.Point(538, 477);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(108, 38);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Events";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.events);
            this.tabControl1.Controls.Add(this.createNew);
            this.tabControl1.Location = new System.Drawing.Point(-6, 79);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 488);
            this.tabControl1.TabIndex = 6;
            // 
            // events
            // 
            this.events.Controls.Add(this.label8);
            this.events.Controls.Add(this.label7);
            this.events.Controls.Add(this.label6);
            this.events.Controls.Add(this.selectedEvent);
            this.events.Location = new System.Drawing.Point(4, 4);
            this.events.Name = "events";
            this.events.Padding = new System.Windows.Forms.Padding(3);
            this.events.Size = new System.Drawing.Size(433, 459);
            this.events.TabIndex = 0;
            this.events.Text = "Events";
            this.events.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label8.Location = new System.Drawing.Point(31, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "View selected event";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label7.Location = new System.Drawing.Point(27, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Keep reminders for things you need to do later here.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "To-Do List";
            // 
            // createNew
            // 
            this.createNew.Controls.Add(this.label3);
            this.createNew.Controls.Add(this.cancelBtn);
            this.createNew.Controls.Add(this.createBtn);
            this.createNew.Controls.Add(this.label5);
            this.createNew.Controls.Add(this.label4);
            this.createNew.Controls.Add(this.dateandtime);
            this.createNew.Controls.Add(this.descriptionBox);
            this.createNew.Controls.Add(this.label2);
            this.createNew.Location = new System.Drawing.Point(4, 4);
            this.createNew.Name = "createNew";
            this.createNew.Padding = new System.Windows.Forms.Padding(3);
            this.createNew.Size = new System.Drawing.Size(433, 459);
            this.createNew.TabIndex = 1;
            this.createNew.Text = "New";
            this.createNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label3.Location = new System.Drawing.Point(328, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "<< Set date";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Open Sans", 9F);
            this.cancelBtn.Location = new System.Drawing.Point(22, 408);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 36);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Open Sans", 9F);
            this.createBtn.Location = new System.Drawing.Point(121, 408);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(93, 36);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "New Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // dateandtime
            // 
            this.dateandtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateandtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateandtime.Location = new System.Drawing.Point(22, 102);
            this.dateandtime.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.dateandtime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateandtime.Name = "dateandtime";
            this.dateandtime.Size = new System.Drawing.Size(302, 23);
            this.dateandtime.TabIndex = 2;
            this.dateandtime.Value = new System.DateTime(2019, 7, 6, 15, 7, 0, 0);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Open Sans", 9F);
            this.descriptionBox.Location = new System.Drawing.Point(22, 185);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(384, 212);
            this.descriptionBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date and time";
            // 
            // downBtn
            // 
            this.downBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.downBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.downBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.downBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downBtn.Image = ((System.Drawing.Image)(resources.GetObject("downBtn.Image")));
            this.downBtn.Location = new System.Drawing.Point(438, 156);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(48, 38);
            this.downBtn.TabIndex = 8;
            this.downBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.upBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Image = ((System.Drawing.Image)(resources.GetObject("upBtn.Image")));
            this.upBtn.Location = new System.Drawing.Point(438, 112);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(48, 38);
            this.upBtn.TabIndex = 7;
            this.upBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // memory
            // 
            this.memory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mac_Middle_School_Portal.Properties.Settings.Default, "mem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memory.Location = new System.Drawing.Point(525, 171);
            this.memory.Multiline = true;
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(100, 60);
            this.memory.TabIndex = 9;
            this.memory.Text = global::Mac_Middle_School_Portal.Properties.Settings.Default.mem;
            this.memory.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 538);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.eventsBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.memory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(886, 538);
            this.MinimumSize = new System.Drawing.Size(886, 538);
            this.Name = "Schedule";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schedule_FormClosing);
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.tabControl1.ResumeLayout(false);
            this.events.ResumeLayout(false);
            this.events.PerformLayout();
            this.createNew.ResumeLayout(false);
            this.createNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox selectedEvent;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox eventsBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage createNew;
        private System.Windows.Forms.TabPage events;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateandtime;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox memory;
    }
}