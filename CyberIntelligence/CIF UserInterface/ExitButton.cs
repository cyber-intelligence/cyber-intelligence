using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dark_Hub.DarkHubControls
{
    public partial class ExitButton : UserControl
    {
        public ExitButton()
        {
            InitializeComponent();
        }

        Color hover = Color.FromArgb(18, 18, 18);
        [Description("Background Color When Mouse Enter"), Category("Appearance")]
        public Color HoverColor
        {
            get
            {
                return hover;
            }
            set
            {
                hover = value;
            }
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = hover;

        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = this.BackColor;

        }
    }
}
