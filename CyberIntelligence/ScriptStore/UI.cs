using CIF_Core;
using CIF_UserInterface;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptStore
{
    public partial class UI : Form
    {
        #region Variables
        private bool LoadingBusy = true;
        private Control currentAppView = null;
        #endregion

        #region CTor
        public UI()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            (new UIShadow()).ApplyShadows(this);
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events
        private void UI_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Repo"))
            {
                MessageBox.Show("Your database is missing! press OK to pull the database...");
                Core.UpdateRepositoryAsync();
                LoadRepo();
            }
            else
            {
                LoadRepo();
            }

        }

        private void BtnUpdateRepo_Click(object sender, EventArgs e)
        {
            if (LoadingBusy)
            {
                MessageBox.Show("Please wait...!", "Busy!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Core.UpdateRepositoryAsync();
            LoadRepo();
        }

        private void SearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Search();
        }

        private void ClickedStoreApp(object sender, EventArgs e)
        {
            var app = (CIF_UserInterface.StoreApp)sender;
            ViewApp(app);
        }
        #endregion

        #region Functions

        #region MovableFunction
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Search
        private async void Search()
        {
            Preloader.Visible = true;
            listPanel.Controls.Clear();
            string keyword = SearchBox.Text;
            var results = Core.SearchStore(keyword);
            foreach (var app in results)
            {
                await Task.Run(() => LoadApp(app));
            }
            Preloader.Visible = false;
        }
        #endregion

        #region LoadRepo
        private async void LoadRepo()
        {
            LoadingBusy = true;
            Preloader.Visible = true;
            listPanel.Controls.Clear();
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var app in repo)
            {
                await Task.Run(() => LoadApp(app.Name));
            }
            LoadingBusy = false;
            Preloader.Visible = false;
        }
        #endregion

        #region LoadApp
        private void LoadApp(string appName)
        {
            CIF_UserInterface.StoreApp SAP = new CIF_UserInterface.StoreApp();
            SAP.appIcon = Core.GetImage($"https://raw.githubusercontent.com/cyber-intelligence/cyber-intelligence/master/ScriptStore/{appName}/icon.png");
            if (SAP.appIcon == null)
                return;
            SAP.OnClick += ClickedStoreApp;
            SAP.appTitle = appName;
            SAP.appConfig = Core.GetAppConfig(appName);
            BeginInvoke((MethodInvoker)delegate ()
            {
                listPanel.Controls.Add(SAP);
            });
        }
        #endregion

        #region UpdateStore
        private void UpdateStore()
        {
            Core.UpdateRepositoryAsync();
            LoadRepo();
        }
        #endregion

        #region ViewApp
        private void ViewApp(CIF_UserInterface.StoreApp app)
        {
            if (currentAppView != null)
                PagePanel.Controls.Remove(currentAppView);
            pageTitle.Text = app.appTitle.ToUpper();
            listPanel.Visible = false;
            SearchBox.Visible = false;
            BtnUpdateRepo.Visible = false;
            var appView = new storeAppView
            {
                appName = app.appTitle,
                appConfig = app.appConfig,
                appIcon = app.appIcon,
                Dock = DockStyle.Fill
            };

            appView.ClickedBack += delegate
            {
                pageTitle.Text = "Script Store";
                listPanel.Visible = true;
                SearchBox.Visible = true;
                BtnUpdateRepo.Visible = true;
                if (currentAppView != null)
                {
                    PagePanel.Controls.Remove(currentAppView);
                }
            };

            PagePanel.Controls.Add(appView);
            currentAppView = appView;
        }
        #endregion

        #endregion
    }
}
