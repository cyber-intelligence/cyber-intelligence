using CIF_Core;
using CIF_UserInterface;
using System;
using System.IO;
using System.Windows.Forms;

namespace ScriptStore
{
    public partial class UI : Form
    {

        #region Variables

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
        private void Search()
        {
            listPanel.Controls.Clear();
            string keyword = SearchBox.Text;
            var results = Core.SearchStore(keyword);
            foreach (var app in results)
            {
                LoadApp(app);
            }
        }
        #endregion

        #region LoadRepo
        private void LoadRepo()
        {
            listPanel.Controls.Clear();
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var app in repo)
            {
                LoadApp(app.Name);
            }
        }
        #endregion

        #region LoadApp
        private async void LoadApp(string appName)
        {
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var app in repo)
            {
                CIF_UserInterface.StoreApp SAP = new CIF_UserInterface.StoreApp();
                SAP.LoadIcon($"https://raw.githubusercontent.com/cyber-intelligence/cyber-intelligence/master/ScriptStore/{appName}/icon.png");
                SAP.OnClick += ClickedStoreApp;
                SAP.appTitle = appName;
                SAP.appDescription = await Core.GetAppDescriptionAsync(appName);
                listPanel.Controls.Add(SAP);
            }
        }
        #endregion

        #region UpdateStore
        private void UpdateStore()
        {
            Core.UpdateRepositoryAsync();
            LoadRepo();
        }
        #endregion

        #endregion
    }
}
