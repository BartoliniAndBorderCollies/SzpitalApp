using ModelSzpitala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzpitalApp
{
    public partial class WskazDyzurOsoby : Form
    {

        private Pracownik _zalogowany;
        private List<Pracownik> _listaPracownikow;

        public WskazDyzurOsoby(Pracownik zalogowany)
        {
            InitializeComponent();

            _zalogowany = zalogowany;

            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            ZaladujPracownikow();
        }

        private void ZaladujPracownikow()
        {
            _listaPracownikow = Szpital.SzpitalInstance.DostepDoListyPracownikow
                .Where(pracownik => pracownik is Lekarz || pracownik is Pielegniarka)
                .OrderBy(pracownik => pracownik.Nazwisko)
                .ThenBy(pracownik => pracownik.Imie)
                .ToList();


            comboBoxPracownik.DataSource = _listaPracownikow;
            comboBoxPracownik.DisplayMember = "OpisDoComboBoxu";
            comboBoxPracownik.SelectedIndex = -1; //na start nic nie wybrane

            btnZobacz.Enabled = false;
        }


        private void btnZobacz_Click_1(object sender, EventArgs e)
        {

            if (comboBoxPracownik.SelectedItem is not Pracownik pracownik)
            {
                MessageBox.Show("Wybierz pracownika!",
                    "Informacja",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;

            }

            DyzuryPracownikaForm dyzuryPracownikaForm = new DyzuryPracownikaForm(_zalogowany, pracownik);
            dyzuryPracownikaForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnZobacz.Enabled = comboBoxPracownik.SelectedItem is Pracownik;
        }

    }
}
