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
    public partial class UsunPracownikaForm : Form
    {
        private Pracownik _zalogowany;

        public UsunPracownikaForm(Pracownik zalogowany)
        {
            this._zalogowany = zalogowany;
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            string pesel = txtPodajPesel.Text;

            List<Pracownik> listaPracownikow = Szpital.SzpitalInstance.DostepDoListyPracownikow;

            foreach (Pracownik pracownik in listaPracownikow)
            {
                if (pesel == pracownik.Pesel)
                {
                    Szpital.SzpitalInstance.UsunPracownika(pesel);
                    MessageBox.Show("Pomyślnie usunięto pracownika!", "Potwierdzenie");

                    Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(_zalogowany.Id, Akcja.UsunieciePracownika, true);

                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Nie znaleziono pracownika z podanym numerem PESEL", "Informacja");
            Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(_zalogowany.Id, Akcja.UsunieciePracownika, false);
            return;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
