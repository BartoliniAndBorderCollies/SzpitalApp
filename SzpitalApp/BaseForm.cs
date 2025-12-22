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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            var ekran = Screen.PrimaryScreen.WorkingArea;

            this.Size = new Size(
                (int)(ekran.Width * 0.8),
                (int)(ekran.Height * 0.8)
            );

            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(
                (int)(ekran.Width * 0.8),
                (int)(ekran.Height * 0.8)
            );

            this.Location = new Point(
            (ekran.Width - this.Width) / 2,
            (ekran.Height - this.Height) / 2
);
        }

    }
}
