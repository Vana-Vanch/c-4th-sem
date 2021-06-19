using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nmabar10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else {
                f2.Activate();
            }
        }
        void f2_FormClosed(object sender, FormClosedEventArgs e) {
            f2 = null;
        }
        Form3 f3;
        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += new FormClosedEventHandler(f3_FormClosed);
                f3.Show();
            }
            else
            {
                f3.Activate();
            }
        }
        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
        }
    }
}
