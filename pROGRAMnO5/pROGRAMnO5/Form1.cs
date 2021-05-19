using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pROGRAMnO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] inputs = textBox1.Text.ToCharArray();
            Array.Reverse(inputs);
            string outputs = " ";
            for(int i=0;i<inputs.Length;i++){
                outputs += inputs[i];
            }
            label2.Text = outputs;
            label2.Show();
        }
    }
}
