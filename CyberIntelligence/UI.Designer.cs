namespace CyberIntelligence
{
    partial class CIF
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIF));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShutdownButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActiveTaskPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1296, 807);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.ActiveImage = null;
            this.ShutdownButton.AllowAnimations = true;
            this.ShutdownButton.AllowZooming = false;
            this.ShutdownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ShutdownButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.ErrorImage")));
            this.ShutdownButton.FadeWhenInactive = true;
            this.ShutdownButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ShutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.Image")));
            this.ShutdownButton.ImageActive = null;
            this.ShutdownButton.ImageLocation = null;
            this.ShutdownButton.ImageMargin = 0;
            this.ShutdownButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ShutdownButton.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.ShutdownButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.InitialImage")));
            this.ShutdownButton.Location = new System.Drawing.Point(1255, 5);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Rotation = 0;
            this.ShutdownButton.ShowActiveImage = true;
            this.ShutdownButton.ShowCursorChanges = false;
            this.ShutdownButton.ShowImageBorders = false;
            this.ShutdownButton.ShowSizeMarkers = false;
            this.ShutdownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutdownButton.TabIndex = 1;
            this.ShutdownButton.ToolTipText = "Shutdown";
            this.ShutdownButton.WaitOnLoad = false;
            this.ShutdownButton.Zoom = 0;
            this.ShutdownButton.ZoomSpeed = 10;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.ActiveTaskPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.ShutdownButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 761);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 46);
            this.panel1.TabIndex = 2;
            // 
            // ActiveTaskPanel
            // 
            this.ActiveTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveTaskPanel.Location = new System.Drawing.Point(52, 0);
            this.ActiveTaskPanel.Name = "ActiveTaskPanel";
            this.ActiveTaskPanel.Size = new System.Drawing.Size(1197, 45);
            this.ActiveTaskPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 1);
            this.panel2.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(36, 36);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(46, 46);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = false;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 46);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "Menu";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // CIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1296, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIF";
            this.Text = "Cyber Intelligence";
            this.Load += new System.EventHandler(this.CIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton ShutdownButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel ActiveTaskPanel;
    }
}

