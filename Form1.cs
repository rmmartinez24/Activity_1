using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_One
{
    public partial class Form1 : Form
    {
        string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitName_Click(object sender, EventArgs e)
        {
            label2.Text = "Hello " + name;
            label3.Text = "Have a great day";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
