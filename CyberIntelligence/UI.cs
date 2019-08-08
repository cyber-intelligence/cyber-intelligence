using CIF_Core;
using CIF_UserInterface;
using System;
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

        }
        #endregion

        #endregion

        #region Functions

        #region RenderDesktopApp
        private void RenderDesktopApp(int index, string fileName, Image Icon)
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
                    Location = Core.IndexToLocation(index, Wallpaper.Size)
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
                RenderDesktopApp(index, new DirectoryInfo(script).Name, Image.FromFile($"{script}\\icon.png"));
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

        #endregion
    }
}
