using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CIF_UserInterface
{
    public partial class TaskbarApp : UserControl
    {
        #region Variables

        #endregion

        #region CTor
        public TaskbarApp()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events

        #region HoverEvents

        #region Hover
        bool mouseIn;
        private void TaskbarAppHover(object sender, EventArgs e)
        {
            mouseIn = true;
            Thread.Sleep(10);
            if (active)
                BackColor = Color.FromArgb(32, 32, 32);
            else
                BackColor = Color.FromArgb(14, 14, 14);
            BottomLine.Size = new Size(BottomLine.Size.Width + 4, BottomLine.Height);
            BottomLine.Left -= 2;
        }
        #endregion

        #region UnHover
        private void TaskbarAppUnHover(object sender, EventArgs e)
        {
            mouseIn = false;

            if (active)
                BackColor = Color.FromArgb(26, 26, 26);
            else
                BackColor = Color.FromArgb(20, 20, 20);
            BottomLine.Size = new Size(BottomLine.Size.Width - 4, BottomLine.Height);
            BottomLine.Left += 2;
        }
        #endregion

        #endregion

        #endregion

        #region Functions

        #region CustomEvents
        public new event EventHandler OnClick;
        public void LocalEventHandler(object sender, EventArgs e) => OnClick?.Invoke(this, e);
        #endregion

        #endregion

        #region Properties

        #region Icon
        public Image icon
        {
            get => iconBox.Image;
            set => iconBox.Image = value;
        }
        #endregion

        #region active
        private bool _active;
        public bool active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
                if (_active)
                {
                    BottomLine.BackColor = Color.FromArgb(32, 102, 148);
                    if (mouseIn)
                    {
                        BackColor = Color.FromArgb(32, 32, 32);
                        return;
                    }
                    BackColor = Color.FromArgb(26, 26, 26);
                }
                else
                {
                    BottomLine.BackColor = Color.Gray;
                    if (mouseIn)
                    {
                        BackColor = Color.FromArgb(14, 14, 14);
                        return;
                    }
                    BackColor = Color.FromArgb(20, 20, 20);
                }
            }
        }
        #endregion

        #region Process
        public Process process { get; set; }
        #endregion

        #endregion
    }
}