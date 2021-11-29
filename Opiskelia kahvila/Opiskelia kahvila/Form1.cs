using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opiskelia_kahvila
{
    public partial class Ruokalistaform : Form
    {
        public Ruokalistaform()
        {
            InitializeComponent();
        }

        private void Ruokalistaform_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:00 joka päivä maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\n keudan oppilaskunnan kavhilasta saa lämpimien \n"
            meistaLB.Text += "juomien lisäksi virvokkeita seka pienta purtavaa ja makeisia\n",
            meistaLB.Text += "tervetuloa tutustumaan!\n"
            meistaLB.Font = new Font("Arial", 12);
        }
    }
}
