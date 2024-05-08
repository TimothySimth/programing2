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
    public partial class studentdorm : Form
    {
        private Form myParent;
        public studentdorm(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        private void studentdorm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m; // Sales tax
        private decimal calctax(decimal cost) { return cost * decTAXRATE; }
    }
}
