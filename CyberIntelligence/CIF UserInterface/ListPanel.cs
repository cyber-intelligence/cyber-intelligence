using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIF_UserInterface
{
    public class ListPanel : FlowLayoutPanel
    {
        public ListPanel() : base()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(30, 30, 30);
            TabStop = false;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down) return true;
            if (keyData == Keys.Left || keyData == Keys.Right) return true;
            return base.IsInputKey(keyData);
        }
        protected override void OnEnter(EventArgs e)
        {
            Invalidate();
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            Invalidate();
            base.OnLeave(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
