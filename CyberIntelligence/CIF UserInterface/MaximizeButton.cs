using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Hub.DarkHubControls
{
    public partial class MaximizeButton : UserControl
    {
        public MaximizeButton()
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
        private void PicMaximize_Click(object sender, EventArgs e)
        {
            if(((Form)this.Parent.Parent).WindowState == FormWindowState.Normal)
                ((Form)this.Parent.Parent).WindowState = FormWindowState.Maximized;
            else
                ((Form)this.Parent.Parent).WindowState = FormWindowState.Normal;

        }

        private void PicMaximize_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = hover;

        }

        private void PicMaximize_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;


        }
    }
}
