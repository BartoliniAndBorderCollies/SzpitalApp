using ModelSzpitala;
using ModelSzpitala.Utils;
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
    public partial class MainPanelForm : BaseForm
    {
        private Pracownik _zalogowany;

        public MainPanelForm(Pracownik zalogowany)
        {
            InitializeComponent();
            _zalogowany = zalogowany;

            SkonfigurujWidok();
        }

        private void SkonfigurujWidok()
        {
            adminPanel.Visible = false;
            panelPersonel.Visible = false;

            if (_zalogowany is Administrator)
            {
                adminPanel.Dock = DockStyle.Fill;
                adminPanel.Visible = true;
            }
            else
            {
                panelPersonel.Dock = DockStyle.Fill;
                panelPersonel.Visible = true;
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var decyzja = MessageBox.Show(
                "Czy na pewno chcesz zakończyć program?",
                "Zamykanie aplikacji",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (decyzja == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                SzpitalSerializer.Zapisz(Szpital.SzpitalInstance);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Błąd zapisu danych:\n" + exception.Message,
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            base.OnFormClosing(e);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Close(); //i tak OnFormClosing() się wykona - bo close() zamyka winForm

        }


        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListaPracownikow_Click(object sender, EventArgs e)
        {
            ListaPracownikowForm listaPracownikowForm = new ListaPracownikowForm(_zalogowany);
            listaPracownikowForm.ShowDialog();


        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm addEmployeeForm = new DodajPracownikaForm();
            addEmployeeForm.ShowDialog();

        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {
            UsunPracownikaForm removeEmployeeForm = new UsunPracownikaForm();
            removeEmployeeForm.ShowDialog();
        }

        private void btnPlanDyzurow_Click(object sender, EventArgs e)
        {
            WskazDyzurOsoby wskazDyzurOsoby = new WskazDyzurOsoby(_zalogowany);
            wskazDyzurOsoby.ShowDialog();
        }

        private void btnListaPersonelu_Click(object sender, EventArgs e)
        {
            ListaPracownikowForm listaPracownikowForm = new ListaPracownikowForm(_zalogowany);
            listaPracownikowForm.ShowDialog();
        }
    }
}
