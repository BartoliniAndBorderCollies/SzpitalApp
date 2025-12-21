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
            txtHaslo = new TextBox();
            btnZaloguj = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(335, 167);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(311, 39);
            txtLogin.TabIndex = 0;
            // 
            // txtHaslo
            // 
            txtHaslo.Location = new Point(335, 239);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.PlaceholderText = "Hasło";
            txtHaslo.Size = new Size(311, 39);
            txtHaslo.TabIndex = 1;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // btnZaloguj
            // 
            btnZaloguj.BackColor = SystemColors.InactiveCaption;
            btnZaloguj.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnZaloguj.Location = new Point(401, 325);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(150, 46);
            btnZaloguj.TabIndex = 2;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = false;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 4;
            label1.Text = "SzpitalApp by Bartłomiej Kłodnicki";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtHaslo);
            panel1.Controls.Add(btnZaloguj);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 631);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Warszawa_Centrum_Zdrowia_Dziecka;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 625);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 629);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtHaslo;
        private Button btnZaloguj;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
