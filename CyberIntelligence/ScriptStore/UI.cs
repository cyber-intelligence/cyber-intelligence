using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIF_UserInterface;
using CIF_Core;
using System.IO;

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

        }
        #endregion

        #region LoadRepo
        private void LoadRepo()
        {
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var app in repo)
            {
                LoadApp(File.ReadAllText(""));
            }
        }
        #endregion

        #region LoadApp
        private void LoadApp(string appName)
        {
            var repo = new DirectoryInfo("Repo").GetFiles();
            foreach (var app in repo)
            {

            }
        }
        #endregion

        #endregion
    }
}
