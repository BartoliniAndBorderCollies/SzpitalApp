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
    public partial class RemoveEmployeeForm : Form
    {
        public RemoveEmployeeForm()
        {
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
                    this.Close();
                    return;
                }
            }
                MessageBox.Show("Nie znaleziono pracownika z podanym numerem PESEL", "Informacja");
                return;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
