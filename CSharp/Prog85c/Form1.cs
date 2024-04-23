using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog85c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            int num1 = int.Parse(textBox1.Text);
            int num2 = num1 - 165;
            double num3 = num2 / 100;
            double num4 = Math.Round(num3);
            


        }
    }
}
