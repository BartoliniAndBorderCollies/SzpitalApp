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
            ListaPracownikowForm listaPracownikowForm = new ListaPracownikowForm();
            listaPracownikowForm.ShowDialog();
            

        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();

        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {
            RemoveEmployeeForm removeEmployeeForm = new RemoveEmployeeForm();
            removeEmployeeForm.ShowDialog();
        }
    }
}
