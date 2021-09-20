using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Päiväkirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\timiw\\source\\repos\\Ekaprojekti\\Päiväkirja\\Päiväkirjani.txt");
            teksti += SyöttöTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter(@"C:\\Users\\timiw\\source\\repos\\Ekaprojekti\\Päiväkirja\\Päiväkirjani.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
