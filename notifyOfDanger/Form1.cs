using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DBase;
using System.Timers;

namespace notifyOfDanger
{
    public partial class Form1 : Form
    {
        Database db = new Database();

        private class Item
        {
            public string Name;
            public Item(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        private System.Timers.Timer timer;
        int accidentCounter = 0;
        public Form1()
        {
            InitializeComponent();
            whatList.Items.Add(new Item("Fire"));
            whatList.Items.Add(new Item("Car crash"));
            whatList.Items.Add(new Item("Flood"));
            whatList.Items.Add(new Item("Earthquake"));
            whatList.Items.Add(new Item("Other"));
            countryBox.Items.Add(new Item("PL"));
            countryBox.Items.Add(new Item("GER"));
            countryBox.Items.Add(new Item("EN"));

            int wait = 3 * 1000;
            timer = new System.Timers.Timer(wait);
            timer.Start();
            timer.Elapsed += checkForUpdates;

             
            // notifyIcon1.ShowBalloonTip(3000);
        }

        public void checkForUpdates(object sender, ElapsedEventArgs e)
        {
         
            // if current accident counter is smaller than actual number of rows in db, it means that db has been updated
            if (accidentCounter < db.countAccidents())
            {
                notifyIcon1.BalloonTipText = db.giveAccidentDetails();
                notifyIcon1.ShowBalloonTip(3000);
                accidentCounter = db.countAccidents(); // countAccidents returns the highest id from 'situationsdb' table
                timer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            whenCalendar.MinDate = DateTime.Now.AddDays(-1); // ability to set yesterday's date
            whenCalendar.MaxDate = DateTime.Now;
        }

        /*public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH-mm-ss-ffff");
        }*/
        

        private void notifyUsBtn_Click(object sender, EventArgs e)
        {
            Danger dan = new Danger();

            dan.AccType = whatList.Text;
            dan.AccDescr = whatTextBox.Text;
            //dan.AccDate = Convert.ToDateTime(whenCalendar.Value);

            dan.AccDate = Convert.ToDateTime(whenCalendar.Value);
            //dan.AccTimestamp = GetTimestamp(dan.AccDate);
            dan.AccLocation = countryBox.Text + "/" + cityBox.Text + "/" + whereTextBox.Text;
            countryBox.ResetText();
            whatList.ResetText();
            whatTextBox.ResetText();
            whenCalendar.Value = DateTime.Today;
            whereTextBox.ResetText();

            db.insertDanger(dan);
            accidentCounter++;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // Toggle the form when the user clicks on the notify icon.

            // Toggling window state
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Minimized;

            // Activate the form.
            Activate();
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
           // var myForm = new Form();
           // myForm.Show();
        }

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

        private void countryBox_MouseClick(object sender, MouseEventArgs e)
        {
            countryBox.Text = "";
        }

        private void whereTextBox_Leave(object sender, EventArgs e)
        {
            if (whereTextBox.Text == "")
            {
                whereTextBox.Text = "Write here the street name";
            }
        }

        private void cityBox_Leave(object sender, EventArgs e)
        {
            if (cityBox.Text == "")
            {
                cityBox.Text = "City name";
            }
        }

        private void countryBox_Leave(object sender, EventArgs e)
        {
            if (countryBox.Text == "")
            {
                countryBox.Text = "Country name";
            }
        }

        private void whereTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            whereTextBox.Text = "";
        }

        private void cityBox_MouseClick(object sender, MouseEventArgs e)
        {
            cityBox.Text = "";
        }
    }
}
