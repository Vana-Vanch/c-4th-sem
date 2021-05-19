using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string today_date = now.Date.ToString();
            string day_date = now.Day.ToString();
            string monthss = months[now.Month - 1];
            string week = now.DayOfWeek.ToString();
            label1.Text = today_date;
            label2.Text = day_date;
            label3.Text = monthss;
            label4.Text = week;
            label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            if (year % 400 == 0)
            {
                label9.Text = "Leap year";
                label9.Show();
            }
            else if (year % 100 == 0) {
                label9.Text = "Not Leap year";
                label9.Show();
            }
            else if (year % 4 == 0)
            {
                label9.Text = "Leap year";
                label9.Show();
            }
            else {
                label9.Text = "Not Leap year";
                label9.Show();
            }
        }
    }
}
