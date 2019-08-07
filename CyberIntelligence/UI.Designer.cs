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
            this.ShutdownButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Taskbar = new System.Windows.Forms.Panel();
            this.ActiveTaskPanel = new System.Windows.Forms.Panel();
            this.StartButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TaskbarBorderTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.Taskbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wallpaper
            // 
            this.Wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("Wallpaper.Image")));
            this.Wallpaper.Location = new System.Drawing.Point(0, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(1296, 765);
            this.Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Wallpaper.TabIndex = 0;
            this.Wallpaper.TabStop = false;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.ActiveImage = null;
            this.ShutdownButton.AllowAnimations = true;
            this.ShutdownButton.AllowZooming = false;
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ShutdownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShutdownButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.ErrorImage")));
            this.ShutdownButton.FadeWhenInactive = true;
            this.ShutdownButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ShutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.Image")));
            this.ShutdownButton.ImageActive = null;
            this.ShutdownButton.ImageLocation = null;
            this.ShutdownButton.ImageMargin = 10;
            this.ShutdownButton.ImageSize = new System.Drawing.Size(32, 31);
            this.ShutdownButton.ImageZoomSize = new System.Drawing.Size(42, 41);
            this.ShutdownButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.InitialImage")));
            this.ShutdownButton.Location = new System.Drawing.Point(1254, 1);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Rotation = 0;
            this.ShutdownButton.ShowActiveImage = true;
            this.ShutdownButton.ShowCursorChanges = false;
            this.ShutdownButton.ShowImageBorders = false;
            this.ShutdownButton.ShowSizeMarkers = false;
            this.ShutdownButton.Size = new System.Drawing.Size(42, 41);
            this.ShutdownButton.TabIndex = 1;
            this.ShutdownButton.ToolTipText = "Shutdown";
            this.ShutdownButton.WaitOnLoad = false;
            this.ShutdownButton.Zoom = 10;
            this.ShutdownButton.ZoomSpeed = 10;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // Taskbar
            // 
            this.Taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Taskbar.Controls.Add(this.ActiveTaskPanel);
            this.Taskbar.Controls.Add(this.StartButton);
            this.Taskbar.Controls.Add(this.ShutdownButton);
            this.Taskbar.Controls.Add(this.TaskbarBorderTop);
            this.Taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Taskbar.Location = new System.Drawing.Point(0, 765);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(1296, 42);
            this.Taskbar.TabIndex = 2;
            // 
            // ActiveTaskPanel
            // 
            this.ActiveTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveTaskPanel.Location = new System.Drawing.Point(42, 1);
            this.ActiveTaskPanel.Name = "ActiveTaskPanel";
            this.ActiveTaskPanel.Size = new System.Drawing.Size(1212, 41);
            this.ActiveTaskPanel.TabIndex = 4;
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
            // CIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1296, 807);
            this.Controls.Add(this.Wallpaper);
            this.Controls.Add(this.Taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIF";
            this.Text = "Cyber Intelligence";
            this.Load += new System.EventHandler(this.CIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.Taskbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Wallpaper;
        private Bunifu.UI.WinForms.BunifuImageButton ShutdownButton;
        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.Panel TaskbarBorderTop;
        private Bunifu.UI.WinForms.BunifuImageButton StartButton;
        private System.Windows.Forms.Panel ActiveTaskPanel;
    }
}

