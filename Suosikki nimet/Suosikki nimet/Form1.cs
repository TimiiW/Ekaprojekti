using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suosikki_nimet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\timiw\\source\\repos\\Ekaprojekti\\Suosikki nimet\\pojat.txt");
            string[] tytöt = File.ReadAllLines("C:\\Users\\timiw\\source\\repos\\Ekaprojekti\\Suosikki nimet\\tytöt.txt");
            string nimi = textBox1.Text;
            int laskurip = 1, laskurit = 1;
            foreach (string poju in pojat)
            {
                if (nimi == poju)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". Suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string friidu in tytöt)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". Suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta!";
                VastausLB.Visible = true;
            }
        }
    }
}
