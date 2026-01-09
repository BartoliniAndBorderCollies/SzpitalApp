namespace SzpitalApp
{
    partial class UsunPracownikaForm
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
            txtPodajPesel = new TextBox();
            btnUsun = new Button();
            btnAnuluj = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPodajPesel
            // 
            txtPodajPesel.Location = new Point(160, 185);
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
            btnUsun.Location = new Point(160, 288);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(150, 46);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(429, 288);
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
            label1.Location = new Point(170, 91);
            label1.Name = "label1";
            label1.Size = new Size(409, 32);
            label1.TabIndex = 4;
            label1.Text = "Podaj PESEL pracownika do usunięcia";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(txtPodajPesel);
            panel1.Controls.Add(btnUsun);
            panel1.Controls.Add(btnAnuluj);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 457);
            panel1.TabIndex = 5;
            // 
            // RemoveEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 457);
            Controls.Add(panel1);
            Name = "RemoveEmployeeForm";
            Text = "Usuwanie pracownika";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPodajPesel;
        private Button btnUsun;
        private Button btnAnuluj;
        private Label label1;
        private Panel panel1;
    }
}