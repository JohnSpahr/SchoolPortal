namespace Mac_Middle_School_Portal
{
    partial class Theme
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
            this.themeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // themeBox
            // 
            this.themeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mac_Middle_School_Portal.Properties.Settings.Default, "colorScheme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.themeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeBox.Font = new System.Drawing.Font("Open Sans", 9F);
            this.themeBox.FormattingEnabled = true;
            this.themeBox.Items.AddRange(new object[] {
            "Blue",
            "Red"});
            this.themeBox.Location = new System.Drawing.Point(12, 84);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(315, 28);
            this.themeBox.TabIndex = 7;
            this.themeBox.Text = global::Mac_Middle_School_Portal.Properties.Settings.Default.colorScheme;
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 181);
            this.Controls.Add(this.themeBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Theme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox themeBox;
    }
}