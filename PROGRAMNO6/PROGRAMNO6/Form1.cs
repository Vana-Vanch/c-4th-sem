using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROGRAMNO6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "Empty";
            label1.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "x";
            label1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Empty";
            label1.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '1';
            }else{ textBox2.Text += '1';}
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Empty")
            {
                textBox1.Text += '2';
            }
            else { textBox2.Text += '2'; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '3';
            }
            else { textBox2.Text += '3'; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '4';
            }
            else { textBox2.Text += '4'; };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '5';
            }
            else { textBox2.Text += '5'; };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '6';
            }
            else { textBox2.Text += '6'; }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '7';
            }
            else { textBox2.Text += '7'; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '8';
            }
            else { textBox2.Text += '8'; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '9';
            }
            else { textBox2.Text += '9'; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Empty")
            {
                textBox1.Text += '0';
            }
            else { textBox2.Text += '0'; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            label1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            label1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "%";
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = 0;
            string operation = label1.Text;
            if (operation == "+") {
                num3 = num1 + num2;
                textBox3.Text = num3.ToString();
            }
            else if (operation == "-") {
                num3 = num1 - num2;
                textBox3.Text = num3.ToString();
            }
            else if (operation == "x") {
                num3 = num1 * num2;
                textBox3.Text = num3.ToString();
            }
            else if (operation == "%")
            {
                num3 = num1 / num2;
                textBox3.Text = num3.ToString();
            }
            else {
                textBox3.Text = "Invalid Syntax";
            }
        }
    }
}
