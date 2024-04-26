using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg273Bookclub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int books = int.Parse(textBox1.Text);
            int points = 0;
            if (books == 0) points = 0;
            if (books == 1) points = 5;
            if (books == 2) points = 15;
            if (books == 3) points = 40;
            if (books >= 4) points = 60;
            label2.Text = points.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
