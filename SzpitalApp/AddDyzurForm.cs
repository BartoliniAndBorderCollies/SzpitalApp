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
    public partial class AddDyzurForm : Form
    {
        private Pracownik _pracownik;

        public AddDyzurForm(Pracownik pracownik)
        {
            _pracownik = pracownik;
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DateTime dataRozpoczecia = mthCalendar.SelectionStart;
            DateTime dataZakonczenia = dataRozpoczecia.AddDays(1);

            Dyzur dyzur = new Dyzur(_pracownik, dataRozpoczecia, dataZakonczenia);

            if (_pracownik is Lekarz lekarz)
            {
                lekarz.DodajDyzur(dyzur);
            }
            else if (_pracownik is Pielegniarka pielegniarka)
            {
                pielegniarka.DodajDyzur(dyzur);

            }
            else if (_pracownik is Administrator)
            {
                MessageBox.Show("Nie można przypisać dyżuru administratorowi!");
                this.Close();
                
            }

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
