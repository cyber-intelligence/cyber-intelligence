using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIF_UserInterface
{
    public partial class storeAppView : UserControl
    {
        #region Variables

        #endregion

        #region CTor
        public storeAppView()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events
        private void StoreAppView_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler ClickedBack;
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (Preloader.Visible)
                return;

            ClickedBack?.Invoke(this, e);
        }

        private async void BtnUpdateRepo_Click(object sender, EventArgs e)
        {
            if (Preloader.Visible)
                return;

            if (BtnUpdateRepo.ButtonText == "Install")
            {
                BtnUpdateRepo.ButtonText = "Installing...";
                Preloader.Visible = true;
                await Task.Run(() => CIF_Core.Core.InstallApp(appName));
                Preloader.Visible = false;
                BtnUpdateRepo.ButtonText = "Uninstall";
            }
            else
            {
                Preloader.Visible = true;
                await Task.Run(() => CIF_Core.Core.UninstallApp(appName));
                Preloader.Visible = false;

                BtnUpdateRepo.ButtonText = "Install";
            }
        }
        #endregion

        #region Functions

        #endregion

        #region Properties

        public string appName { get => labelTitle.Text; set => labelTitle.Text = value; }
        private string _appConfig;
        public string appConfig
        {
            get => _appConfig;
            set
            {
                _appConfig = value.Replace("\r", "");

                var cli = _appConfig.Split('\n')[0].Replace("cli=", "");
                var type = cli == "true" ? "Terminal Script" : "Desktop App";
                var version = _appConfig.Split('\n')[3].Replace("version=", "");

                labelAppVersion.Text = $"{version} | {type}";
                labelDescription.Text = _appConfig.Split('\n')[1].Replace("description=", "");
                labelAuthor.Text = _appConfig.Split('\n')[2].Replace("author=", "");

            }
        }
        public Image appIcon { get => pictureBox1.Image; set => pictureBox1.Image = value; }


        #endregion
    }
}
