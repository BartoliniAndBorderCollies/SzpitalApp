namespace SzpitalApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            textHaslo = new TextBox();
            btnZaloguj = new Button();
            TłoSzpital = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TłoSzpital).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(265, 111);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(311, 39);
            txtLogin.TabIndex = 0;
            // 
            // textHaslo
            // 
            textHaslo.Location = new Point(265, 203);
            textHaslo.Name = "textHaslo";
            textHaslo.PlaceholderText = "Hasło";
            textHaslo.Size = new Size(311, 39);
            textHaslo.TabIndex = 1;
            textHaslo.UseSystemPasswordChar = true;
            // 
            // btnZaloguj
            // 
            btnZaloguj.BackColor = SystemColors.InactiveCaption;
            btnZaloguj.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnZaloguj.Location = new Point(327, 282);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(150, 46);
            btnZaloguj.TabIndex = 2;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = false;
            // 
            // TłoSzpital
            // 
            TłoSzpital.Dock = DockStyle.Fill;
            TłoSzpital.Image = Properties.Resources.Warszawa_Centrum_Zdrowia_Dziecka;
            TłoSzpital.Location = new Point(0, 0);
            TłoSzpital.Name = "TłoSzpital";
            TłoSzpital.Size = new Size(800, 450);
            TłoSzpital.TabIndex = 3;
            TłoSzpital.TabStop = false;
            TłoSzpital.Click += TłoSzpital_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 4;
            label1.Text = "SzpitalApp by Bartłomiej Kłodnicki";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnZaloguj);
            Controls.Add(textHaslo);
            Controls.Add(txtLogin);
            Controls.Add(TłoSzpital);
            Name = "LoginForm";
            Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)TłoSzpital).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox textHaslo;
        private Button btnZaloguj;
        private PictureBox TłoSzpital;
        private Label label1;
    }
}
