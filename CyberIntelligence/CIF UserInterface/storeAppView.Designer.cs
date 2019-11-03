namespace CIF_UserInterface
{
    partial class storeAppView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storeAppView));
            this.BorderRight = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.BtnUpdateRepo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.BtnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.Preloader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preloader)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(694, 1);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 454);
            this.BorderRight.TabIndex = 39;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 1);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 454);
            this.BorderLeft.TabIndex = 38;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 455);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(695, 1);
            this.BorderBottom.TabIndex = 37;
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(0, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(695, 1);
            this.BorderTop.TabIndex = 36;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoEllipsis = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(66, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(318, 20);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "Application Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.LightGray;
            this.labelDescription.Location = new System.Drawing.Point(5, 96);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(680, 315);
            this.labelDescription.TabIndex = 42;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // BtnUpdateRepo
            // 
            this.BtnUpdateRepo.ActiveBorderThickness = 1;
            this.BtnUpdateRepo.ActiveCornerRadius = 2;
            this.BtnUpdateRepo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnUpdateRepo.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUpdateRepo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnUpdateRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.BtnUpdateRepo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdateRepo.BackgroundImage")));
            this.BtnUpdateRepo.ButtonText = "Install";
            this.BtnUpdateRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRepo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateRepo.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateRepo.IdleBorderThickness = 1;
            this.BtnUpdateRepo.IdleCornerRadius = 2;
            this.BtnUpdateRepo.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRepo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUpdateRepo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnUpdateRepo.Location = new System.Drawing.Point(569, 415);
            this.BtnUpdateRepo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdateRepo.Name = "BtnUpdateRepo";
            this.BtnUpdateRepo.Size = new System.Drawing.Size(119, 39);
            this.BtnUpdateRepo.TabIndex = 43;
            this.BtnUpdateRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUpdateRepo.Click += new System.EventHandler(this.BtnUpdateRepo_Click);
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoEllipsis = true;
            this.labelAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelAppVersion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppVersion.ForeColor = System.Drawing.Color.LightGray;
            this.labelAppVersion.Location = new System.Drawing.Point(67, 34);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(317, 24);
            this.labelAppVersion.TabIndex = 42;
            this.labelAppVersion.Text = "0.4.1.6 | Desktop App";
            // 
            // BtnBack
            // 
            this.BtnBack.ActiveBorderThickness = 1;
            this.BtnBack.ActiveCornerRadius = 2;
            this.BtnBack.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBack.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.ButtonText = "Back";
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IdleBorderThickness = 1;
            this.BtnBack.IdleCornerRadius = 2;
            this.BtnBack.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnBack.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnBack.Location = new System.Drawing.Point(442, 413);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(119, 39);
            this.BtnBack.TabIndex = 43;
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoEllipsis = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.labelAuthor.Location = new System.Drawing.Point(5, 67);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(678, 24);
            this.labelAuthor.TabIndex = 42;
            this.labelAuthor.Text = "Author: x";
            // 
            // Preloader
            // 
            this.Preloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Preloader.Image = ((System.Drawing.Image)(resources.GetObject("Preloader.Image")));
            this.Preloader.Location = new System.Drawing.Point(643, 7);
            this.Preloader.Name = "Preloader";
            this.Preloader.Size = new System.Drawing.Size(45, 45);
            this.Preloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preloader.TabIndex = 44;
            this.Preloader.TabStop = false;
            this.Preloader.Visible = false;
            // 
            // storeAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.Preloader);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdateRepo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderTop);
            this.Name = "storeAppView";
            this.Size = new System.Drawing.Size(695, 456);
            this.Load += new System.EventHandler(this.StoreAppView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preloader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnUpdateRepo;
        private System.Windows.Forms.Label labelAppVersion;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnBack;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.PictureBox Preloader;
    }
}
