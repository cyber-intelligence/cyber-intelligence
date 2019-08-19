namespace CIF_UserInterface
{
    partial class StoreApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreApp));
            this.iconPic = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPic
            // 
            this.iconPic.BackColor = System.Drawing.Color.Transparent;
            this.iconPic.Image = ((System.Drawing.Image)(resources.GetObject("iconPic.Image")));
            this.iconPic.Location = new System.Drawing.Point(6, 3);
            this.iconPic.Name = "iconPic";
            this.iconPic.Size = new System.Drawing.Size(50, 50);
            this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPic.TabIndex = 0;
            this.iconPic.TabStop = false;
            this.iconPic.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.iconPic.MouseEnter += new System.EventHandler(this.Hover);
            this.iconPic.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoEllipsis = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(60, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(226, 20);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Application Name";
            this.labelTitle.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.labelTitle.MouseEnter += new System.EventHandler(this.Hover);
            this.labelTitle.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.labelDescription.Location = new System.Drawing.Point(62, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(224, 77);
            this.labelDescription.TabIndex = 31;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            this.labelDescription.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.labelDescription.MouseEnter += new System.EventHandler(this.Hover);
            this.labelDescription.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(0, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(300, 1);
            this.BorderTop.TabIndex = 32;
            this.BorderTop.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 119);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(300, 1);
            this.BorderBottom.TabIndex = 33;
            this.BorderBottom.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 1);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 118);
            this.BorderLeft.TabIndex = 34;
            this.BorderLeft.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(299, 1);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 118);
            this.BorderRight.TabIndex = 35;
            this.BorderRight.MouseLeave += new System.EventHandler(this.UnHover);
            // 
            // StoreApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.iconPic);
            this.Controls.Add(this.labelDescription);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "StoreApp";
            this.Size = new System.Drawing.Size(300, 120);
            this.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.MouseEnter += new System.EventHandler(this.Hover);
            this.MouseLeave += new System.EventHandler(this.UnHover);
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPic;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderRight;
    }
}
