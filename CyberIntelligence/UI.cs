using CIF_Core;
using CIF_UserInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberIntelligence
{
    public partial class CIF : Form
    {
        #region Variables
        private bool animatingStartMenu;
        private List<TaskbarApp> Tasks = new List<TaskbarApp>();
        #endregion

        #region CTor
        public CIF()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events

        #region Load
        private void CIF_Load(object sender, EventArgs e)
        {

            Opacity = 0;
            WindowState = FormWindowState.Maximized;

            Task.Run(() => Initialize());
        }
        #endregion

        #region ClickedShutdown
        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region ClickedStartedButton
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (animatingStartMenu)
                return;
            animatingStartMenu = true;
            if (!startMenu.Visible)
                ShowStartMenu();
            else
                HideStartMenu();
            animatingStartMenu = false;
        }
        #endregion

        #region ClickedApp
        private void ClickedApp(object sender, EventArgs e)
        {
            
            
        }
        #endregion

        #region DoubleClicked
        private void DoubleClickedApp(object sender, EventArgs e)
        {
            var App = (DesktopApp)sender;
            CreateProcess(App);
        }
        #endregion

        #region ClickedTaskbarApp
        private void ClickedTaskbarApp(object sender, EventArgs e)
        {
            var AppTask = (TaskbarApp)sender;

        }
        #endregion

        #endregion

        #region Functions

        #region RenderDesktopApp
        private void RenderDesktopApp(int index, string fileName, Image Icon, FileInfo exe)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                var app = new DesktopApp
                {
                    BackImage = ImageHandling.CropImage(Wallpaper.Image, Core.IndexToWallpaperArea(index, Wallpaper.Size)),
                    Parent = Wallpaper,
                    Filename = fileName,
                    DesktopIndex = index,
                    icon = Icon,
                    Location = Core.IndexToLocation(index, Wallpaper.Size),
                    Executable = exe
                };
                Controls.Add(app);
                app.OnClick += ClickedApp;
                app.OnDoubleClick += DoubleClickedApp;
                app.BringToFront();
            });

        }
        #endregion

        #region LoadApps
        private void LoadApps()
        {
            int index = 0;
            var Data = AppDomain.CurrentDomain.BaseDirectory + "Data\\DesktopScripts";
            foreach (var script in Directory.GetDirectories(Data))
            {
                RenderDesktopApp(index, new DirectoryInfo(script).Name, Image.FromFile($"{script}\\icon.png"), new FileInfo($"{script}\\{new DirectoryInfo(script).Name}.exe"));
                index++;
            }
        }
        #endregion

        #region Initialize
        private void Initialize()
        {
            WindowState = FormWindowState.Maximized;

            Thread.Sleep(250);

            Image img = Wallpaper.Image;
            Wallpaper.Image = ImageHandling.ResizeImage(img, Wallpaper.Size.Width, Wallpaper.Size.Height);

            Thread.Sleep(100);

            LoadApps();

            Thread.Sleep(100);

            Opacity = 1;
        }
        #endregion

        #region StartMenu

        #region Show
        private void ShowStartMenu()
        {
            var Animation = new BunifuAnimatorNS.BunifuTransition
            {
                AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide,
                Interval = 6
            };
            Animation.ShowSync(startMenu);
        }
        #endregion

        #region Hide
        private void HideStartMenu()
        {
            var Animation = new BunifuAnimatorNS.BunifuTransition
            {
                AnimationType = BunifuAnimatorNS.AnimationType.Transparent,
                Interval = 6
            };
            Animation.HideSync(startMenu);
        }
        #endregion

        #endregion

        #region CreateProcess
        private void CreateProcess(DesktopApp App)
        {
            var AppTask = new TaskbarApp
            {
                icon = App.icon,
                active = false,
                Dock = DockStyle.Left
            };
            ActiveTaskPanel.Controls.Add(AppTask);
            AppTask.OnClick += ClickedApp;
            var process = new Process();
            process.StartInfo.FileName = App.Executable.FullName;
            process.StartInfo.WorkingDirectory = App.Executable.DirectoryName;
            process.Start();

            Tasks.Add(AppTask);
        }
        #endregion

        #region ForgroundHandler
        private void ForgroundHandler()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(250);

                }
            });
        }
        #endregion

        #endregion
    }
}
