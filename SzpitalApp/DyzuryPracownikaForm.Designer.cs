namespace SzpitalApp
{
    partial class DyzuryPracownikaForm
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
            dataGridViewDyzury = new DataGridView();
            lblPracownik = new Label();
            btnDodaj = new Button();
            btnUsun = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDyzury).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDyzury
            // 
            dataGridViewDyzury.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDyzury.Location = new Point(0, 65);
            dataGridViewDyzury.Name = "dataGridViewDyzury";
            dataGridViewDyzury.RowHeadersWidth = 82;
            dataGridViewDyzury.Size = new Size(576, 385);
            dataGridViewDyzury.TabIndex = 0;
            // 
            // lblPracownik
            // 
            lblPracownik.AutoSize = true;
            lblPracownik.BackColor = SystemColors.GrayText;
            lblPracownik.Dock = DockStyle.Top;
            lblPracownik.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPracownik.ForeColor = SystemColors.ButtonHighlight;
            lblPracownik.Location = new Point(0, 0);
            lblPracownik.Name = "lblPracownik";
            lblPracownik.Size = new Size(83, 32);
            lblPracownik.TabIndex = 1;
            lblPracownik.Text = "label1";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.GrayText;
            btnDodaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodaj.ForeColor = SystemColors.ButtonHighlight;
            btnDodaj.Location = new Point(626, 126);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(150, 82);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = SystemColors.GrayText;
            btnUsun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsun.ForeColor = SystemColors.ButtonHighlight;
            btnUsun.Location = new Point(626, 262);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(150, 82);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = false;
            // 
            // DyzuryPracownikaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(lblPracownik);
            Controls.Add(dataGridViewDyzury);
            Name = "DyzuryPracownikaForm";
            Text = "DyzuryPracownikaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDyzury).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDyzury;
        private Label lblPracownik;
        private Button btnDodaj;
        private Button btnUsun;
    }
}