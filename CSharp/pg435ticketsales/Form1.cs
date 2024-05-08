using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg435ticketsales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) { Application.Exit(); }

        private void button1_Click(object sender, EventArgs e) {
            Form frm = new Genaralform(this);
            frm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e) {
            Form frm = new studentdorm(this);
            frm.Show();
            this.Hide();
        }
    }
}
