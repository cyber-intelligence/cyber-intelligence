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
            this.Wallpaper = new System.Windows.Forms.PictureBox();
            this.TaskbarPanel = new System.Windows.Forms.Panel();
            this.ActiveTaskPanel = new System.Windows.Forms.Panel();
            this.TaskbarLeftMargin = new System.Windows.Forms.Panel();
            this.StartButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TaskbarBorderTop = new System.Windows.Forms.Panel();
            this.startMenu = new CIF_UserInterface.StartMenu();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.TaskbarPanel.SuspendLayout();
            this.ActiveTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wallpaper
            // 
            this.Wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("Wallpaper.Image")));
            this.Wallpaper.Location = new System.Drawing.Point(0, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(1296, 807);
            this.Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wallpaper.TabIndex = 0;
            this.Wallpaper.TabStop = false;
            this.Wallpaper.Click += new System.EventHandler(this.Wallpaper_Click);
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TaskbarPanel.Controls.Add(this.ActiveTaskPanel);
            this.TaskbarPanel.Controls.Add(this.StartButton);
            this.TaskbarPanel.Controls.Add(this.TaskbarBorderTop);
            this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 765);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(1296, 42);
            this.TaskbarPanel.TabIndex = 2;
            // 
            // ActiveTaskPanel
            // 
            this.ActiveTaskPanel.Controls.Add(this.TaskbarLeftMargin);
            this.ActiveTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveTaskPanel.Location = new System.Drawing.Point(42, 1);
            this.ActiveTaskPanel.Name = "ActiveTaskPanel";
            this.ActiveTaskPanel.Size = new System.Drawing.Size(1254, 41);
            this.ActiveTaskPanel.TabIndex = 4;
            // 
            // TaskbarLeftMargin
            // 
            this.TaskbarLeftMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaskbarLeftMargin.Location = new System.Drawing.Point(0, 0);
            this.TaskbarLeftMargin.Name = "TaskbarLeftMargin";
            this.TaskbarLeftMargin.Size = new System.Drawing.Size(20, 41);
            this.TaskbarLeftMargin.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.ActiveImage = null;
            this.StartButton.AllowAnimations = true;
            this.StartButton.AllowZooming = false;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("StartButton.ErrorImage")));
            this.StartButton.FadeWhenInactive = true;
            this.StartButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageActive = null;
            this.StartButton.ImageLocation = null;
            this.StartButton.ImageMargin = 10;
            this.StartButton.ImageSize = new System.Drawing.Size(32, 31);
            this.StartButton.ImageZoomSize = new System.Drawing.Size(42, 41);
            this.StartButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("StartButton.InitialImage")));
            this.StartButton.Location = new System.Drawing.Point(0, 1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Rotation = 0;
            this.StartButton.ShowActiveImage = true;
            this.StartButton.ShowCursorChanges = false;
            this.StartButton.ShowImageBorders = false;
            this.StartButton.ShowSizeMarkers = false;
            this.StartButton.Size = new System.Drawing.Size(42, 41);
            this.StartButton.TabIndex = 1;
            this.StartButton.ToolTipText = "Menu";
            this.StartButton.WaitOnLoad = false;
            this.StartButton.Zoom = 10;
            this.StartButton.ZoomSpeed = 10;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TaskbarBorderTop
            // 
            this.TaskbarBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.TaskbarBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskbarBorderTop.Location = new System.Drawing.Point(0, 0);
            this.TaskbarBorderTop.Name = "TaskbarBorderTop";
            this.TaskbarBorderTop.Size = new System.Drawing.Size(1296, 1);
            this.TaskbarBorderTop.TabIndex = 3;
            // 
            // startMenu
            // 
            this.startMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startMenu.Location = new System.Drawing.Point(1, 396);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(323, 366);
            this.startMenu.TabIndex = 3;
            this.startMenu.Visible = false;
            // 
            // CIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1296, 807);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.TaskbarPanel);
            this.Controls.Add(this.Wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIF";
            this.ShowInTaskbar = false;
            this.Text = "Cyber Intelligence";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.TaskbarPanel.ResumeLayout(false);
            this.ActiveTaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Wallpaper;
        private System.Windows.Forms.Panel TaskbarPanel;
        private System.Windows.Forms.Panel TaskbarBorderTop;
        private Bunifu.UI.WinForms.BunifuImageButton StartButton;
        private System.Windows.Forms.Panel ActiveTaskPanel;
        private CIF_UserInterface.StartMenu startMenu;
        private System.Windows.Forms.Panel TaskbarLeftMargin;
    }
}

