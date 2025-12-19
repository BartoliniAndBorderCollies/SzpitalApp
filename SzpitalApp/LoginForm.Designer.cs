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
            btnZaloguj.BackColor = SystemColors.GradientActiveCaption;
            btnZaloguj.Location = new Point(327, 282);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(150, 46);
            btnZaloguj.TabIndex = 2;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZaloguj);
            Controls.Add(textHaslo);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox textHaslo;
        private Button btnZaloguj;
    }
}
