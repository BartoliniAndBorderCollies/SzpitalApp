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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DateTime dataRozpoczecia = mthCalendar.SelectionStart;
            DateTime dataZakonczenia = dataRozpoczecia.AddDays(1);

            string komunikat = "";

            Dyzur dyzur = new Dyzur(_pracownik, dataRozpoczecia, dataZakonczenia);

            if (_pracownik is Lekarz lekarz)
            {
                komunikat = lekarz.DodajDyzur(dyzur);
                
            }
            else if (_pracownik is Pielegniarka pielegniarka)
            {
                komunikat = pielegniarka.DodajDyzur(dyzur);
   

            }
            else if (_pracownik is Administrator)
            {
                komunikat = "Nie można przypisać dyżuru administratorowi!";
              
            }

            MessageBox.Show(komunikat);

            if(komunikat == "Dyżur dodany")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
