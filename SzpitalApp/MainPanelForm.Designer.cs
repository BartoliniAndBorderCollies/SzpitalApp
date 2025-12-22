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
            panelContent = new Panel();
            btnExitProgram = new Button();
            btnUsunPracownika = new Button();
            btnDodajPracownika = new Button();
            btnListaPracownikow = new Button();
            panelBackground = new Panel();
            blackPanel = new Panel();
            panelContent.SuspendLayout();
            blackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.BackgroundImageLayout = ImageLayout.None;
            panelContent.Controls.Add(btnExitProgram);
            panelContent.Controls.Add(btnUsunPracownika);
            panelContent.Controls.Add(btnDodajPracownika);
            panelContent.Controls.Add(btnListaPracownikow);
            panelContent.Dock = DockStyle.Left;
            panelContent.Location = new Point(50, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(300, 1048);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
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
            // btnUsunPracownika
            // 
            btnUsunPracownika.Location = new Point(22, 312);
            btnUsunPracownika.Name = "btnUsunPracownika";
            btnUsunPracownika.Size = new Size(257, 160);
            btnUsunPracownika.TabIndex = 3;
            btnUsunPracownika.Text = "Usuń pracownika";
            btnUsunPracownika.UseVisualStyleBackColor = true;
            btnUsunPracownika.Click += btnUsunPracownika_Click;
            // 
            // btnDodajPracownika
            // 
            btnDodajPracownika.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnDodajPracownika.Location = new Point(22, 75);
            btnDodajPracownika.Name = "btnDodajPracownika";
            btnDodajPracownika.Size = new Size(257, 181);
            btnDodajPracownika.TabIndex = 1;
            btnDodajPracownika.Text = "Dodaj pracownika";
            btnDodajPracownika.UseVisualStyleBackColor = true;
            btnDodajPracownika.Click += btnDodajPracownika_Click;
            // 
            // btnListaPracownikow
            // 
            btnListaPracownikow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnListaPracownikow.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnListaPracownikow.Location = new Point(22, 538);
            btnListaPracownikow.Name = "btnListaPracownikow";
            btnListaPracownikow.Size = new Size(257, 170);
            btnListaPracownikow.TabIndex = 0;
            btnListaPracownikow.Text = "Lista pracowników i ich edycja";
            btnListaPracownikow.UseVisualStyleBackColor = true;
            btnListaPracownikow.Click += btnListaPracownikow_Click;
            // 
            // panelBackground
            // 
            panelBackground.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBackground.BackgroundImage = Properties.Resources.to4;
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
            blackPanel.Controls.Add(panelBackground);
            blackPanel.Controls.Add(panelContent);
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
            Text = "AdminPanel";
            panelContent.ResumeLayout(false);
            blackPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContent;
        private Button btnUsunPracownika;
        private Button btnDodajPracownika;
        private Button btnListaPracownikow;
        private Panel panelBackground;
        private Button btnExitProgram;
        private Panel blackPanel;
    }
}