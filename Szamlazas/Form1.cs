using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamlazas
{
    public partial class Form1 : Form
    {
        Szamlak szamlak;

        public Form1()
        {
            InitializeComponent();
            szamlak = new Szamlak();
        }

        private void felvetenButton_Click(object sender, EventArgs e)
        {
            int osszeg = Convert.ToInt32(osszegNumericUpDown.Value);
            string partner = partnerTextBox.Text;
            Szamla szamla = new Szamla(osszeg, partner);
            szamlak.UjSzamla(szamla);
            partnerTextBox.Text = "";
            osszegNumericUpDown.Value = 10000;
        }

        private void tartozasKeresButton_Click(object sender, EventArgs e)
        {
            string partner = tartozasPartnerTextBox.Text;
            int tartozas = szamlak.Tartozas(partner);
            MessageBox.Show(tartozas.ToString());
        }

        private void mostWantedButton_Click(object sender, EventArgs e)
        {
            string mostwanted = szamlak.MostWantedSzamla();
            string partner = szamlak.SzamlaPartnere(mostwanted);
            int pinz = szamlak.SzamlaOsszege(mostwanted);

            string kiiras = mostwanted + "\n" + partner + "\n" + pinz;
            MessageBox.Show(kiiras);
        }
    }
}
