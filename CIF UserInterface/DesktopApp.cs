using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIF_UserInterface
{
    public partial class DesktopApp : UserControl
    {

        #region CTor
        public DesktopApp()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Events

        #region Load
        private void DesktopApp_Load(object sender, System.EventArgs e)
        {
            labelName.BackColor = Color.Transparent;
        }
        #endregion

        #region HoverEvents

        private bool MouseIn;

        #region Hover
        private void DesktopApp_MouseEnter(object sender, System.EventArgs e)
        {
            MouseIn = true;
            BackColor = Color.FromArgb(25, 26, 28);
            BackgroundImage = null;
        }
        #endregion

        #region UnHover
        private void LabelName_MouseLeave(object sender, System.EventArgs e)
        {
            Task.Run(() =>
            {
                MouseIn = false;
                Thread.Sleep(50);
                if (!MouseIn)
                {
                    BackColor = Color.FromArgb(21, 22, 24);
                    BackgroundImage = BackImage;
                }
            });
        }
        #endregion

        #endregion

        #endregion

        #region Functions

        #region CustomEvents

        #region OnClick
        public new event EventHandler OnClick;
        public void LocalEventHandlerClicked(object sender, EventArgs e) => OnClick?.Invoke(this, e);
        #endregion

        #region OnDoubleClick
        public new event EventHandler OnDoubleClick;
        private void LocalEventHandlerDoubleClicked(object sender, EventArgs e) => OnDoubleClick?.Invoke(this, e);
        #endregion

        #endregion

        #endregion

        #region Properties

        #region Filename
        public string Filename
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }
        #endregion

        #region Icon
        public Image icon
        {
            get => iconBox.Image;
            set => iconBox.Image = value;
        }
        #endregion

        #region DesktopIndex
        public int DesktopIndex { get; set; }
        #endregion

        #region ScriptPath
        public string ScriptPath { get; set; }
        #endregion

        #region BackImage
        private Image backImage;
        public Image BackImage
        {
            get => backImage;
            set
            {
                BackgroundImage = backImage = value;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        #endregion

        #region Cli
        public bool isCli { get; set; }
        #endregion

        #region Description
        public string description { get; set; }
        #endregion

        #region Executable
        public FileInfo Executable { get; set; }
        #endregion

        #endregion

    }
}