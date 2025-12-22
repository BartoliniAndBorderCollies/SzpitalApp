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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            dataGridViewPracownicy.AllowUserToAddRows = false;
            dataGridViewPracownicy.AllowUserToDeleteRows = false;
            dataGridViewPracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPracownicy.Dock = DockStyle.Fill;
            dataGridViewPracownicy.Location = new Point(0, 0);
            dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            dataGridViewPracownicy.ReadOnly = true;
            dataGridViewPracownicy.RowHeadersWidth = 82;
            dataGridViewPracownicy.Size = new Size(2278, 1148);
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
            panelContent.BackgroundImage = Properties.Resources.bottom;
            panelContent.Controls.Add(btnEdytuj);
            panelContent.Controls.Add(btnAnuluj);
            panelContent.Dock = DockStyle.Bottom;
            panelContent.Location = new Point(0, 954);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(2278, 194);
            panelContent.TabIndex = 3;
            // 
            // upperPanel
            // 
            upperPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            upperPanel.BackgroundImage = Properties.Resources.Da_Vinci_Vitruve_Luc_Viatour;
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(2278, 238);
            upperPanel.TabIndex = 4;
            // 
            // ListaPracownikowForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1148);
            Controls.Add(upperPanel);
            Controls.Add(panelContent);
            Controls.Add(dataGridViewPracownicy);
            Name = "ListaPracownikowForm";
            Text = "ListaPracownikowForm";
            Load += ListaPracownikowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).EndInit();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPracownicy;
        private Button btnEdytuj;
        private Button btnAnuluj;
        private Panel panelContent;
        private Panel upperPanel;
    }
}