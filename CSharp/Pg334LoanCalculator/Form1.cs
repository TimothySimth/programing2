using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg334LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Ncar = 0;
            double Ucar = 0;
            int costofcar = int.Parse(textBox1.Text);
            int downpayment = int.Parse(textBox2.Text);
            int numbermounths = int.Parse(textBox3.Text);
            double anualintrestrate = double.Parse(textBox4.Text);
            int num1 = costofcar - downpayment;
            const double new_rate = 0.089;
            const double used_rate = 0.095;


            
            

            
            {

            }
        }
    }
}
