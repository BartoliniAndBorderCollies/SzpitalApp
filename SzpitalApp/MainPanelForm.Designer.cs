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
            btnUsunPracownika = new Button();
            btnDodajPracownika = new Button();
            btnListaPracownikow = new Button();
            panelBackground = new Panel();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.BackgroundImageLayout = ImageLayout.None;
            panelContent.Controls.Add(btnUsunPracownika);
            panelContent.Controls.Add(btnDodajPracownika);
            panelContent.Controls.Add(btnListaPracownikow);
            panelContent.Dock = DockStyle.Left;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(300, 1148);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // btnUsunPracownika
            // 
            btnUsunPracownika.Location = new Point(22, 344);
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
            btnDodajPracownika.Location = new Point(22, 101);
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
            btnListaPracownikow.Location = new Point(22, 578);
            btnListaPracownikow.Name = "btnListaPracownikow";
            btnListaPracownikow.Size = new Size(257, 170);
            btnListaPracownikow.TabIndex = 0;
            btnListaPracownikow.Text = "Lista pracowników i ich edycja";
            btnListaPracownikow.UseVisualStyleBackColor = true;
            btnListaPracownikow.Click += btnListaPracownikow_Click;
            // 
            // panelBackground
            // 
            panelBackground.BackgroundImage = Properties.Resources.to4;
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(2278, 1148);
            panelBackground.TabIndex = 1;
            // 
            // MainPanelForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(panelContent);
            Controls.Add(panelBackground);
            MaximumSize = new Size(2304, 1219);
            Name = "MainPanelForm";
            Text = "AdminPanel";
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Button btnUsunPracownika;
        private Button btnDodajPracownika;
        private Button btnListaPracownikow;
        private Panel panelBackground;
    }
}