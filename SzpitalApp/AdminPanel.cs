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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListaPracownikow_Click(object sender, EventArgs e)
        {
            lstPracownicy.Items.Clear();
            var pracownicy = ModelSzpitala.Szpital.SzpitalInstance.DostepDoListyPracownikow;

            foreach (Pracownik pracownik in pracownicy)
            {
                lstPracownicy.Items.Add(pracownik);

            }
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();

        }
    }
}
