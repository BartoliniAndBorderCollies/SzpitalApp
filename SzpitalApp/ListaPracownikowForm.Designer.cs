namespace SzpitalApp
{
    partial class ListaPracownikowForm
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
            dataGridViewPracownicy = new DataGridView();
            btnEdytuj = new Button();
            btnAnuluj = new Button();
            panelContent = new Panel();
            upperPanel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).BeginInit();
            panelContent.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            dataGridViewPracownicy.AllowUserToAddRows = false;
            dataGridViewPracownicy.AllowUserToDeleteRows = false;
            dataGridViewPracownicy.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPracownicy.Dock = DockStyle.Fill;
            dataGridViewPracownicy.Location = new Point(50, 288);
            dataGridViewPracownicy.Margin = new Padding(30, 3, 3, 3);
            dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            dataGridViewPracownicy.ReadOnly = true;
            dataGridViewPracownicy.RowHeadersWidth = 82;
            dataGridViewPracownicy.Size = new Size(2178, 616);
            dataGridViewPracownicy.TabIndex = 0;
            // 
            // btnEdytuj
            // 
            btnEdytuj.BackColor = SystemColors.HotTrack;
            btnEdytuj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEdytuj.ForeColor = SystemColors.ButtonHighlight;
            btnEdytuj.Location = new Point(524, 48);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(204, 85);
            btnEdytuj.TabIndex = 1;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = false;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(1488, 48);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(215, 85);
            btnAnuluj.TabIndex = 2;
            btnAnuluj.Text = "Zamknij";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // panelContent
            // 
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.BackgroundImage = Properties.Resources.bottom2;
            panelContent.Controls.Add(btnEdytuj);
            panelContent.Controls.Add(btnAnuluj);
            panelContent.Dock = DockStyle.Bottom;
            panelContent.Location = new Point(50, 904);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(2178, 194);
            panelContent.TabIndex = 3;
            // 
            // upperPanel
            // 
            upperPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            upperPanel.BackgroundImage = Properties.Resources.upper;
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(50, 50);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(2178, 238);
            upperPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(dataGridViewPracownicy);
            panel1.Controls.Add(panelContent);
            panel1.Controls.Add(upperPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50);
            panel1.Size = new Size(2278, 1148);
            panel1.TabIndex = 5;
            // 
            // ListaPracownikowForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(panel1);
            Name = "ListaPracownikowForm";
            Text = "ListaPracownikowForm";
            Load += ListaPracownikowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).EndInit();
            panelContent.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPracownicy;
        private Button btnEdytuj;
        private Button btnAnuluj;
        private Panel panelContent;
        private Panel upperPanel;
        private Panel panel1;
    }
}