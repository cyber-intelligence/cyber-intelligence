using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

        #region ClearCache
        private static void ClearCache()
        {
            var cachePath = AppDomain.CurrentDomain.BaseDirectory + @"\Cache\\";
            if (!Directory.Exists(cachePath))
                Directory.CreateDirectory(cachePath);

            foreach (var file in new DirectoryInfo(cachePath).GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                { }
            }

            foreach (var dir in new DirectoryInfo(cachePath).GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                { }
            }
        }
        #endregion

        #region InstallScript

        #region InstallRequirements
        private static void InstallRequirements(string url, string appName)
        {
            var requirementURL = $"{url}/requirements.zip";
            var cachePath = AppDomain.CurrentDomain.BaseDirectory + @"\Cache\\";

            using (WebClient wclient = new WebClient())
            {
                wclient.DownloadFile(requirementURL, cachePath + appName + "_requirements.zip");
            }
            ZipFile.ExtractToDirectory(cachePath + appName + "_requirements.zip", cachePath + appName + "_requirements");
            foreach (var file in new DirectoryInfo(cachePath + appName + "_requirements").GetFiles())
            {
                Process p = new Process();
                p.StartInfo.FileName = file.FullName;
                p.StartInfo.Verb = "runas";
                p.Start();
                p.WaitForExit();
            }
        }
        #endregion

        public static void InstallApp(string appName)
        {
            ClearCache();
            string url = $"https://raw.githubusercontent.com/cyber-intelligence/cyber-intelligence/master/ScriptStore/{appName}";
            var config = GetAppConfig(appName).Replace("\r", "");
            var isCLI = config.Split('\n')[0].Replace("cli=", "") == "true";
            if (isCLI)
            {
                #region Install as terminal script

                var binPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\Terminal\Scripts\\";
                var cachePath = AppDomain.CurrentDomain.BaseDirectory + @"\Cache\\";

                #region Download requirements
                var hasRequirements = config.Split('\n')[5].Replace("hasreq=", "") == "true";
                if (hasRequirements)
                {
                    try
                    {
                        InstallRequirements(url, appName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UninstallApp(appName);
                        return;
                    }
                }
                #endregion

                #region Download script file into Cache folder
                var fileURL = $"{url}/{appName}.zip";
                try
                {
                    if (File.Exists(cachePath + appName + ".zip"))
                        File.Delete(cachePath + appName + ".zip");
                }
                catch { }

                try
                {
                    using (WebClient wclient = new WebClient())
                    {
                        wclient.DownloadFile(fileURL, cachePath + appName + ".zip");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UninstallApp(appName);
                    return;
                }
                #endregion

                #region Add to terminal bin
                try
                {
                    ZipFile.ExtractToDirectory(cachePath + appName + ".zip", binPath + appName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UninstallApp(appName);
                    return;
                }
                File.WriteAllText(binPath + appName + ".dat", config.Split('\n')[4].Replace("expath=", ""));
                #endregion

                #endregion
            }
            else
            {
                #region Install as Desktop app
                var desktopScriptsPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;
                var cachePath = AppDomain.CurrentDomain.BaseDirectory + @"\Cache\\";

                #region Download requirements
                var hasRequirements = config.Split('\n')[5].Replace("hasreq=", "") == "true";
                if (hasRequirements)
                {
                    try
                    {
                        InstallRequirements(url, appName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UninstallApp(appName);
                        return;
                    }
                }
                #endregion

                #region Download script file into Cache folder
                var fileURL = $"{url}/{appName}.zip";
                try
                {
                    if (File.Exists(cachePath + appName + ".zip"))
                        File.Delete(cachePath + appName + ".zip");
                }
                catch { }

                try
                {
                    using (WebClient wclient = new WebClient())
                    {
                        wclient.DownloadFile(fileURL, cachePath + appName + ".zip");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UninstallApp(appName);
                    return;
                }
                #endregion

                #region Install to DesktopScripts folder
                try
                {
                    ZipFile.ExtractToDirectory(cachePath + appName + ".zip", desktopScriptsPath + appName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UninstallApp(appName);
                    return;
                }

                try
                {
                    using (WebClient wclient = new WebClient())
                    {
                        wclient.DownloadFile($"{url}/icon.png", desktopScriptsPath + appName + "\\icon.png");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UninstallApp(appName);
                    return;
                }

                #endregion

                #endregion
            }

            ClearCache();
        }
        #endregion

        #region UnInstallScript
        public static void UninstallApp(string appName)
        {
            var binPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\Terminal\Scripts\\";
            var desktopScriptsPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

            #region Delete App Bin
            try
            {
                File.Delete($"{binPath}{appName}.dat");
            }
            catch { }

            try
            {
                Directory.Delete($"{binPath}{appName}", true);
            }
            catch { }
            #endregion

            #region Delete App Desktop
            try
            {
                Directory.Delete($"{desktopScriptsPath}{appName}", true);
            }
            catch { }
            #endregion

            ClearCache();
        }
        #endregion

        #region CheckInstalled
        public static bool CheckInstalled(string appName)
        {
            var binPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\Terminal\Scripts\\";
            if (!Directory.Exists(binPath))
                Directory.CreateDirectory(binPath);
            var DesktopScriptsPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

            foreach (var file in new DirectoryInfo(binPath).GetFiles())
            {
                if (file.Name.Replace(file.Extension, "") == appName)
                    return true;
            }

            foreach (var dir in new DirectoryInfo(DesktopScriptsPath).GetDirectories())
            {
                if (dir.Name == appName)
                    return true;
            }

            return false;
        }
        #endregion
    }
}