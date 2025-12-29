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
        private bool trybEdycji = false;

        public ListaPracownikowForm()
        {
            InitializeComponent();
            dataGridViewPracownicy.CellFormatting += dataGridViewPracownicy_CellFormatting;
            dataGridViewPracownicy.CellContentClick += dataGridViewPracownicy_CellContentClick;
        }

        private void ListaPracownikowForm_Load(object sender, EventArgs e)
        {

            dataGridViewPracownicy.AutoGenerateColumns = false;
            dataGridViewPracownicy.Columns.Clear();
            dataGridViewPracownicy.ReadOnly = true;


            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                ReadOnly = true,
                Name = "Id"
            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Typ pracownika",
                Name = "TypPracownika",
                ReadOnly = true
            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Imie",
                HeaderText = "Imię",
                Name = "Imie"

            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nazwisko",
                HeaderText = "Nazwisko",
                Name = "Nazwisko"

            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Pesel",
                HeaderText = "PESEL",
                Name = "Pesel"

            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NazwaUzytkownika",
                HeaderText = "Login",
                Name = "NazwaUzytkownika"

            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Specjalność",
                Name = "Specjalnosc",
                ReadOnly = true
            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "PWZ",
                Name = "PWZ",
                ReadOnly = true
            });

            dataGridViewPracownicy.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Dyżury",
                Text = "Zobacz",
                UseColumnTextForButtonValue = true,
                Name = "Dyzury",
                ReadOnly = true
            });


            dataGridViewPracownicy.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HashHasla",
                HeaderText = "Zahashowane hasło",
                Name = "HashHasla"

            });

            dataGridViewPracownicy.DataSource = Szpital.SzpitalInstance.DostepDoListyPracownikow;

        }

        private void dataGridViewPracownicy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)

        {
            if (e.RowIndex < 0) return;

            var pracownik = dataGridViewPracownicy.Rows[e.RowIndex].DataBoundItem as Pracownik;

            if (pracownik == null) return;

            var column = dataGridViewPracownicy.Columns[e.ColumnIndex].Name;

            if (column == "TypPracownika")
            {
                e.Value = pracownik.GetType().Name;
            }
            else if (column == "Specjalnosc")
            {
                e.Value = pracownik is Lekarz lekarz ? lekarz.PokazSpecjalnosc.ToString() : "";
            }
            else if (column == "PWZ")
            {
                e.Value = pracownik is Lekarz lekarz ? lekarz.PokazPWZ.ToString() : "";
            }
        }

        private void dataGridViewPracownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewPracownicy.Columns[e.ColumnIndex].Name == "Dyzury")
            {
                var pracownik = dataGridViewPracownicy.Rows[e.RowIndex].DataBoundItem as Pracownik;

                var form = new DyzuryPracownikaForm(pracownik);
                form.ShowDialog();
            }
        }




        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

            if (!trybEdycji)
            {
                trybEdycji = true;
                dataGridViewPracownicy.ReadOnly = false;
                btnEdytuj.Text = "Zapisz";

                MessageBox.Show("Tryb edycji włączony");

            }
            else
            {

                var result = MessageBox.Show(
                    "Czy zapisać zmiany?",
                    "Potwierdzenie zapisu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    dataGridViewPracownicy.ReadOnly = true;
                    trybEdycji = false;
                    btnEdytuj.Text = "Edytuj";

                    MessageBox.Show("Zmiany zapisane");
                }
            }
        }
    }
}

