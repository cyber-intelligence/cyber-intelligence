using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CIF_UserInterface
{
    public partial class StartMenu : UserControl
    {

        #region Variables
        public List<TaskbarApp> Tasks = new List<TaskbarApp>();
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
            Shutdown();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions

        #region Shutdown

        private void Shutdown()
        {
            try
            {
                foreach (var task in Tasks)
                    task.process.Kill();
            }
            catch { }

            if (Process.GetProcessesByName("explorer").Length == 0)
            {
                var cmd = new Process();
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.FileName = Path.Combine(Environment.GetEnvironmentVariable("windir"), "explorer.exe");
                cmd.Start();
            }


            Process.GetCurrentProcess().Kill();
        }

        #endregion

        #endregion

    }
}
