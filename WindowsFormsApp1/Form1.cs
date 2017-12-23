using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 form;
        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.test();
        }
    }
}
