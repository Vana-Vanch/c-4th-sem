using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vowel = 0;
            int consonant = 0;
            int special_symbol = 0;
            int number = 0;
            string textbox = textBox1.Text;
            for (int i = 0; i < textbox.Length; i++)
            {
                if (textbox[i] == 'a' || textbox[i] == 'e' || textbox[i] == 'i' || textbox[i] == 'o' || textbox[i] == 'u')
                {
                    vowel++;
                }
                else if (textbox[i] >= 'a' && textbox[i] <= 'z')
                {
                    consonant++;
                }
                else if (textbox[i] >= '0' && textbox[i] <= '9')
                {
                    number++;
                }
                else
                {
                    special_symbol++;
                }

            }
            label1.Text += vowel;
            label2.Text += consonant;
            label3.Text += number;
            label4.Text += special_symbol;
        }
    }
}
