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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            dataGridViewPracownicy.AllowUserToAddRows = false;
            dataGridViewPracownicy.AllowUserToDeleteRows = false;
            dataGridViewPracownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPracownicy.Location = new Point(7, 3);
            dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            dataGridViewPracownicy.ReadOnly = true;
            dataGridViewPracownicy.RowHeadersWidth = 82;
            dataGridViewPracownicy.Size = new Size(781, 329);
            dataGridViewPracownicy.TabIndex = 0;
            // 
            // btnEdytuj
            // 
            btnEdytuj.BackColor = SystemColors.HotTrack;
            btnEdytuj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEdytuj.ForeColor = SystemColors.ButtonHighlight;
            btnEdytuj.Location = new Point(117, 357);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(150, 46);
            btnEdytuj.TabIndex = 1;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = false;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(479, 357);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(150, 46);
            btnAnuluj.TabIndex = 2;
            btnAnuluj.Text = "Zamknij";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // ListaPracownikowForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnuluj);
            Controls.Add(btnEdytuj);
            Controls.Add(dataGridViewPracownicy);
            Name = "ListaPracownikowForm";
            Text = "ListaPracownikowForm";
            Load += ListaPracownikowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPracownicy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPracownicy;
        private Button btnEdytuj;
        private Button btnAnuluj;
    }
}