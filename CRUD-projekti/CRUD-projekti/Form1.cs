using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_projekti
{
    public partial class OtsikkoLB : Form
    {
        public OtsikkoLB()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            otsikko.Text = "Heippa maailma";
        }
    }
}
