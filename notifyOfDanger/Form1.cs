using System;
using System.Globalization;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Dangers;
using DBase;
using System.Timers;

namespace notifyOfDanger
{
    /// <summary>
    /// Main class with the GUI (Form).
    /// </summary>
    public partial class Form1 : Form
    {
        Database db = new Database();
        public string Language = Properties.Settings.Default.Lang;
        private class Item
        {
            public string Name;
            public Item(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                /// Generates the text shown in the combo box
                return Name;
            }
        }
        private System.Timers.Timer timer;
        int accidentCounter = 0;

        /// <summary>
        /// Form constructor used to initialization of the form, setting default values in text boxes (especially in whatList)
        /// </summary>
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);
            InitializeComponent();
            countryBox.Items.Add(new Item("PL"));
            countryBox.Items.Add(new Item("GER"));
            countryBox.Items.Add(new Item("EN"));

            if (Properties.Settings.Default.Lang == "pl-PL")
            {
                whatList.Items.Clear();
                whatList.ResetText();
                whatList.Items.Add(new Item("Pożar"));
                whatList.Items.Add(new Item("Stłuczka"));
                whatList.Items.Add(new Item("Powódź"));
                whatList.Items.Add(new Item("Trzęsienie ziemi"));
                whatList.Items.Add(new Item("Inne"));
            }
            else
            {
                whatList.Items.Clear();
                whatList.ResetText();
                whatList.Items.Add(new Item("Fire"));
                whatList.Items.Add(new Item("Car crush"));
                whatList.Items.Add(new Item("Flood"));
                whatList.Items.Add(new Item("Earthquake"));
                whatList.Items.Add(new Item("Other"));
            }

