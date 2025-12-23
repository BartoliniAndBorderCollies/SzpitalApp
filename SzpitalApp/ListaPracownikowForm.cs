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
        }

        private void ListaPracownikowForm_Load(object sender, EventArgs e)
        {
            dataGridViewPracownicy.DataSource = Szpital.SzpitalInstance.DostepDoListyPracownikow;

            dataGridViewPracownicy.Columns["Id"].ReadOnly = true;
            dataGridViewPracownicy.Columns["HashHasla"].Visible = false;
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

