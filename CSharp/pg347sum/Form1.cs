using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pg347sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int variable = int.Parse(Interaction.InputBox("Prompt here", "Title"));
            int x = 0;
            for (int lcv = 0; lcv <= variable; lcv++) {
               x += lcv;
            }
            MessageBox.Show(x.ToString());
            
            

            
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}