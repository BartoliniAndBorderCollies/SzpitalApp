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
    public partial class ListaPracownikowForm : BaseForm
    {
        public ListaPracownikowForm()
        {
            InitializeComponent();
        }

        private void ListaPracownikowForm_Load(object sender, EventArgs e)
        {
            var pracownicy = Szpital.SzpitalInstance.DostepDoListyPracownikow;

            dataGridViewPracownicy.DataSource = pracownicy.Select(p => new
            {
                id = p.Id,
                Imie = p.Imie,
                Nazwisko = p.Nazwisko,
                Rola = p.GetType().Name,
                Specjalnosc = (p is Lekarz lekarz) ? lekarz.PokazSpecjalnosc.ToString() : "",
                NumerPWZ = (p is Lekarz lekarz2) ? lekarz2.PokazPWZ.ToString() : "",
                PESEL = p.Pesel,
                Login = p.NazwaUzytkownika,
                Haslo = p.Haslo,

            }).ToList();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
