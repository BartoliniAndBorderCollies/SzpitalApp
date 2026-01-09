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
        public WskazDyzurOsoby()
        {
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {
            btnZobacz.Enabled =
                !string.IsNullOrWhiteSpace(txtBxImie.Text) &&
                !string.IsNullOrWhiteSpace(txtBxNazwisko.Text);
        }



        private void btnZobacz_Click_1(object sender, EventArgs e)
        {

            string imie = txtBxImie.Text.Trim();
            string nazwisko = txtBxNazwisko.Text.Trim();

            Pracownik? pracownik = Szpital.SzpitalInstance.SzukajPracownika(imie, nazwisko);

            if (pracownik == null)
            {
                MessageBox.Show(
                    "Nie znaleziono pracownika o podanych danych.",
                    "Brak wyników",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DyzuryPracownikaForm dyzuryPracownikaForm = new DyzuryPracownikaForm(pracownik);
            dyzuryPracownikaForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
