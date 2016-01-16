namespace notifyOfDanger
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.logoName = new System.Windows.Forms.Label();
            this.notifyUsBtn = new System.Windows.Forms.Button();
            this.whereTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.whatList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.whatTextBox = new System.Windows.Forms.TextBox();
            this.whenCalendar = new System.Windows.Forms.DateTimePicker();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.flatNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // logoName
            // 
            resources.ApplyResources(this.logoName, "logoName");
            this.logoName.ForeColor = System.Drawing.Color.Snow;
            this.logoName.Name = "logoName";
            // 
            // notifyUsBtn
            // 
            resources.ApplyResources(this.notifyUsBtn, "notifyUsBtn");
            this.notifyUsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifyUsBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.notifyUsBtn.Name = "notifyUsBtn";
            this.notifyUsBtn.UseVisualStyleBackColor = false;
            this.notifyUsBtn.Click += new System.EventHandler(this.notifyUsBtn_Click);
            // 
            // whereTextBox
            // 
            resources.ApplyResources(this.whereTextBox, "whereTextBox");
            this.whereTextBox.Name = "whereTextBox";
            this.whereTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.whereTextBox_MouseClick);
            this.whereTextBox.Leave += new System.EventHandler(this.whereTextBox_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Name = "label3";
            // 
            // whatList
            // 
            resources.ApplyResources(this.whatList, "whatList");
            this.whatList.FormattingEnabled = true;
            this.whatList.Items.AddRange(new object[] {
            resources.GetString("whatList.Items"),
            resources.GetString("whatList.Items1"),
            resources.GetString("whatList.Items2"),
            resources.GetString("whatList.Items3"),
            resources.GetString("whatList.Items4")});
            this.whatList.Name = "whatList";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Name = "label5";
            // 
            // whatTextBox
            // 
            resources.ApplyResources(this.whatTextBox, "whatTextBox");
            this.whatTextBox.Name = "whatTextBox";
            // 
            // whenCalendar
            // 
            resources.ApplyResources(this.whenCalendar, "whenCalendar");
            this.whenCalendar.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.whenCalendar.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.whenCalendar.Name = "whenCalendar";
            // 
            // countryBox
            // 
            resources.ApplyResources(this.countryBox, "countryBox");
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Name = "countryBox";
            this.countryBox.TextChanged += new System.EventHandler(this.countryBox_TextChanged);
            this.countryBox.Leave += new System.EventHandler(this.countryBox_Leave);
            this.countryBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.countryBox_MouseClick);
            // 
            // cityBox
            // 
            resources.ApplyResources(this.cityBox, "cityBox");
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Name = "cityBox";
            this.cityBox.Leave += new System.EventHandler(this.cityBox_Leave);
            this.cityBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cityBox_MouseClick);
            // 
            // flatNumber
            // 
            resources.ApplyResources(this.flatNumber, "flatNumber");
            this.flatNumber.Name = "flatNumber";
            this.flatNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flatNumber_MouseClick);
            this.flatNumber.Leave += new System.EventHandler(this.flatNumber_Leave);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            resources.ApplyResources(this.fIleToolStripMenuItem, "fIleToolStripMenuItem");
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.fIleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polskiToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polskiToolStripMenuItem
            // 
            resources.ApplyResources(this.polskiToolStripMenuItem, "polskiToolStripMenuItem");
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Click += new System.EventHandler(this.polskiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.whenCalendar);
            this.Controls.Add(this.whatList);
            this.Controls.Add(this.whatTextBox);
            this.Controls.Add(this.flatNumber);
            this.Controls.Add(this.whereTextBox);
            this.Controls.Add(this.notifyUsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoName);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.Button notifyUsBtn;
        private System.Windows.Forms.TextBox whereTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox whatList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox whatTextBox;
        private System.Windows.Forms.DateTimePicker whenCalendar;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox flatNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
    }
}

