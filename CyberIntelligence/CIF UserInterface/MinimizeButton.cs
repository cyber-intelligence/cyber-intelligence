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
    public partial class MinimizeButton : UserControl
    {
        public MinimizeButton()
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
        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = hover;

        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;

        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Form Parent = GetParent(this);
            Parent.WindowState = FormWindowState.Minimized;
        }
        private Form GetParent(Control child)
        {
            Control parent = child.Parent;
            if (parent != null)
            {
                if (parent is Form)
                {
                    return (Form)parent;
                }
                else
                {
                    return GetParent(parent);
                }
            }
            return null;
        }
    }
}
