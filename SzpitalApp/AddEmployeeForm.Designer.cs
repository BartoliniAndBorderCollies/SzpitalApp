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
            SuspendLayout();
            // 
            // cmbRodzajPracownika
            // 
            cmbRodzajPracownika.FormattingEnabled = true;
            cmbRodzajPracownika.Items.AddRange(new object[] { "Lekarz", "Pielęgniarka" });
            cmbRodzajPracownika.Location = new Point(53, 73);
            cmbRodzajPracownika.Name = "cmbRodzajPracownika";
            cmbRodzajPracownika.Size = new Size(331, 40);
            cmbRodzajPracownika.TabIndex = 0;
            cmbRodzajPracownika.Text = "Wybierz rodzaj pracownika";
            cmbRodzajPracownika.SelectedIndexChanged += cmbRodzajPracownika_SelectedIndexChanged;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(53, 134);
            txtImie.Name = "txtImie";
            txtImie.PlaceholderText = "Imię";
            txtImie.Size = new Size(200, 39);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(53, 196);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.PlaceholderText = "Nazwisko";
            txtNazwisko.Size = new Size(200, 39);
            txtNazwisko.TabIndex = 2;
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(513, 74);
            txtPesel.Name = "txtPesel";
            txtPesel.PlaceholderText = "Pesel";
            txtPesel.Size = new Size(200, 39);
            txtPesel.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(513, 134);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(200, 39);
            txtLogin.TabIndex = 4;
            // 
            // txtHaslo
            // 
            txtHaslo.Location = new Point(513, 196);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.PlaceholderText = "Hasło";
            txtHaslo.Size = new Size(200, 39);
            txtHaslo.TabIndex = 5;
            txtHaslo.UseSystemPasswordChar = true;
            txtHaslo.TextChanged += txtHaslo_TextChanged;
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = SystemColors.GradientActiveCaption;
            btnZapisz.Location = new Point(103, 371);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(150, 46);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(513, 371);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(150, 46);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 8;
            label1.Text = "Dodawanie pracownika";
            // 
            // cmbSpecjalnosc
            // 
            cmbSpecjalnosc.FormattingEnabled = true;
            cmbSpecjalnosc.Items.AddRange(new object[] { "Kardiolog", "Neurolog", "Laryngolog" });
            cmbSpecjalnosc.Location = new Point(53, 259);
            cmbSpecjalnosc.Name = "cmbSpecjalnosc";
            cmbSpecjalnosc.Size = new Size(242, 40);
            cmbSpecjalnosc.TabIndex = 9;
            cmbSpecjalnosc.Text = "Specjalność";
            cmbSpecjalnosc.Visible = false;
            // 
            // txtPWZ
            // 
            txtPWZ.Location = new Point(513, 259);
            txtPWZ.Name = "txtPWZ";
            txtPWZ.PlaceholderText = "PWZ";
            txtPWZ.Size = new Size(200, 39);
            txtPWZ.TabIndex = 10;
            txtPWZ.Visible = false;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPWZ);
            Controls.Add(cmbSpecjalnosc);
            Controls.Add(label1);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(txtHaslo);
            Controls.Add(txtLogin);
            Controls.Add(txtPesel);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(cmbRodzajPracownika);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
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
    }



    }