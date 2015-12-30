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
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click to show the accident notification";
            this.notifyIcon1.BalloonTipTitle = "NEW ACCIDENT NOTIFICATION!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyME!";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // logoName
            // 
            this.logoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Oswald", 29.75F);
            this.logoName.ForeColor = System.Drawing.Color.Snow;
            this.logoName.Location = new System.Drawing.Point(139, 28);
            this.logoName.Margin = new System.Windows.Forms.Padding(0);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(258, 60);
            this.logoName.TabIndex = 0;
            this.logoName.Text = "notifyOfDanger";
            this.logoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyUsBtn
            // 
            this.notifyUsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifyUsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifyUsBtn.Font = new System.Drawing.Font("Myriad Pro Light", 15F, System.Drawing.FontStyle.Bold);
            this.notifyUsBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.notifyUsBtn.Location = new System.Drawing.Point(29, 278);
            this.notifyUsBtn.Name = "notifyUsBtn";
            this.notifyUsBtn.Size = new System.Drawing.Size(478, 66);
            this.notifyUsBtn.TabIndex = 1;
            this.notifyUsBtn.Text = "NOTIFY US!";
            this.notifyUsBtn.UseVisualStyleBackColor = false;
            this.notifyUsBtn.Click += new System.EventHandler(this.notifyUsBtn_Click);
            // 
            // whereTextBox
            // 
            this.whereTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whereTextBox.Location = new System.Drawing.Point(279, 249);
            this.whereTextBox.Name = "whereTextBox";
            this.whereTextBox.Size = new System.Drawing.Size(228, 20);
            this.whereTextBox.TabIndex = 2;
            this.whereTextBox.Text = "Write here street name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(131, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "What happened?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(275, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "When?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(275, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Where?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whatList
            // 
            this.whatList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whatList.FormattingEnabled = true;
            this.whatList.Location = new System.Drawing.Point(128, 168);
            this.whatList.Name = "whatList";
            this.whatList.Size = new System.Drawing.Size(129, 21);
            this.whatList.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danger type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(28, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detailed description (optionally):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whatTextBox
            // 
            this.whatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whatTextBox.Location = new System.Drawing.Point(29, 226);
            this.whatTextBox.Multiline = true;
            this.whatTextBox.Name = "whatTextBox";
            this.whatTextBox.Size = new System.Drawing.Size(228, 43);
            this.whatTextBox.TabIndex = 2;
            // 
            // whenCalendar
            // 
            this.whenCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whenCalendar.Location = new System.Drawing.Point(279, 167);
            this.whenCalendar.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.whenCalendar.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.whenCalendar.Name = "whenCalendar";
            this.whenCalendar.Size = new System.Drawing.Size(200, 20);
            this.whenCalendar.TabIndex = 6;
            // 
            // countryBox
            // 
            this.countryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(279, 226);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(106, 21);
            this.countryBox.TabIndex = 7;
            this.countryBox.Text = "Country name";
            this.countryBox.TextChanged += new System.EventHandler(this.countryBox_TextChanged);
            // 
            // cityBox
            // 
            this.cityBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(391, 226);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(116, 21);
            this.cityBox.TabIndex = 8;
            this.cityBox.Text = "City name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(536, 385);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.whenCalendar);
            this.Controls.Add(this.whatList);
            this.Controls.Add(this.whatTextBox);
            this.Controls.Add(this.whereTextBox);
            this.Controls.Add(this.notifyUsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(552, 385);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

