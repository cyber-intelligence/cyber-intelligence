using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CIF_UserInterface
{
    public partial class StoreApp : UserControl
    {
        #region CTor
        public StoreApp()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events

        #region Hover
        private void Hover(object sender, EventArgs e)
        {
            Thread.Sleep(5);
            BackColor = Color.FromArgb(28, 28, 28);
        }
        #endregion

        #region UnHover
        private void UnHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(32, 32, 32);
        }
        #endregion

        #region OnClick
        public new event EventHandler OnClick;
        public void LocalEventHandlerClicked(object sender, EventArgs e) => OnClick?.Invoke(this, e);
        #endregion

        #endregion

        #region Functions

        #endregion
    }
}
