namespace SzpitalApp
{
    partial class HistoriaLogowanForm
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
            dataGridViewHistoriaLogowan = new DataGridView();
            btnEksport = new Button();
            btnZamknij = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoriaLogowan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoriaLogowan
            // 
            dataGridViewHistoriaLogowan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistoriaLogowan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoriaLogowan.Location = new Point(0, 0);
            dataGridViewHistoriaLogowan.Name = "dataGridViewHistoriaLogowan";
            dataGridViewHistoriaLogowan.RowHeadersWidth = 82;
            dataGridViewHistoriaLogowan.Size = new Size(800, 333);
            dataGridViewHistoriaLogowan.TabIndex = 0;
            // 
            // btnEksport
            // 
            btnEksport.BackColor = SystemColors.GrayText;
            btnEksport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEksport.ForeColor = SystemColors.ButtonHighlight;
            btnEksport.Location = new Point(160, 372);
            btnEksport.Name = "btnEksport";
            btnEksport.Size = new Size(150, 46);
            btnEksport.TabIndex = 1;
            btnEksport.Text = "Eksportuj";
            btnEksport.UseVisualStyleBackColor = false;
            btnEksport.Click += button1_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Location = new Point(488, 372);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(150, 46);
            btnZamknij.TabIndex = 2;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += button2_Click;
            // 
            // HistoriaLogowanForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZamknij);
            Controls.Add(btnEksport);
            Controls.Add(dataGridViewHistoriaLogowan);
            Name = "HistoriaLogowanForm";
            Text = "Historia logowań";
            Load += HistoriaLogowanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoriaLogowan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistoriaLogowan;
        private Button btnEksport;
        private Button btnZamknij;
    }
}