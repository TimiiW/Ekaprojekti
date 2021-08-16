using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekaprojekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muutabt_Click(object sender, EventArgs e)
        {
            tekstilb.Text = "Boo";
        }

        private void muutabt2_Click(object sender, EventArgs e)
        {
            tekstilb.Text = "teksti";
        }

        private void näytäbt_Click(object sender, EventArgs e)
        {
            tekstitb2.Visible = true; tekstitb3.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
