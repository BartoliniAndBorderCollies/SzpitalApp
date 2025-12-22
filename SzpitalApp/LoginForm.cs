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

            Pracownik? pracownik = ModelSzpitala.Szpital.SzpitalInstance.Zaloguj(login, haslo);

            if (pracownik == null)
            {
                MessageBox.Show("Has³o lub login jest niepoprawne!");
                txtLogin.Clear();
                txtHaslo.Clear();
                txtLogin.Focus();
            }
            else
            {
                MainPanel mainPanel = new MainPanel();
                mainPanel.Show();

                this.Hide();
            }
        }
    }
}
