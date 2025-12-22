namespace SzpitalApp
{
    partial class RemoveEmployeeForm
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
            lblUsuwaniePracownika = new Label();
            txtPodajPesel = new TextBox();
            btnUsun = new Button();
            btnAnuluj = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsuwaniePracownika
            // 
            lblUsuwaniePracownika.AutoSize = true;
            lblUsuwaniePracownika.Location = new Point(248, 32);
            lblUsuwaniePracownika.Name = "lblUsuwaniePracownika";
            lblUsuwaniePracownika.Size = new Size(243, 32);
            lblUsuwaniePracownika.TabIndex = 0;
            lblUsuwaniePracownika.Text = "Usuwanie pracownika";
            // 
            // txtPodajPesel
            // 
            txtPodajPesel.Location = new Point(161, 168);
            txtPodajPesel.Name = "txtPodajPesel";
            txtPodajPesel.PlaceholderText = "PESEL";
            txtPodajPesel.Size = new Size(457, 39);
            txtPodajPesel.TabIndex = 1;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.Firebrick;
            btnUsun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsun.ForeColor = SystemColors.ButtonHighlight;
            btnUsun.Location = new Point(170, 302);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(150, 46);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(419, 302);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(150, 46);
            btnAnuluj.TabIndex = 3;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 122);
            label1.Name = "label1";
            label1.Size = new Size(409, 32);
            label1.TabIndex = 4;
            label1.Text = "Podaj PESEL pracownika do usunięcia";
            // 
            // RemoveEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAnuluj);
            Controls.Add(btnUsun);
            Controls.Add(txtPodajPesel);
            Controls.Add(lblUsuwaniePracownika);
            Name = "RemoveEmployeeForm";
            Text = "RemoveEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuwaniePracownika;
        private TextBox txtPodajPesel;
        private Button btnUsun;
        private Button btnAnuluj;
        private Label label1;
    }
}