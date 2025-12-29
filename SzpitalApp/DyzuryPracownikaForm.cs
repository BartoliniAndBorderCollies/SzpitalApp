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
    public partial class DyzuryPracownikaForm : Form
    {
        private Pracownik _pracownik;

        public DyzuryPracownikaForm(Pracownik pracownik)
        {
            InitializeComponent();
            _pracownik = pracownik;
            this.Load += DyzuryPracownikaForm_Load;
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void DyzuryPracownikaForm_Load(object sender, EventArgs e)
        {
            dataGridViewDyzury.AutoGenerateColumns = false;
            dataGridViewDyzury.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDyzury.Columns.Clear();
            dataGridViewDyzury.ReadOnly = true;

            lblPracownik.Text = $"Dyżury pracownika: {_pracownik.Imie} {_pracownik.Nazwisko} - {_pracownik.GetType().Name}";

            dataGridViewDyzury.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataRozpoczecia",
                HeaderText = "Data rozpoczęcia",
                Name = "DataRozpoczecia"
            });

            dataGridViewDyzury.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataZakonczenia",
                HeaderText = "Data zakończenia",
                Name = "DataZakonczenia"
            });

            if (_pracownik is Lekarz lekarz)
            {
                dataGridViewDyzury.DataSource = new BindingList<Dyzur>(lekarz.PokazListeDyzurow.ToList());
            }

            else if (_pracownik is Pielegniarka pielegniarka)
            {
                dataGridViewDyzury.DataSource = new BindingList<Dyzur>(pielegniarka.PokazListeDyzurow.ToList());
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AddDyzurForm addDyzurForm = new AddDyzurForm(_pracownik);

            if (addDyzurForm.ShowDialog() == DialogResult.OK)
            {
                OdswiezListeDyzurow();
            }
        }

        private void OdswiezListeDyzurow()
        {
            if (_pracownik is Lekarz lekarz)
            {
                dataGridViewDyzury.DataSource = null;
                dataGridViewDyzury.DataSource = new BindingList<Dyzur>(lekarz.PokazListeDyzurow.ToList());
            }
            else if (_pracownik is Pielegniarka pielegniarka)
            {
                dataGridViewDyzury.DataSource = null;
                dataGridViewDyzury.DataSource = new BindingList<Dyzur>(pielegniarka.PokazListeDyzurow.ToList());
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