            int wait = 3 * 1000;
            timer = new System.Timers.Timer(wait);
            timer.Start();
            timer.Elapsed += checkForUpdates;
        }

        /// <summary>
        /// Method checkForUpdates() is executed periodically and it displays tooltip with short description of the brandnew danger
        /// </summary>
        public void checkForUpdates(object sender, ElapsedEventArgs e)
        {
         
            /// if current accident counter is smaller than actual number of rows in db, it means that db has been updated
            if (accidentCounter < db.countAccidents())
            {
                notifyIcon1.BalloonTipText = db.giveAccidentDetails();
                notifyIcon1.ShowBalloonTip(3000);
                /// countAccidents returns the highest id from 'situationsdb' table
                accidentCounter = db.countAccidents(); 
                timer.Start();
            }
        }

        /// <summary> Method changeLanguage() change language given with the parameter 'lang' </summary>
        /// <param name="lang">the string with name of the language to be set</param> 
        private void changeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        /// <summary>On Form's load, the minDate and maxDate of the Calendar is created</summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            /// optional: ability to set yesterday's date
            whenCalendar.MinDate = DateTime.Now;  //.AddDays(-1); 
            whenCalendar.MaxDate = DateTime.Now;
        }

        /// <summary>Method notifyUsBtn_Click - on click is sending aggregated information to the database</summary>
        private void notifyUsBtn_Click(object sender, EventArgs e)
        {
            Danger dan = new Danger();

            dan.AccType = whatList.Text;
            dan.AccDescr = whatTextBox.Text;
            dan.AccDate = Convert.ToDateTime(whenCalendar.Value);
            dan.AccLocation = countryBox.Text + "/" + cityBox.Text + "/" + whereTextBox.Text + "/" + flatNumber.Text;
            countryBox.ResetText();
            whatList.ResetText();
            whatTextBox.ResetText();
            whereTextBox.ResetText();
            flatNumber.ResetText();

            db.insertDanger(dan);
            /// increments accCounter (to avoid the risk of being noticed about the danger what was reported by myself)
            accidentCounter++;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            /// Toggle the form when the user clicks on the notify icon.
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Minimized;

            /// Activate the form.
            Activate();
        }

        /// <summary>On text changed event assign different cities names to the appropriate country name</summary>
        private void countryBox_TextChanged(object sender, EventArgs e)
        {
            cityBox.Items.Clear();
            cityBox.ResetText();
            if (countryBox.Text == "PL")
            {
                cityBox.Items.Add(new Item("Warsaw"));
                cityBox.Items.Add(new Item("Cracow"));
                cityBox.Items.Add(new Item("Poznan"));
                cityBox.Items.Add(new Item("Wroclaw"));
                cityBox.Items.Add(new Item("Gdansk"));
            }
            else if (countryBox.Text == "GER")
            {
                cityBox.Items.Add(new Item("Dortmund"));
                cityBox.Items.Add(new Item("Monachium"));
                cityBox.Items.Add(new Item("Bremen"));
                cityBox.Items.Add(new Item("Dusseldorf"));
                cityBox.Items.Add(new Item("Frankfurt"));
            }
            else if (countryBox.Text == "EN")
            {
                cityBox.Items.Add(new Item("London"));
                cityBox.Items.Add(new Item("Liverpool"));
                cityBox.Items.Add(new Item("Manchester"));
                cityBox.Items.Add(new Item("Birmingham"));
                cityBox.Items.Add(new Item("York"));
            }
        }

        /// <summary>This method describes dependencies between textBoxes.
        /// It also cleans the default textBox's value</summary>
        private void countryBox_MouseClick(object sender, MouseEventArgs e)
        {
            countryBox.Text = "";
            cityBox.Text = "";
        }

        /// <summary>This method describes dependencies between textBoxes, also it depends on the default language</summary>
        private void flatNumber_Leave(object sender, EventArgs e)
        {
            if (flatNumber.Text == "")
            {
                if (Properties.Settings.Default.Lang == "pl-PL")
                {
                    flatNumber.Text = "Nr domu";
                }
                else
                {
                    flatNumber.Text = "Flat num";
                }
            }
        }

        /// <summary>This method describes dependencies between textBoxes, also it depends on the default language</summary>
        private void whereTextBox_Leave(object sender, EventArgs e)
        {
            if (whereTextBox.Text == "")
            {
                if (Properties.Settings.Default.Lang == "pl-PL")
                {
                    whereTextBox.Text = "Wpisz tutaj nazwę ulicy";
                }
                else
                {
                    whereTextBox.Text = "Write here the street name";
                }
            }
        }

        /// <summary>This method describes dependencies between textBoxes, also it depends on the default language</summary>
        private void cityBox_Leave(object sender, EventArgs e)
        {
            if (cityBox.Text == "")
            {
                if (Properties.Settings.Default.Lang == "pl-PL")
                {
                    cityBox.Text = "Nazwa miasta";
                }
                else
                {
                    cityBox.Text = "City name";
                }
            }
        }

        /// <summary>This method describes dependencies between textBoxes, also it depends on the default language</summary>
        private void countryBox_Leave(object sender, EventArgs e)
        {
            if (countryBox.Text == "")
            {
                if (Properties.Settings.Default.Lang == "pl-PL")
                {
                    countryBox.Text = "Nazwa państwa";
                    cityBox.Text = "Nazwa miasta";
                }
                else
                {
                    countryBox.Text = "Country name";
                    cityBox.Text = "City name";
                }
            }
        }

        /// <summary>This method cleans the default textBox's value</summary>
        private void whereTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            whereTextBox.Text = "";
            flatNumber.Text = "";
        }

        /// <summary>This method cleans the default textBox's value</summary>
        private void cityBox_MouseClick(object sender, MouseEventArgs e)
        {
            cityBox.Text = "";
        }

        /// <summary>This method cleans the default textBox's value</summary>
        private void flatNumber_MouseClick(object sender, MouseEventArgs e)
        {
            flatNumber.Text = "";
        }

        /// <summary>On click flag of United Kingdom set the default language to english (UK) and automatically switch to it</summary>
        private void english_Click(object sender, EventArgs e)
        {
            string lang = "en-GB";
            changeLanguage(lang);
            /// save language as a default
            whatList.Items.Clear();
            whatList.ResetText();
            whatList.Items.Add(new Item("Fire"));
            whatList.Items.Add(new Item("Car crush"));
            whatList.Items.Add(new Item("Flood"));
            whatList.Items.Add(new Item("Earthquake"));
            whatList.Items.Add(new Item("Other"));
            Properties.Settings.Default.Lang = lang ;
            Properties.Settings.Default.Save();
        }

        /// <summary>On click flag of Poland set the default language to polish (PL) and automatically switch to it</summary>
        private void polski_Click(object sender, EventArgs e)
        {
            string lang = "pl-PL";
            changeLanguage(lang);
            /// save language as a default
            whatList.Items.Clear();
            whatList.ResetText();
            whatList.Items.Add(new Item("Pożar"));
            whatList.Items.Add(new Item("Stłuczka"));
            whatList.Items.Add(new Item("Powódź"));
            whatList.Items.Add(new Item("Trzęsienie ziemi"));
            whatList.Items.Add(new Item("Inne"));
            Properties.Settings.Default.Lang = lang;
            Properties.Settings.Default.Save();
        }
    }
}
