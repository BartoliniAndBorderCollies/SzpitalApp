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
            bottomPanel = new Panel();
            upperPanel = new Panel();
            mainGridPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).BeginInit();
            bottomPanel.SuspendLayout();
            mainGridPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            dataGridViewPracownicy.AllowUserToAddRows = false;
            dataGridViewPracownicy.AllowUserToDeleteRows = false;
            dataGridViewPracownicy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            btnEdytuj.Click += btnEdytuj_Click;
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
            // bottomPanel
            // 
            bottomPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bottomPanel.BackgroundImage = Properties.Resources.bottom2;
            bottomPanel.Controls.Add(btnEdytuj);
            bottomPanel.Controls.Add(btnAnuluj);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(50, 904);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(2178, 194);
            bottomPanel.TabIndex = 3;
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
            // mainGridPanel
            // 
            mainGridPanel.BackColor = SystemColors.ActiveCaptionText;
            mainGridPanel.Controls.Add(dataGridViewPracownicy);
            mainGridPanel.Controls.Add(bottomPanel);
            mainGridPanel.Controls.Add(upperPanel);
            mainGridPanel.Dock = DockStyle.Fill;
            mainGridPanel.Location = new Point(0, 0);
            mainGridPanel.Name = "mainGridPanel";
            mainGridPanel.Padding = new Padding(50);
            mainGridPanel.Size = new Size(2278, 1148);
            mainGridPanel.TabIndex = 5;
            // 
            // ListaPracownikowForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(mainGridPanel);
            Name = "ListaPracownikowForm";
            Text = "ListaPracownikowForm";
            Load += ListaPracownikowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).EndInit();
            bottomPanel.ResumeLayout(false);
            mainGridPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPracownicy;
        private Button btnEdytuj;
        private Button btnAnuluj;
        private Panel bottomPanel;
        private Panel upperPanel;
        private Panel mainGridPanel;
    }
}