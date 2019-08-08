using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CIF_UserInterface
{
    public partial class StartMenu : UserControl
    {
        #region Variables

        #endregion

        #region CTor
        public StartMenu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events
        private void StartMenu_Load(object sender, EventArgs e)
        {

        }
        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions

        #endregion


    }
}
