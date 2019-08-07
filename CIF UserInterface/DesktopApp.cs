using System.Drawing;
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

        }
        #endregion

        #region Clicked
        private void OnClick(object sender, System.EventArgs e)
        {

        }
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

        #region Back
        public Control Back { get; set; }
        #endregion

        #endregion
    }
}