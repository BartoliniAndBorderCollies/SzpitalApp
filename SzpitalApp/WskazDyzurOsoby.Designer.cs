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
            btnZobacz = new Button();
            button1 = new Button();
            comboBoxPracownik = new ComboBox();
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
            label2.Size = new Size(227, 32);
            label2.TabIndex = 1;
            label2.Text = "Wybierz pracownika";
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
            // comboBoxPracownik
            // 
            comboBoxPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPracownik.FormattingEnabled = true;
            comboBoxPracownik.Location = new Point(87, 182);
            comboBoxPracownik.Name = "comboBoxPracownik";
            comboBoxPracownik.Size = new Size(611, 40);
            comboBoxPracownik.TabIndex = 7;
            comboBoxPracownik.SelectedIndexChanged += comboBoxPracownik_SelectedIndexChanged;
            // 
            // WskazDyzurOsoby
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxPracownik);
            Controls.Add(button1);
            Controls.Add(btnZobacz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WskazDyzurOsoby";
            Text = "Dyzury osoby";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnZobacz;
        private Button button1;
        private ComboBox comboBoxPracownik;
    }
}