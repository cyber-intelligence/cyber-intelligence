using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;

namespace CIF_Core
{
    public class Core
    {

        #region IndexToLoction
        public static Point IndexToLocation(int index, Size resolution)
        {
            int _X = 0;
            int _Y = 2;
            for (int i = 0; i < index; i++)
            {
                _Y += 102;

                if (_Y >= (resolution.Height - 102))
                {
                    _X += 107;
                    _Y = 2;
                }
            }

            return new Point(_X, _Y);
        }
        #endregion

        #region IndexToWallpaperArea
        public static Rectangle IndexToWallpaperArea(int index, Size resolution)
        {
            var indexLocation = IndexToLocation(index, resolution);
            return new Rectangle(new Point(indexLocation.X, indexLocation.Y), new Size(105, 100));
        }
        #endregion

        #region LighterColor
        public static Color LighterColor(Color clr, double Whiteness)
        {
            var red = clr.R;
            var green = clr.G;
            var blue = clr.B;

            var newRed = red + (255 - red) * Whiteness;
            var newGreen = green + (255 - green) * Whiteness;
            var newBlue = blue + (255 - blue) * Whiteness;

            return Color.FromArgb((int)newRed, (int)newGreen, (int)newBlue);
        }
        #endregion

        #region DarkerColor
        public static Color DarkerColor(Color clr, double Darkness)
        {
            var red = clr.R;
            var green = clr.G;
            var blue = clr.B;

            var newRed = red * Darkness;
            var newGreen = green * Darkness;
            var newBlue = blue * Darkness;

            return Color.FromArgb((int)newRed, (int)newGreen, (int)newBlue);
        }
        #endregion

        #region GetForgroundProcessID
        public static int GetForgroundProcessID()
        {
            IntPtr hwnd = GetForegroundWindow();
            GetWindowThreadProcessId(hwnd, out uint pid);
            return (int)pid;
        }

        #region AUX dlls
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        #endregion

        #endregion

        #region BringProcessToFront
        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }

        #region AUX dlls
        const int SW_RESTORE = 9;
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
        #endregion

        #endregion

        #region KillExplorer
        public static void KillExplorer()
        {
            var cmd = new Process();
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/c taskkill /im explorer.exe /f";
            cmd.Start();
        }
        #endregion

        #region GetAllScripts
        public static async System.Threading.Tasks.Task<List<StoreApp>> GetAllScriptsAsync()
        {
            var apps = new List<StoreApp>();
            var github = new GitHubClient(new ProductHeaderValue("cyber-intelligence"));
            var store = await github.Repository.Content.GetAllContents("cyber-intelligence", "cyber-intelligence", "/ScriptStore");
            foreach (var item in store)
            {
                apps.Add(GetAppFromPathAsync(item.Name));
            }
        }

        #region GetAppFromUrl
        public static async System.Threading.Tasks.Task<StoreApp> GetAppFromPathAsync(string Path)
        {
            var app = new StoreApp();
            var github = new GitHubClient(new ProductHeaderValue("cyber-intelligence"));
            var appRepo = await github.Repository.Content.GetAllContents("cyber-intelligence", "cyber-intelligence", Path);

            foreach (var repoItem in appRepo)
            {
                if (repoItem.Name == "icon.png")
                    app.iconUrl = repoItem.DownloadUrl;

                if (repoItem.Name == "Config.conf")
                    app.config = new WebClient().DownloadString(new Uri(repoItem.DownloadUrl));
            }

            app.url = appRepo;
        }
        #endregion

        #endregion

        #region SearchStore
        public static List<StoreApp> SearchStore(string keyword)
        {

        }
        #endregion

        #region InstallStoreScript

        #endregion

    }
}