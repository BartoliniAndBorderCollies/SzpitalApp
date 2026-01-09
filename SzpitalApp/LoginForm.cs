using ModelSzpitala;

namespace SzpitalApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UstawMaxRozmiar();
            this.AcceptButton = btnZaloguj;
            this.MaximizeBox = false;
        }

        private void UstawMaxRozmiar()
        {
            var ekran = Screen.PrimaryScreen.WorkingArea;

            this.MaximumSize = new Size(
                (int)(ekran.Width * 0.6),
                (int)(ekran.Height * 0.6)
            );
        }

        private void T³oSzpital_Click(object sender, EventArgs e)
        {

        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;

            Pracownik? zalogowanyPracownik = ModelSzpitala.Szpital.SzpitalInstance.Zaloguj(login, haslo);

            if (zalogowanyPracownik == null)
            {
                MessageBox.Show("Has³o lub login jest niepoprawne!", "B³êdne dane");
                txtLogin.Clear();
                txtHaslo.Clear();
                txtLogin.Focus();
            }
            else
            {
                MainPanelForm mainPanel = new MainPanelForm(zalogowanyPracownik);
                mainPanel.Show();

                this.Hide();
            }
        }
    }
}
