using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkäLaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {

        }

        private void laskeikäbt_Click(object sender, EventArgs e)
        {
            DateTime synttari = synttariDTP.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            vuosinalb.Text = Math.Ceiling(erotus / 365.25) + "vuotta";
            kuukausinalb.Text = Math.Ceiling(erotus * 12 / 365.25) + "Kuukautta";
            päivinälb.Text = erotus + "päivää";
            tunteinalb.Text = (erotus * 24) + "tunteina";
            minuutteinalb.Text = (erotus * 24 * 60) + "minuutteina";
            sekuntteinalb.Text = (erotus * 24 * 60 * 60) + "sekuntteina";
            vuosinalb.Visible = true;
            kuukausinalb.Visible = true;
            päivinälb.Visible = true;
            minuutteinalb.Visible = true;
            sekuntteinalb.Visible = true;
            tunteinalb.Visible = true;

        }

        private void synttariDTP_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
