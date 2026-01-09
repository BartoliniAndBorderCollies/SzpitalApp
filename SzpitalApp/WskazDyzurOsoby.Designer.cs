namespace SzpitalApp
{
    partial class WskazDyzurOsoby
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
            label1 = new Label();
            label2 = new Label();
            txtBxNazwisko = new TextBox();
            btnZobacz = new Button();
            lblImie = new Label();
            txtBxImie = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 22);
            label1.Name = "label1";
            label1.Size = new Size(387, 32);
            label1.TabIndex = 0;
            label1.Text = "Wyświetlanie dyżurów danej osoby";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 91);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj nazwisko:";
            // 
            // txtBxNazwisko
            // 
            txtBxNazwisko.Location = new Point(212, 140);
            txtBxNazwisko.Name = "txtBxNazwisko";
            txtBxNazwisko.PlaceholderText = "Nazwisko";
            txtBxNazwisko.Size = new Size(330, 39);
            txtBxNazwisko.TabIndex = 2;
            // 
            // btnZobacz
            // 
            btnZobacz.BackColor = SystemColors.GrayText;
            btnZobacz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZobacz.ForeColor = SystemColors.ButtonFace;
            btnZobacz.Location = new Point(126, 359);
            btnZobacz.Name = "btnZobacz";
            btnZobacz.Size = new Size(150, 46);
            btnZobacz.TabIndex = 3;
            btnZobacz.Text = "Zobacz dyżury";
            btnZobacz.UseVisualStyleBackColor = false;
            btnZobacz.Click += btnZobacz_Click_1;
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(292, 212);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(130, 32);
            lblImie.TabIndex = 4;
            lblImie.Text = "Podaj imię:";
            // 
            // txtBxImie
            // 
            txtBxImie.Location = new Point(252, 274);
            txtBxImie.Name = "txtBxImie";
            txtBxImie.PlaceholderText = "Imię";
            txtBxImie.Size = new Size(237, 39);
            txtBxImie.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(420, 359);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WskazDyzurOsoby
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBxImie);
            Controls.Add(lblImie);
            Controls.Add(btnZobacz);
            Controls.Add(txtBxNazwisko);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WskazDyzurOsoby";
            Text = "WskazDyzurOsoby";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxNazwisko;
        private Button btnZobacz;
        private Label lblImie;
        private TextBox txtBxImie;
        private Button button1;
    }
}