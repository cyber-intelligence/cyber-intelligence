using CIF_Core;
using CIF_UserInterface;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CyberIntelligence
{
    public partial class CIF : Form
    {
        #region CTor
        public CIF()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        #region Load
        private void CIF_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadApps();
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region Functions

        #region RenderDesktopApp
        private void RenderDesktopApp(int index, string fileName, Image Icon)
        {
            var app = new DesktopApp
            {
                Back = Wallpaper,
                Parent = Wallpaper,
                Filename = fileName,
                DesktopIndex = index,
                icon = Icon,
                Location = Core.IndexToLocation(index, Wallpaper.Size)
            };
            Controls.Add(app);
            app.BringToFront();
        }
        #endregion

        #region LoadApps
        private void LoadApps()
        {
            int index = 0;
            var Data = AppDomain.CurrentDomain.BaseDirectory + "Data\\DesktopScripts";
            foreach (var script in Directory.GetDirectories(Data))
            {
                RenderDesktopApp(index, new DirectoryInfo(script).Name, Image.FromFile($"{script}\\icon.png"));
                index++;
            }
        }
        #endregion

        #endregion
    }
}
