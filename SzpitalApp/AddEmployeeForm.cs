using Microsoft.VisualBasic.Logging;
using ModelSzpitala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SzpitalApp
{
    public partial class AddEmployeeForm : BaseForm
    {
        public AddEmployeeForm()
        {
            InitializeComponent();

            cmbSpecjalnosc.DataSource = Enum.GetValues(typeof(Specjalnosc));
            cmbSpecjalnosc.Hide();
            txtPWZ.Hide();
        }

        private void cmbRodzajPracownika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? wybranyRodzaj = cmbRodzajPracownika.SelectedItem?.ToString();

            if (wybranyRodzaj == "Lekarz")
            {
                cmbSpecjalnosc.Show();
                txtPWZ.Show();
            }
            else
            {
                cmbSpecjalnosc.Hide();
                txtPWZ.Hide();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string? rodzajPracownika = cmbRodzajPracownika.SelectedItem?.ToString();
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string pesel = txtPesel.Text;
            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;

            Specjalnosc specjalnosc = default;

            if (rodzajPracownika == "Lekarz")
            {
                specjalnosc = (Specjalnosc)cmbSpecjalnosc.SelectedItem!;

            }

            int PWZ = 0;
            if (!int.TryParse(txtPWZ.Text, out PWZ) && rodzajPracownika == "Lekarz")
            {
                MessageBox.Show("PWZ musi być liczbą!");
                return;
            }

            if (CzyPodanoWszystkieDane(rodzajPracownika, imie, nazwisko, pesel, login, haslo, specjalnosc, PWZ))
            {
                DodajPracownika(rodzajPracownika, imie, nazwisko, pesel, login, haslo, specjalnosc, PWZ);

            }
            else
            {
                return;
            }
            this.Close();
        }

        private void DodajPracownika(string rodzajPracownika, string imie, string nazwisko, string pesel, string login, string haslo, Specjalnosc specjalnosc, int PWZ)
        {
            if (rodzajPracownika == "Lekarz")
            {
                Lekarz lekarz = new Lekarz(imie, nazwisko, pesel, login, haslo, specjalnosc, PWZ, new List<Dyzur>());
                ModelSzpitala.Szpital.SzpitalInstance.DodajPracownika(lekarz);
            }

            if (rodzajPracownika == "Pielęgniarka")
            {
                Pielegniarka pielegniarka = new Pielegniarka(imie, nazwisko, pesel, login, haslo, new List<Dyzur>());
                ModelSzpitala.Szpital.SzpitalInstance.DodajPracownika(pielegniarka);
            }

        }

        private bool CzyPodanoWszystkieDane(string rodzajPracownika, string imie, string nazwisko, string pesel, string login, string haslo, Specjalnosc specjalnosc, int PWZ)
        {
            if (string.IsNullOrWhiteSpace(rodzajPracownika) ||
                string.IsNullOrWhiteSpace(imie) ||
                string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(pesel) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return false;
            }

            if (rodzajPracownika == "Lekarz" && cmbSpecjalnosc.SelectedItem == null)
            {
                MessageBox.Show("Wybierz specjalność lekarza!");
                return false;
            }

            if (rodzajPracownika == "Lekarz" && PWZ == 0)
            {
                MessageBox.Show("Wpisz PWZ lekarza!");
                return false;
            }

            return true;

        }

    }
}
