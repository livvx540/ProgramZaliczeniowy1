using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramZaliczeniowy1
{
    public partial class Form1 : Form
    {
        List<Prezent> prezenty = new List<Prezent>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string imie = txtImie.Text;
            string nazwa = txtNazwa.Text;
            decimal cena;

            if (imie == "" || nazwa == "")
            {
                MessageBox.Show("Podaj imię i nazwę prezentu.");
                return;
            }
            if (!decimal.TryParse(txtCena.Text, out cena))
            {
                MessageBox.Show("Cena musi być liczbą!");
                return;
            }
            Prezent p = new Prezent(imie, nazwa, cena);
            prezenty.Add(p);
            AktualizujListe();
            txtImie.Clear();
            txtNazwa.Clear();
            txtCena.Clear();
        }
        private void AktualizujListe()
        {
            listBoxPrezenty.Items.Clear();
            foreach (var p in prezenty)
                listBoxPrezenty.Items.Add(p.ToString());
            lblIlosc.Text = "Ilość prezentów: " + prezenty.Count;
            lblSuma.Text = "Łączny koszt: " + prezenty.Sum(x => x.Cena) + " zł";
        }
    }
}
