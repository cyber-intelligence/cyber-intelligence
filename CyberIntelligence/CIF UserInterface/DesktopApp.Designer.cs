namespace CIF_UserInterface
{
    partial class DesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopApp));
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(16, 0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(73, 70);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            this.iconBox.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.iconBox.DoubleClick += new System.EventHandler(this.LocalEventHandlerDoubleClicked);
            this.iconBox.MouseEnter += new System.EventHandler(this.DesktopApp_MouseEnter);
            this.iconBox.MouseLeave += new System.EventHandler(this.LabelName_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 27);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelName.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.labelName.DoubleClick += new System.EventHandler(this.LocalEventHandlerDoubleClicked);
            this.labelName.MouseEnter += new System.EventHandler(this.DesktopApp_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.LabelName_MouseLeave);
            // 
            // DesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.iconBox);
            this.Name = "DesktopApp";
            this.Size = new System.Drawing.Size(105, 100);
            this.Click += new System.EventHandler(this.LocalEventHandlerClicked);
            this.DoubleClick += new System.EventHandler(this.LocalEventHandlerDoubleClicked);
            this.MouseEnter += new System.EventHandler(this.DesktopApp_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LabelName_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label labelName;
    }
}
