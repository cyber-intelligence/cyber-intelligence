namespace CIF_UserInterface
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.BorderRight = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.SettingsButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ShutdownButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(322, 0);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 366);
            this.BorderRight.TabIndex = 1;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 365);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(322, 1);
            this.BorderBottom.TabIndex = 2;
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(0, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(322, 1);
            this.BorderTop.TabIndex = 3;
            // 
            // sideMenu
            // 
            this.sideMenu.Controls.Add(this.SettingsButton);
            this.sideMenu.Controls.Add(this.ShutdownButton);
            this.sideMenu.Controls.Add(this.panel1);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 1);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(41, 364);
            this.sideMenu.TabIndex = 4;
            // 
            // SettingsButton
            // 
            this.SettingsButton.ActiveImage = null;
            this.SettingsButton.AllowAnimations = true;
            this.SettingsButton.AllowZooming = false;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.ErrorImage")));
            this.SettingsButton.FadeWhenInactive = true;
            this.SettingsButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageActive = null;
            this.SettingsButton.ImageLocation = null;
            this.SettingsButton.ImageMargin = 10;
            this.SettingsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingsButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.SettingsButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.InitialImage")));
            this.SettingsButton.Location = new System.Drawing.Point(0, 284);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Rotation = 0;
            this.SettingsButton.ShowActiveImage = true;
            this.SettingsButton.ShowCursorChanges = false;
            this.SettingsButton.ShowImageBorders = false;
            this.SettingsButton.ShowSizeMarkers = false;
            this.SettingsButton.Size = new System.Drawing.Size(40, 40);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.ToolTipText = "Shutdown";
            this.SettingsButton.WaitOnLoad = false;
            this.SettingsButton.Zoom = 10;
            this.SettingsButton.ZoomSpeed = 10;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.ActiveImage = null;
            this.ShutdownButton.AllowAnimations = true;
            this.ShutdownButton.AllowZooming = false;
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ShutdownButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShutdownButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.ErrorImage")));
            this.ShutdownButton.FadeWhenInactive = true;
            this.ShutdownButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ShutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.Image")));
            this.ShutdownButton.ImageActive = null;
            this.ShutdownButton.ImageLocation = null;
            this.ShutdownButton.ImageMargin = 10;
            this.ShutdownButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ShutdownButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ShutdownButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.InitialImage")));
            this.ShutdownButton.Location = new System.Drawing.Point(0, 324);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Rotation = 0;
            this.ShutdownButton.ShowActiveImage = true;
            this.ShutdownButton.ShowCursorChanges = false;
            this.ShutdownButton.ShowImageBorders = false;
            this.ShutdownButton.ShowSizeMarkers = false;
            this.ShutdownButton.Size = new System.Drawing.Size(40, 40);
            this.ShutdownButton.TabIndex = 2;
            this.ShutdownButton.ToolTipText = "Shutdown";
            this.ShutdownButton.WaitOnLoad = false;
            this.ShutdownButton.Zoom = 10;
            this.ShutdownButton.ZoomSpeed = 10;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 364);
            this.panel1.TabIndex = 3;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderRight);
            this.Name = "StartMenu";
            this.Size = new System.Drawing.Size(323, 366);
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.UI.WinForms.BunifuImageButton ShutdownButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton SettingsButton;
    }
}
