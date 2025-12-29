using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzpitalApp
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 600);
            this.MaximizeBox = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            var ekran = Screen.PrimaryScreen.WorkingArea;

            Size = new Size(
                (int)(ekran.Width * 0.8),
                (int)(ekran.Height * 0.8)
            );
        }
    }

}
