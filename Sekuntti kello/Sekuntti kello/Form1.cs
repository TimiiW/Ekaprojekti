using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekuntti_kello
{
    public partial class SekkariForm : Form
    {
        private Stopwatch sekkari;
        public SekkariForm()
        {
            InitializeComponent();
        }



        private void KäynnistäBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void TyhjennäBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }
        private void SekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }
        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
