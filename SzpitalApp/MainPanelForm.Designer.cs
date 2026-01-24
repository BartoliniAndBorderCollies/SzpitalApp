namespace SzpitalApp
{
    partial class MainPanelForm
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
            GeneralPanel = new Panel();
            btnExitProgram = new Button();
            panelPersonel = new Panel();
            btnPlanDyzurow = new Button();
            btnListaPersonelu = new Button();
            adminPanel = new Panel();
            btnHistoriaLogowan = new Button();
            btnUsunPracownika = new Button();
            btnListaPracownikow = new Button();
            btnDodajPracownika = new Button();
            panelBackground = new Panel();
            blackPanel = new Panel();
            GeneralPanel.SuspendLayout();
            panelPersonel.SuspendLayout();
            adminPanel.SuspendLayout();
            blackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GeneralPanel
            // 
            GeneralPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GeneralPanel.BackColor = Color.WhiteSmoke;
            GeneralPanel.BackgroundImageLayout = ImageLayout.None;
            GeneralPanel.Controls.Add(btnExitProgram);
            GeneralPanel.Controls.Add(panelPersonel);
            GeneralPanel.Controls.Add(adminPanel);
            GeneralPanel.Dock = DockStyle.Left;
            GeneralPanel.Location = new Point(50, 50);
            GeneralPanel.Name = "GeneralPanel";
            GeneralPanel.Size = new Size(300, 1048);
            GeneralPanel.TabIndex = 0;
            GeneralPanel.Paint += panelContent_Paint;
            // 
            // btnExitProgram
            // 
            btnExitProgram.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExitProgram.BackColor = Color.SaddleBrown;
            btnExitProgram.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnExitProgram.ForeColor = SystemColors.ButtonHighlight;
            btnExitProgram.Location = new Point(22, 842);
            btnExitProgram.Name = "btnExitProgram";
            btnExitProgram.Size = new Size(257, 188);
            btnExitProgram.TabIndex = 4;
            btnExitProgram.Text = "Zapisz i wyjdź z programu";
            btnExitProgram.UseVisualStyleBackColor = false;
            btnExitProgram.Click += btnExitProgram_Click;
            // 
            // panelPersonel
            // 
            panelPersonel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPersonel.Controls.Add(btnPlanDyzurow);
            panelPersonel.Controls.Add(btnListaPersonelu);
            panelPersonel.Location = new Point(0, 0);
            panelPersonel.Name = "panelPersonel";
            panelPersonel.Size = new Size(269, 583);
            panelPersonel.TabIndex = 0;
            // 
            // btnPlanDyzurow
            // 
            btnPlanDyzurow.BackColor = SystemColors.GrayText;
            btnPlanDyzurow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPlanDyzurow.ForeColor = SystemColors.ButtonHighlight;
            btnPlanDyzurow.Location = new Point(9, 382);
            btnPlanDyzurow.Name = "btnPlanDyzurow";
            btnPlanDyzurow.Size = new Size(257, 181);
            btnPlanDyzurow.TabIndex = 6;
            btnPlanDyzurow.Text = "Pokaż plan dyżurów danej osoby";
            btnPlanDyzurow.UseVisualStyleBackColor = false;
            btnPlanDyzurow.Click += btnPlanDyzurow_Click;
            // 
            // btnListaPersonelu
            // 
            btnListaPersonelu.BackColor = SystemColors.GrayText;
            btnListaPersonelu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnListaPersonelu.ForeColor = SystemColors.ButtonHighlight;
            btnListaPersonelu.Location = new Point(9, 83);
            btnListaPersonelu.Name = "btnListaPersonelu";
            btnListaPersonelu.Size = new Size(257, 181);
            btnListaPersonelu.TabIndex = 5;
            btnListaPersonelu.Text = "Wyświetl listę lekarzy i pielęgniarek";
            btnListaPersonelu.UseVisualStyleBackColor = false;
            btnListaPersonelu.Click += btnListaPersonelu_Click;
            // 
            // adminPanel
            // 
            adminPanel.BackColor = Color.WhiteSmoke;
            adminPanel.Controls.Add(btnHistoriaLogowan);
            adminPanel.Controls.Add(btnUsunPracownika);
            adminPanel.Controls.Add(btnListaPracownikow);
            adminPanel.Controls.Add(btnDodajPracownika);
            adminPanel.Location = new Point(0, 17);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(300, 800);
            adminPanel.TabIndex = 4;
            // 
            // btnHistoriaLogowan
            // 
            btnHistoriaLogowan.BackColor = SystemColors.GrayText;
            btnHistoriaLogowan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnHistoriaLogowan.ForeColor = SystemColors.ButtonHighlight;
            btnHistoriaLogowan.Location = new Point(22, 620);
            btnHistoriaLogowan.Name = "btnHistoriaLogowan";
            btnHistoriaLogowan.Size = new Size(257, 181);
            btnHistoriaLogowan.TabIndex = 0;
            btnHistoriaLogowan.Text = "Wyświetl historię logowań";
            btnHistoriaLogowan.UseVisualStyleBackColor = false;
            // 
            // btnUsunPracownika
            // 
            btnUsunPracownika.BackColor = SystemColors.GrayText;
            btnUsunPracownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsunPracownika.ForeColor = SystemColors.ButtonHighlight;
            btnUsunPracownika.Location = new Point(22, 203);
            btnUsunPracownika.Name = "btnUsunPracownika";
            btnUsunPracownika.Size = new Size(257, 181);
            btnUsunPracownika.TabIndex = 3;
            btnUsunPracownika.Text = "Usuń pracownika";
            btnUsunPracownika.UseVisualStyleBackColor = false;
            btnUsunPracownika.Click += btnUsunPracownika_Click;
            // 
            // btnListaPracownikow
            // 
            btnListaPracownikow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnListaPracownikow.BackColor = SystemColors.GrayText;
            btnListaPracownikow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnListaPracownikow.ForeColor = SystemColors.ButtonHighlight;
            btnListaPracownikow.Location = new Point(22, 414);
            btnListaPracownikow.Name = "btnListaPracownikow";
            btnListaPracownikow.Size = new Size(257, 181);
            btnListaPracownikow.TabIndex = 0;
            btnListaPracownikow.Text = "Lista pracowników   i ich edycja";
            btnListaPracownikow.UseVisualStyleBackColor = false;
            btnListaPracownikow.Click += btnListaPracownikow_Click;
            // 
            // btnDodajPracownika
            // 
            btnDodajPracownika.BackColor = SystemColors.GrayText;
            btnDodajPracownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajPracownika.ForeColor = SystemColors.ButtonHighlight;
            btnDodajPracownika.Location = new Point(23, 0);
            btnDodajPracownika.Name = "btnDodajPracownika";
            btnDodajPracownika.Size = new Size(257, 181);
            btnDodajPracownika.TabIndex = 1;
            btnDodajPracownika.Text = "Dodaj pracownika";
            btnDodajPracownika.UseVisualStyleBackColor = false;
            btnDodajPracownika.Click += btnDodajPracownika_Click;
            // 
            // panelBackground
            // 
            panelBackground.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBackground.BackgroundImage = Properties.Resources.Da_Vinci_Vitruve_Luc_Viatour1;
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(350, 50);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1878, 1048);
            panelBackground.TabIndex = 1;
            // 
            // blackPanel
            // 
            blackPanel.AutoSize = true;
            blackPanel.BackColor = SystemColors.ActiveCaptionText;
            blackPanel.BackgroundImageLayout = ImageLayout.None;
            blackPanel.Controls.Add(panelBackground);
            blackPanel.Controls.Add(GeneralPanel);
            blackPanel.Dock = DockStyle.Fill;
            blackPanel.Location = new Point(0, 0);
            blackPanel.Name = "blackPanel";
            blackPanel.Padding = new Padding(50);
            blackPanel.Size = new Size(2278, 1148);
            blackPanel.TabIndex = 0;
            // 
            // MainPanelForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(blackPanel);
            MaximumSize = new Size(2304, 1219);
            Name = "MainPanelForm";
            Text = "Panel główny";
            GeneralPanel.ResumeLayout(false);
            panelPersonel.ResumeLayout(false);
            adminPanel.ResumeLayout(false);
            blackPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel GeneralPanel;
        private Button btnUsunPracownika;
        private Button btnDodajPracownika;
        private Button btnListaPracownikow;
        private Panel panelBackground;
        private Button btnExitProgram;
        private Panel blackPanel;
        private Button btnListaPersonelu;
        private Panel panelPersonel;
        private Button btnPlanDyzurow;
        private Panel adminPanel;
        private Button btnHistoriaLogowan;
    }
}