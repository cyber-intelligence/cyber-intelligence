using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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

        #endregion

        #region Functions

        #region CustomEvents
        public new event EventHandler OnClick;
        public void LocalEventHandler(object sender, EventArgs e) => OnClick?.Invoke(this, e);
        #endregion

        #endregion
    }
}
