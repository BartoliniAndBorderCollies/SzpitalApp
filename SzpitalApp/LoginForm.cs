using ModelSzpitala;

namespace SzpitalApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void T³oSzpital_Click(object sender, EventArgs e)
        {

        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string haslo = txtHaslo.Text;

            Pracownik? pracownik = ModelSzpitala.Szpital.SzpitalInstance.Zaloguj(login, haslo);

            if (pracownik == null)
            {
                MessageBox.Show("Has³o lub login jest niepoprawne!");
                txtLogin.Clear();
                txtHaslo.Clear();
                txtHaslo.Focus();
            }
            else if (pracownik is Administrator)
            {
                MessageBox.Show("Logowanie jako administrator");

                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Zalogowano");
            }

        }
    }
}
