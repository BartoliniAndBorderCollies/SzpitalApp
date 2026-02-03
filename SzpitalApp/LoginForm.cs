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
                ModelSzpitala.Szpital.SzpitalInstance.DodajZdarzenieLogowania(new ModelSzpitala.Security.ZdarzenieLogowania(DateTime.Now, login, false));
                ModelSzpitala.Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(null, Akcja.Logowanie, false);

                MessageBox.Show("Has³o lub login jest niepoprawne!", "B³êdne dane");
                txtLogin.Clear();
                txtHaslo.Clear();
                txtLogin.Focus();
            }
            else
            {
                ModelSzpitala.Szpital.SzpitalInstance.DodajZdarzenieLogowania(new ModelSzpitala.Security.ZdarzenieLogowania(DateTime.Now, login, true));
                ModelSzpitala.Szpital.SzpitalInstance.ZarejestrujZdarzenieWsystemie(zalogowanyPracownik.Id, Akcja.Logowanie, true);

                MainPanelForm mainPanel = new MainPanelForm(zalogowanyPracownik);
                mainPanel.Show();

                this.Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
