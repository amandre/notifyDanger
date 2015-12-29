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

namespace notifyOfDanger
{
    public partial class Form1 : Form
    {
        //private NotifyIcon notifyIcon1;
        //private ContextMenu contextMenu1;
        //private MenuItem menuItem1;
        //private IContainer components;

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

        public Form1()
        {
            InitializeComponent();
            whatList.Items.Add(new Item("Fire"));
            whatList.Items.Add(new Item("Car crash"));
            whatList.Items.Add(new Item("Flood"));
            whatList.Items.Add(new Item("Earthquake"));
            whatList.Items.Add(new Item("Other"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            whenCalendar.MinDate = DateTime.Now.AddDays(-1); // umozliwia zaznaczenie wypadku z dnia poprzedniego
            whenCalendar.MaxDate = DateTime.Now;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form when the user single or double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;

            // Activate the form.
            Activate();
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
            dan.AccLocation = whereTextBox.Text;
            whatList.ResetText();
            whatTextBox.ResetText();
            whenCalendar.Value = DateTime.Today;
            whereTextBox.ResetText();

            db.insertDanger(dan);
        }

        private void getNotifBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
