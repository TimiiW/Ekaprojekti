﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void tarkistaTB_Click(object sender, EventArgs e)
        {
            if (kayttajaTB.Text == "timi" && salasanaTB.Text == "jaakkokulta")
            {
                salasanapanel.Visible = false;
                salasanaokeinpanel.Visible = true;
            }
            else
            {
                virheviestiLB.Text = "käyttäjätunnus tai salasana virheellinen";
                virheviestiLB.Visible = true;
            }
        }
    }
}
