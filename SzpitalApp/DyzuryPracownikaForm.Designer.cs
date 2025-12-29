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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDyzury).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDyzury
            // 
            dataGridViewDyzury.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDyzury.Dock = DockStyle.Bottom;
            dataGridViewDyzury.Location = new Point(0, 59);
            dataGridViewDyzury.Name = "dataGridViewDyzury";
            dataGridViewDyzury.RowHeadersWidth = 82;
            dataGridViewDyzury.Size = new Size(800, 391);
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
            // DyzuryPracownikaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
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
    }
}