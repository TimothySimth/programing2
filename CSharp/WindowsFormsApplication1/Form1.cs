using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("X\t\tY");
            for (int x = -12; x <= 16; x++) {
                double Owen = Math.Pow(x, 3) - 3 * Math.Pow(x, 5) - 93 * Math.Pow(x, 4) + 87 * Math.Pow(x, 3) + 1596 * Math.Pow(x, 2) - 1380 * x - 2800;
                listBox1.Items.Add(x + "\t\t" + Owen);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
