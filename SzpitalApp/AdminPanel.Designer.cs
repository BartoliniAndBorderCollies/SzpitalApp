namespace SzpitalApp
{
    partial class AdminPanel
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
            panelAdmina = new Panel();
            panelContent = new Panel();
            lstPracownicy = new ListBox();
            btnDodajPracownika = new Button();
            btnListaPracownikow = new Button();
            btnUsunPracownika = new Button();
            panelAdmina.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdmina
            // 
            panelAdmina.BackgroundImage = Properties.Resources.Da_Vinci_Vitruve_Luc_Viatour1;
            panelAdmina.Controls.Add(panelContent);
            panelAdmina.Dock = DockStyle.Fill;
            panelAdmina.Location = new Point(0, 0);
            panelAdmina.Name = "panelAdmina";
            panelAdmina.Size = new Size(800, 450);
            panelAdmina.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.None;
            panelContent.Controls.Add(btnUsunPracownika);
            panelContent.Controls.Add(lstPracownicy);
            panelContent.Controls.Add(btnDodajPracownika);
            panelContent.Controls.Add(btnListaPracownikow);
            panelContent.Location = new Point(74, 31);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(646, 383);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // lstPracownicy
            // 
            lstPracownicy.Anchor = AnchorStyles.None;
            lstPracownicy.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lstPracownicy.FormattingEnabled = true;
            lstPracownicy.Location = new Point(270, 74);
            lstPracownicy.Name = "lstPracownicy";
            lstPracownicy.Size = new Size(363, 124);
            lstPracownicy.TabIndex = 2;
            // 
            // btnDodajPracownika
            // 
            btnDodajPracownika.Anchor = AnchorStyles.None;
            btnDodajPracownika.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnDodajPracownika.Location = new Point(59, 198);
            btnDodajPracownika.Name = "btnDodajPracownika";
            btnDodajPracownika.Size = new Size(164, 75);
            btnDodajPracownika.TabIndex = 1;
            btnDodajPracownika.Text = "Dodaj pracownika";
            btnDodajPracownika.UseVisualStyleBackColor = true;
            btnDodajPracownika.Click += btnDodajPracownika_Click;
            // 
            // btnListaPracownikow
            // 
            btnListaPracownikow.Anchor = AnchorStyles.None;
            btnListaPracownikow.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnListaPracownikow.Location = new Point(59, 74);
            btnListaPracownikow.Name = "btnListaPracownikow";
            btnListaPracownikow.Size = new Size(164, 80);
            btnListaPracownikow.TabIndex = 0;
            btnListaPracownikow.Text = "Lista pracowników";
            btnListaPracownikow.UseVisualStyleBackColor = true;
            btnListaPracownikow.Click += btnListaPracownikow_Click;
            // 
            // btnUsunPracownika
            // 
            btnUsunPracownika.Location = new Point(59, 296);
            btnUsunPracownika.Name = "btnUsunPracownika";
            btnUsunPracownika.Size = new Size(164, 73);
            btnUsunPracownika.TabIndex = 3;
            btnUsunPracownika.Text = "Usuń pracownika";
            btnUsunPracownika.UseVisualStyleBackColor = true;
            btnUsunPracownika.Click += btnUsunPracownika_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAdmina);
            Name = "AdminPanel";
            Text = "AdminPanel";
            panelAdmina.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdmina;
        private Panel panelContent;
        private Button btnListaPracownikow;
        private Button btnDodajPracownika;
        private ListBox lstPracownicy;
        private Button btnUsunPracownika;
    }
}