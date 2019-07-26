using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberIntelligence
{
    public partial class CIF : Form
    {

        #region CTor
        public CIF()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        #region Load
        private void CIF_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion


    }
}
