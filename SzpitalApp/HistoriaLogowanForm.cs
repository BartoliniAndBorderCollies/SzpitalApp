using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelSzpitala;
using ModelSzpitala.Security;

namespace SzpitalApp
{
    public partial class HistoriaLogowanForm : Form
    {
        private Pracownik _zalogowany;

        public HistoriaLogowanForm(Pracownik zalogowany)
        {
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this._zalogowany = zalogowany;
        }

        private void HistoriaLogowanForm_Load(object sender, EventArgs e)
        {
            dataGridViewHistoriaLogowan.DataSource = Szpital.SzpitalInstance.DostepDoHistoriiLogowan;

            foreach (DataGridViewColumn kolumna in dataGridViewHistoriaLogowan.Columns)
            {
                if (kolumna.DataPropertyName == nameof(ZdarzenieLogowania.DataLogowania))
                    kolumna.HeaderText = "Data";

                if (kolumna.DataPropertyName == nameof(ZdarzenieLogowania.NazwaUsera))
                    kolumna.HeaderText = "User";

            }

            Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(_zalogowany.Id, Akcja.WyswietlenieHistoriiLogowan, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IReadOnlyList<ZdarzenieLogowania> ListaLogowan = Szpital.SzpitalInstance.DostepDoHistoriiLogowan;

            bool CzyUdane = false;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Zapisz historię logowań";
                dialog.Filter = "Plik CSV (*.csv)|*.csv";
                dialog.FileName = "historia_logowan.csv";

                dialog.DefaultExt = "csv"; //wymuszenie rozszerzenia .csv
                dialog.AddExtension = true;


                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    string sciezkaDoZapisu = dialog.FileName;
                    ModelSzpitala.Utils.CsvExporter.EksportujHistorieLogowan(ListaLogowan, sciezkaDoZapisu);
                    CzyUdane = true;

                }
            }

            Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(_zalogowany.Id, Akcja.EkportHistoriiLogowan, CzyUdane);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
