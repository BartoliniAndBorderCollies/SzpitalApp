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
        private Pracownik _zalogowany;
        private BindingList<Dyzur> _bindingDyzurow;


        public DyzuryPracownikaForm(Pracownik zalogowany, Pracownik pracownik)
        {
            InitializeComponent();

            _pracownik = pracownik;
            _zalogowany = zalogowany;

            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            this.Load += DyzuryPracownikaForm_Load;

            SkonfigurujUprawnienia();
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
                Name = "DataRozpoczecia",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd.MM.yyyy"
                }
            });

            dataGridViewDyzury.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataZakonczenia",
                HeaderText = "Data zakończenia",
                Name = "DataZakonczenia",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd.MM.yyyy"
                }
            });


            if (_pracownik is Lekarz lekarz)
            {
                _bindingDyzurow = new BindingList<Dyzur>();
                foreach (var d in lekarz.PokazListeDyzurow)
                    _bindingDyzurow.Add(d);

            }
            else if (_pracownik is Pielegniarka pielegniarka)
            {

                _bindingDyzurow = new BindingList<Dyzur>();
                foreach (var d in pielegniarka.PokazListeDyzurow)
                    _bindingDyzurow.Add(d);

            }

            dataGridViewDyzury.DataSource = _bindingDyzurow;

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
            _bindingDyzurow.Clear();

            if (_pracownik is Lekarz l)
                foreach (var d in l.PokazListeDyzurow)
                    _bindingDyzurow.Add(d);

            if (_pracownik is Pielegniarka p)
                foreach (var d in p.PokazListeDyzurow)
                    _bindingDyzurow.Add(d);
        }


        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

            if (dataGridViewDyzury.CurrentRow?.DataBoundItem is not Dyzur zaznaczonyDyzur)
            {
                MessageBox.Show("Zaznacz dyżur do usunięcia!", "Informacja");
                return;
            }

            var wynik = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony dyżur?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (wynik == DialogResult.Yes)
            {

                if (_pracownik is Lekarz lekarz)
                {
                    lekarz.UsunDyzur(zaznaczonyDyzur);
                    MessageBox.Show("Dyżur został usunięty!", "Informacja");
                    OdswiezListeDyzurow();

                }
                else if (_pracownik is Pielegniarka pielegniarka)
                {
                    pielegniarka.UsunDyzur(zaznaczonyDyzur);
                    MessageBox.Show("Dyżur został usunięty!", "Informacja");
                    OdswiezListeDyzurow();
                }
            }
        }

        private void SkonfigurujUprawnienia()
        {

            btnDodaj.Visible = false;
            btnUsun.Visible = false;

            //admin może dodawać/usuwać
            if (_zalogowany is Administrator)
            {
                btnDodaj.Visible = true;
                btnUsun.Visible = true;
                return;
            }

            // lekarz/pielęgniarka – tylko własne dyżury
            if (_zalogowany == _pracownik)
            {
                btnDodaj.Visible = true;
                btnUsun.Visible = true;
            }
        }

    }
}
