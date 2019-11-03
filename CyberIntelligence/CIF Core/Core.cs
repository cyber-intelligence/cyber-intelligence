using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        #region UpdateRepository
        public static async void UpdateRepositoryAsync()
        {
            if (!Directory.Exists("Repo"))
                Directory.CreateDirectory("Repo");
            var github = new GitHubClient(new ProductHeaderValue("cyber-intelligence"));
            var store = await github.Repository.Content.GetAllContents("cyber-intelligence", "cyber-intelligence", "/ScriptStore");
            foreach (var item in store)
                if (item.Type.StringValue == "dir")
                    File.WriteAllText("Repo\\" + item.Name, item.Path);
        }
        #endregion

        #region SearchStore
        public static List<string> SearchStore(string keyword)
        {
            var results = new List<string>();
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var script in repo)
            {
                if (script.Name.ToLower().Contains(keyword.ToLower()))
                    results.Add(script.Name);
            }
            return results;
        }
        #endregion

        #region GetAppDescription
        public static string GetAppDescription(string appName)
        {
            string desc = string.Empty;
            string url = $"https://raw.githubusercontent.com/cyber-intelligence/cyber-intelligence/master/ScriptStore/{appName}/Config.conf";
            string config = string.Empty;
            using (var webClient = new WebClient())
            {
                config = webClient.DownloadString(url);
            }
            desc = config.Split('\n')[1].Replace("description=", "");
            return desc;
        }
        #endregion

        #region GetAppConfig
        public static string GetAppConfig(string appName)
        {
            string desc = string.Empty;
            string url = $"https://raw.githubusercontent.com/cyber-intelligence/cyber-intelligence/master/ScriptStore/{appName}/Config.conf";
            string config = string.Empty;
            using (var webClient = new WebClient())
            {
                config = webClient.DownloadString(url);
            }
            return config;
        }
        #endregion

        #region GetImage
        public static Image GetImage(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (Stream stream = webClient.OpenRead(url))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch { return null; }
        }
        #endregion

        #region InstallScript
        public static void InstallApp(string url)
        {

        }
        #endregion

        #region UnInstallScript
        public static void UninstallApp(string appName)
        {

        }
        #endregion

        #region CheckInstalled
        public static bool CheckInstalled(string appName)
        {

            return false;
        }
        #endregion


    }
}