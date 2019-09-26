using CIF_Core;
using CIF_UserInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        private bool AlreadyBack;
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
            BringBackUI();
            Opacity = 0;
            WindowState = FormWindowState.Maximized;

            Task.Run(() => Initialize());

            ForgroundHandler();
        }
        #endregion

        #region ClickedShutdown
        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            BringBackUI();
            Close();
        }
        #endregion

        #region ClickedStartedButton
        private void StartButton_Click(object sender, EventArgs e)
        {
            BringBackUI();
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
            BringBackUI();
        }
        #endregion

        #region DoubleClicked
        private void DoubleClickedApp(object sender, EventArgs e)
        {
            BringBackUI();
            var App = (DesktopApp)sender;
            if (App.Filename == "ScriptStore" && TaskExists(App.Filename))
            {
                foreach (var task in Tasks)
                    if (task.Name == App.Filename)
                        Core.BringProcessToFront(task.process);
                return;
            }
            CreateProcess(App);
        }
        #endregion

        #region ClickedTaskbarApp
        private void ClickedTaskbarApp(object sender, EventArgs e)
        {
            BringBackUI();
            var AppTask = (TaskbarApp)sender;
            Core.BringProcessToFront(AppTask.process);
        }
        #endregion

        #region WallpaperClick
        private void Wallpaper_Click(object sender, EventArgs e)
        {
            BringBackUI();
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
            // Core.KillExplorer();

            Taskbar.Hide();

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
                Dock = DockStyle.Left,
                Name = App.Filename
            };
            ActiveTaskPanel.Controls.Add(AppTask);
            AppTask.OnClick += ClickedTaskbarApp;
            var process = new Process();
            process.StartInfo.FileName = App.Executable.FullName;
            process.StartInfo.WorkingDirectory = App.Executable.DirectoryName;
            process.Start();
            AppTask.process = process;
            Tasks.Add(AppTask);

            startMenu.Tasks = Tasks;
        }
        #endregion

        #region ForgroundHandler
        private void ForgroundHandler()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);

                    #region CheckCIF
                    var forgroundPID = Core.GetForgroundProcessID();
                    if (forgroundPID == Process.GetCurrentProcess().Id)
                    {
                        if (AlreadyBack)
                            continue;
                        AlreadyBack = true;
                        BringBackUI();
                    }
                    else
                        AlreadyBack = false;
                    #endregion

                    #region CheckActive
                    try
                    {
                        forgroundPID = Core.GetForgroundProcessID();
                        foreach (var task in Tasks)
                        {
                            if (forgroundPID == task.process.Id)
                                task.active = true;
                            else
                                task.active = false;
                        }
                    }
                    catch { }
                    #endregion

                    #region CheckExists
                    try
                    {
                        foreach (var task in Tasks)
                        {
                            if (task.process.HasExited)
                            {
                                BeginInvoke((MethodInvoker)delegate
                                {
                                    Tasks.Remove(task);
                                    ActiveTaskPanel.Controls.Remove(task);
                                    task.Dispose();
                                    startMenu.Tasks = Tasks;
                                });
                                continue;
                            }
                        }
                    }
                    catch { }
                    #endregion
                }
            });
        }
        #endregion

        #region DeActivate

        private void BringBackUI()
        {
            SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        #region aux dlls
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        #endregion

        #endregion

        #region TaskExists
        private bool TaskExists(string name)
        {
            foreach (var task in Tasks)
            {
                if (task.Name == name)
                    return true;
            }
            return false;
        }
        #endregion

        #endregion

    }
}
