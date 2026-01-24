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

namespace SzpitalApp
{
    public partial class HistoriaLogowanForm : Form
    {
        public HistoriaLogowanForm()
        {
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void HistoriaLogowanForm_Load(object sender, EventArgs e)
        {
            dataGridViewHistoriaLogowan.DataSource = Szpital.SzpitalInstance.DostepDoHistoriiLogowan;

            foreach (DataGridViewColumn kolumna in dataGridViewHistoriaLogowan.Columns)
            {
                if (kolumna.DataPropertyName == "PobierzDate")
                    kolumna.HeaderText = "Data";

                if (kolumna.DataPropertyName == "PobierzNazweUsera")
                    kolumna.HeaderText = "User";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
