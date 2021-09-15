using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Kysymystä
{
    public partial class Form1 : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatvastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        public Form1()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus" + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatvastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            Tyhjaavastaus();
        }
        private void Tyhjaavastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
