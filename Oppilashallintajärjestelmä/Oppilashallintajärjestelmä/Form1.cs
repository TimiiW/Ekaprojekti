using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppilashallintajärjestelmä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
        }

        private void tyhjennäBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            puhTB.Text = "";
            emailTB.Text = "";
            ONroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int ONro = Int32.Parse(ONro.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || ONro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = OPISKELIJA.lisaaOpiskelija(enimi, snimi, puhelin, email, ONro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisays", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisays", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void päivitäBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int ONro = Int32.Parse(ONro.Text);

            if (oid.equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || ONro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = OPISKELIJA.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, ONro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa  ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (OPISKELIJA.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennäBT.PerformClick();
        }
    }
}
