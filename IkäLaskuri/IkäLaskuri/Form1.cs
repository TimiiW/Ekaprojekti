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
            DateTime startdate = syntymaDTP.Value;
            DateTime enddate = DateTime.Now;

            ikkaTB.Text = calcage(startdate, enddate).ToString();
        }

        public long calcage (System.DateTime startdate,System.DateTime enddate)

        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(startdate.Ticks - enddate.Ticks);
            age = (long)(ts.Days / 365);
            return age;
        }
    }
}
