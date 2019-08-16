using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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
        #endregion

        #region Functions

        #endregion

        #region Properties

        public string appName { get => labelTitle.Text; set => labelTitle.Text = value; }
        public string appDescription { get => labelDescription.Text; set => labelDescription.Text = value; }
        public Image appIcon { get => pictureBox1.Image; set => pictureBox1.Image = value; }

        #endregion

    }
}
