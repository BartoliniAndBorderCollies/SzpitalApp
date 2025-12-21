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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();

            cmbSpecjalnosc.DataSource = Enum.GetValues(typeof(Specjalnosc));
            cmbSpecjalnosc.Hide();
        }

        private void cmbRodzajPracownika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? wybranyRodzaj = cmbRodzajPracownika.SelectedItem?.ToString();

            if (wybranyRodzaj == "Lekarz")
            {
                cmbSpecjalnosc.Show();
            }
            else
            {
                cmbSpecjalnosc.Hide();
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
            Specjalnosc specjalnosc = (Specjalnosc)cmbSpecjalnosc.SelectedItem;

            if (CzyPodanoWszystkieDane(rodzajPracownika, imie, nazwisko, pesel, login, haslo))
            {
                DodajPracownika(rodzajPracownika, imie, nazwisko, pesel, login, haslo, specjalnosc);

            }
            else
            {
                return;
            }
            this.Close();
        }

        private void DodajPracownika(string rodzajPracownika, string imie, string nazwisko, string pesel, string login, string haslo, Specjalnosc specjalnosc)
        {
            if (rodzajPracownika == "Lekarz")
            {
                Lekarz lekarz = new Lekarz(imie, nazwisko, pesel, login, haslo, specjalnosc, 0, new List<Dyzur>());
                ModelSzpitala.Szpital.SzpitalInstance.DodajPracownika(lekarz);
                MessageBox.Show("Utworzono pracownika: lekarz");
            }

            if (rodzajPracownika == "Pielęgniarka")
            {
                Pielegniarka pielegniarka = new Pielegniarka(imie, nazwisko, pesel, login, haslo, new List<Dyzur>());
                ModelSzpitala.Szpital.SzpitalInstance.DodajPracownika(pielegniarka);
                MessageBox.Show("Utworzono pracownika: pielęgniarka");
            }

        }

        private bool CzyPodanoWszystkieDane(string rodzajPracownika, string imie, string nazwisko, string pesel, string login, string haslo)
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

            return true;

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
