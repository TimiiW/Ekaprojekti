using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeitäBT_Click(object sender, EventArgs e)
        {
            piirranoppa(noppa01PB);
            piirranoppa(noppa02PB);
        }

        private void piirranoppa(PictureBox noppabox)
        {
            Random satunnaninen = new Random();
            int noppa = satunnaninen.Next(1, 7);
            switch(noppa)
            {
                case 1:
                    noppabox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    noppabox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    noppabox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    noppabox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    noppabox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    noppabox.Image = Properties.Resources.dice06;
                    break;
            }
        }

        private void noppa01PB_Click(object sender, EventArgs e)
        {

        }
    }
}
