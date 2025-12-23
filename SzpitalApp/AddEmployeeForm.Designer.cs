namespace SzpitalApp
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbRodzajPracownika = new ComboBox();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtPesel = new TextBox();
            txtLogin = new TextBox();
            txtHaslo = new TextBox();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            label1 = new Label();
            cmbSpecjalnosc = new ComboBox();
            txtPWZ = new TextBox();
            panelContent = new Panel();
            panelBackground = new Panel();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // cmbRodzajPracownika
            // 
            cmbRodzajPracownika.FormattingEnabled = true;
            cmbRodzajPracownika.Items.AddRange(new object[] { "Lekarz", "Pielęgniarka" });
            cmbRodzajPracownika.Location = new Point(50, 224);
            cmbRodzajPracownika.Name = "cmbRodzajPracownika";
            cmbRodzajPracownika.Size = new Size(331, 40);
            cmbRodzajPracownika.TabIndex = 0;
            cmbRodzajPracownika.Text = "Wybierz rodzaj pracownika";
            cmbRodzajPracownika.SelectedIndexChanged += cmbRodzajPracownika_SelectedIndexChanged;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(50, 335);
            txtImie.Name = "txtImie";
            txtImie.PlaceholderText = "Imię";
            txtImie.Size = new Size(200, 39);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(50, 465);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.PlaceholderText = "Nazwisko";
            txtNazwisko.Size = new Size(200, 39);
            txtNazwisko.TabIndex = 2;
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(440, 224);
            txtPesel.Name = "txtPesel";
            txtPesel.PlaceholderText = "Pesel";
            txtPesel.Size = new Size(200, 39);
            txtPesel.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(440, 335);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(200, 39);
            txtLogin.TabIndex = 4;
            // 
            // txtHaslo
            // 
            txtHaslo.Location = new Point(440, 465);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.PlaceholderText = "Hasło";
            txtHaslo.Size = new Size(200, 39);
            txtHaslo.TabIndex = 5;
            txtHaslo.UseSystemPasswordChar = true;
            txtHaslo.TextChanged += txtHaslo_TextChanged;
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = SystemColors.GrayText;
            btnZapisz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZapisz.ForeColor = SystemColors.ButtonHighlight;
            btnZapisz.Location = new Point(85, 827);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(207, 112);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(440, 827);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(218, 112);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(213, 71);
            label1.Name = "label1";
            label1.Size = new Size(348, 45);
            label1.TabIndex = 8;
            label1.Text = "Dodawanie pracownika";
            // 
            // cmbSpecjalnosc
            // 
            cmbSpecjalnosc.FormattingEnabled = true;
            cmbSpecjalnosc.Items.AddRange(new object[] { "Kardiolog", "Neurolog", "Laryngolog" });
            cmbSpecjalnosc.Location = new Point(50, 593);
            cmbSpecjalnosc.Name = "cmbSpecjalnosc";
            cmbSpecjalnosc.Size = new Size(242, 40);
            cmbSpecjalnosc.TabIndex = 9;
            cmbSpecjalnosc.Text = "Specjalność";
            cmbSpecjalnosc.Visible = false;
            // 
            // txtPWZ
            // 
            txtPWZ.Location = new Point(440, 593);
            txtPWZ.Name = "txtPWZ";
            txtPWZ.PlaceholderText = "PWZ";
            txtPWZ.Size = new Size(200, 39);
            txtPWZ.TabIndex = 10;
            txtPWZ.Visible = false;
            // 
            // panelContent
            // 
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(btnAnuluj);
            panelContent.Controls.Add(txtPWZ);
            panelContent.Controls.Add(btnZapisz);
            panelContent.Controls.Add(cmbRodzajPracownika);
            panelContent.Controls.Add(cmbSpecjalnosc);
            panelContent.Controls.Add(txtImie);
            panelContent.Controls.Add(txtHaslo);
            panelContent.Controls.Add(txtNazwisko);
            panelContent.Controls.Add(txtLogin);
            panelContent.Controls.Add(txtPesel);
            panelContent.Dock = DockStyle.Left;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(828, 1148);
            panelContent.TabIndex = 11;
            // 
            // panelBackground
            // 
            panelBackground.BackgroundImage = Properties.Resources.Views_of_a_Foetus_in_the_Womb;
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(828, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1450, 1148);
            panelBackground.TabIndex = 12;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(panelBackground);
            Controls.Add(panelContent);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbRodzajPracownika;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtPesel;
        private TextBox txtLogin;
        private TextBox txtHaslo;
        private Button btnZapisz;
        private Button btnAnuluj;
        private Label label1;
        private ComboBox cmbSpecjalnosc;

        private void txtHaslo_TextChanged(object sender, EventArgs e)
        {

        }
        private TextBox txtPWZ;
        private Panel panelContent;
        private Panel panelBackground;
    }



    }