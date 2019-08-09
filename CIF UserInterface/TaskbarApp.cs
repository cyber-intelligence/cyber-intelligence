using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
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

        private bool MouseIn;

        #region Hover
        private void TaskbarAppHover(object sender, EventArgs e)
        {
            MouseIn = true;
            if (active)
                iconBox.BackColor = Color.FromArgb(32, 32, 32);
            else
                iconBox.BackColor = Color.FromArgb(14, 14, 14);
        }
        #endregion

        #region UnHover
        private void TaskbarAppUnHover(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                MouseIn = false;
                Thread.Sleep(50);
                if (!MouseIn)
                {
                    iconBox.BackColor = Color.FromArgb(20, 20, 20);
                }
            });
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
                    BottomLine.BackColor = Color.FromArgb(52, 152, 219);
                    iconBox.BackColor = Color.FromArgb(20, 20, 20);
                }
                else
                {
                    BottomLine.BackColor = Color.Gray;
                    iconBox.BackColor = Color.FromArgb(26, 26, 26);
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