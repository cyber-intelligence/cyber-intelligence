namespace ScriptStore
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.maximizeButton1 = new Dark_Hub.DarkHubControls.MaximizeButton();
            this.minimizeButton1 = new Dark_Hub.DarkHubControls.MinimizeButton();
            this.BtnExit = new Dark_Hub.DarkHubControls.ExitButton();
            this.SearchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.listPanel = new CIF_UserInterface.ListPanel();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            this.ShadowWrapper = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pageTitle = new System.Windows.Forms.Label();
            this.Preloader = new System.Windows.Forms.PictureBox();
            this.BtnUpdateRepo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preloader)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.icon);
            this.Header.Controls.Add(this.maximizeButton1);
            this.Header.Controls.Add(this.minimizeButton1);
            this.Header.Controls.Add(this.BtnExit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(944, 25);
            this.Header.TabIndex = 1;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Title.Location = new System.Drawing.Point(25, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(182, 25);
            this.Title.TabIndex = 31;
            this.Title.Text = "Cyber Intelligence: ScriptStore";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(25, 25);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 31;
            this.icon.TabStop = false;
            this.icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // maximizeButton1
            // 
            this.maximizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton1.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.maximizeButton1.Location = new System.Drawing.Point(902, 2);
            this.maximizeButton1.Name = "maximizeButton1";
            this.maximizeButton1.Size = new System.Drawing.Size(20, 20);
            this.maximizeButton1.TabIndex = 4;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton1.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.minimizeButton1.Location = new System.Drawing.Point(882, 3);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton1.TabIndex = 5;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExit.Location = new System.Drawing.Point(922, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(20, 20);
            this.BtnExit.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = true;
            this.SearchBox.AcceptsTab = false;
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBox.BackgroundImage")));
            this.SearchBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SearchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SearchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SearchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SearchBox.BorderRadius = 1;
            this.SearchBox.BorderThickness = 1;
            this.SearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SearchBox.DefaultText = "";
            this.SearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchBox.HideSelection = true;
            this.SearchBox.IconLeft = null;
            this.SearchBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SearchBox.IconPadding = 7;
            this.SearchBox.IconRight = ((System.Drawing.Image)(resources.GetObject("SearchBox.IconRight")));
            this.SearchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox.Location = new System.Drawing.Point(596, 31);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.SearchBox.Modified = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.ReadOnly = false;
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.ShortcutsEnabled = true;
            this.SearchBox.Size = new System.Drawing.Size(335, 35);
            this.SearchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBox.TextMarginLeft = 0;
            this.SearchBox.TextPlaceholder = "Search";
            this.SearchBox.UseSystemPasswordChar = false;
            this.SearchBox.OnIconRightClick += new System.EventHandler(this.SearchBox_OnIconRightClick);
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // PagePanel
            // 
            this.PagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagePanel.Controls.Add(this.listPanel);
            this.PagePanel.Controls.Add(this.BorderTop);
            this.PagePanel.Controls.Add(this.BorderBottom);
            this.PagePanel.Controls.Add(this.BorderLeft);
            this.PagePanel.Controls.Add(this.BorderRight);
            this.PagePanel.Location = new System.Drawing.Point(12, 72);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(920, 526);
            this.PagePanel.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(1, 1);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(918, 524);
            this.listPanel.TabIndex = 0;
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(1, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(918, 1);
            this.BorderTop.TabIndex = 4;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(1, 525);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(918, 1);
            this.BorderBottom.TabIndex = 3;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 526);
            this.BorderLeft.TabIndex = 2;
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(919, 0);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 526);
            this.BorderRight.TabIndex = 1;
            // 
            // ShadowWrapper
            // 
            this.ShadowWrapper.ActiveImage = null;
            this.ShadowWrapper.AllowAnimations = true;
            this.ShadowWrapper.AllowZooming = false;
            this.ShadowWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowWrapper.BackColor = System.Drawing.Color.Transparent;
            this.ShadowWrapper.Enabled = false;
            this.ShadowWrapper.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ShadowWrapper.ErrorImage")));
            this.ShadowWrapper.FadeWhenInactive = true;
            this.ShadowWrapper.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ShadowWrapper.Image = ((System.Drawing.Image)(resources.GetObject("ShadowWrapper.Image")));
            this.ShadowWrapper.ImageActive = null;
            this.ShadowWrapper.ImageLocation = null;
            this.ShadowWrapper.ImageMargin = 15;
            this.ShadowWrapper.ImageSize = new System.Drawing.Size(929, -14);
            this.ShadowWrapper.ImageZoomSize = new System.Drawing.Size(944, 1);
            this.ShadowWrapper.InitialImage = ((System.Drawing.Image)(resources.GetObject("ShadowWrapper.InitialImage")));
            this.ShadowWrapper.Location = new System.Drawing.Point(0, 609);
            this.ShadowWrapper.Name = "ShadowWrapper";
            this.ShadowWrapper.Rotation = 0;
            this.ShadowWrapper.ShowActiveImage = true;
            this.ShadowWrapper.ShowCursorChanges = true;
            this.ShadowWrapper.ShowImageBorders = false;
            this.ShadowWrapper.ShowSizeMarkers = false;
            this.ShadowWrapper.Size = new System.Drawing.Size(944, 1);
            this.ShadowWrapper.TabIndex = 24;
            this.ShadowWrapper.ToolTipText = "";
            this.ShadowWrapper.WaitOnLoad = false;
            this.ShadowWrapper.Zoom = 15;
            this.ShadowWrapper.ZoomSpeed = 10;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageTitle.Location = new System.Drawing.Point(11, 39);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(108, 20);
            this.pageTitle.TabIndex = 30;
            this.pageTitle.Text = "ScriptStore";
            // 
            // Preloader
            // 
            this.Preloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Preloader.Image = ((System.Drawing.Image)(resources.GetObject("Preloader.Image")));
            this.Preloader.Location = new System.Drawing.Point(418, 24);
            this.Preloader.Name = "Preloader";
            this.Preloader.Size = new System.Drawing.Size(45, 45);
            this.Preloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preloader.TabIndex = 32;
            this.Preloader.TabStop = false;
            // 
            // BtnUpdateRepo
            // 
            this.BtnUpdateRepo.ActiveBorderThickness = 1;
            this.BtnUpdateRepo.ActiveCornerRadius = 2;
            this.BtnUpdateRepo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateRepo.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUpdateRepo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnUpdateRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.BtnUpdateRepo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdateRepo.BackgroundImage")));
            this.BtnUpdateRepo.ButtonText = "Update Database";
            this.BtnUpdateRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRepo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateRepo.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateRepo.IdleBorderThickness = 1;
            this.BtnUpdateRepo.IdleCornerRadius = 2;
            this.BtnUpdateRepo.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRepo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUpdateRepo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnUpdateRepo.Location = new System.Drawing.Point(470, 29);
            this.BtnUpdateRepo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdateRepo.Name = "BtnUpdateRepo";
            this.BtnUpdateRepo.Size = new System.Drawing.Size(119, 39);
            this.BtnUpdateRepo.TabIndex = 33;
            this.BtnUpdateRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUpdateRepo.Click += new System.EventHandler(this.BtnUpdateRepo_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(944, 610);
            this.Controls.Add(this.Preloader);
            this.Controls.Add(this.BtnUpdateRepo);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.ShadowWrapper);
            this.Controls.Add(this.PagePanel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.Text = "ScriptStore";
            this.Load += new System.EventHandler(this.UI_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Preloader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CIF_UserInterface.ListPanel listPanel;
        private System.Windows.Forms.Panel Header;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox SearchBox;
        private System.Windows.Forms.Panel PagePanel;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderRight;
        private Dark_Hub.DarkHubControls.MaximizeButton maximizeButton1;
        private Dark_Hub.DarkHubControls.MinimizeButton minimizeButton1;
        private Dark_Hub.DarkHubControls.ExitButton BtnExit;
        private Bunifu.UI.WinForms.BunifuImageButton ShadowWrapper;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox Preloader;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnUpdateRepo;
    }
}

