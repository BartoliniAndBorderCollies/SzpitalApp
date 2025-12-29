namespace SzpitalApp
{
    partial class AddDyzurForm
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
            mthCalendar = new MonthCalendar();
            lblText = new Label();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // mthCalendar
            // 
            mthCalendar.Location = new Point(132, 59);
            mthCalendar.Name = "mthCalendar";
            mthCalendar.TabIndex = 0;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(252, 18);
            lblText.Name = "lblText";
            lblText.Size = new Size(245, 32);
            lblText.TabIndex = 1;
            lblText.Text = "Wybierz dzień dyżuru";
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = SystemColors.GrayText;
            btnZapisz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZapisz.ForeColor = SystemColors.ButtonHighlight;
            btnZapisz.Location = new Point(158, 388);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(150, 46);
            btnZapisz.TabIndex = 2;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(447, 388);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(150, 46);
            btnAnuluj.TabIndex = 3;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // AddDyzurForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(lblText);
            Controls.Add(mthCalendar);
            Name = "AddDyzurForm";
            Text = "AddDyzurForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mthCalendar;
        private Label lblText;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}