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
            this.whatList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.whatTextBox = new System.Windows.Forms.TextBox();
            this.whenCalendar = new System.Windows.Forms.DateTimePicker();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.flatNumber = new System.Windows.Forms.TextBox();
            this.polski = new System.Windows.Forms.PictureBox();
            this.english = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.polski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.english)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
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
            // whatList
            // 
            resources.ApplyResources(this.whatList, "whatList");
            this.whatList.FormattingEnabled = true;
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
            // polski
            // 
            resources.ApplyResources(this.polski, "polski");
            this.polski.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polski.Name = "polski";
            this.polski.TabStop = false;
            this.polski.Click += new System.EventHandler(this.polski_Click);
            // 
            // english
            // 
            resources.ApplyResources(this.english, "english");
            this.english.Cursor = System.Windows.Forms.Cursors.Hand;
            this.english.Name = "english";
            this.english.TabStop = false;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.english);
            this.Controls.Add(this.polski);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.whenCalendar);
            this.Controls.Add(this.whatList);
            this.Controls.Add(this.whatTextBox);
            this.Controls.Add(this.flatNumber);
            this.Controls.Add(this.whereTextBox);
            this.Controls.Add(this.notifyUsBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.polski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.english)).EndInit();
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
        private System.Windows.Forms.ComboBox whatList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox whatTextBox;
        private System.Windows.Forms.DateTimePicker whenCalendar;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox flatNumber;
        private System.Windows.Forms.PictureBox polski;
        private System.Windows.Forms.PictureBox english;
        private System.Windows.Forms.Label label6;
    }
}

