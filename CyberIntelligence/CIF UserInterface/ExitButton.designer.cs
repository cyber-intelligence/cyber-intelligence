namespace Dark_Hub.DarkHubControls
{
    partial class ExitButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitButton));
            this.PicExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PicExit
            // 
            this.PicExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicExit.Image = ((System.Drawing.Image)(resources.GetObject("PicExit.Image")));
            this.PicExit.Location = new System.Drawing.Point(0, 0);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(20, 20);
            this.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicExit.TabIndex = 0;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            this.PicExit.MouseEnter += new System.EventHandler(this.PicExit_MouseEnter);
            this.PicExit.MouseLeave += new System.EventHandler(this.PicExit_MouseLeave);
            // 
            // ExitButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PicExit);
            this.Name = "ExitButton";
            this.Size = new System.Drawing.Size(20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.PictureBox PicExit;
    }
}
