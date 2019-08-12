namespace Dark_Hub.DarkHubControls
{
    partial class MaximizeButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaximizeButton));
            this.PicMaximize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // PicMaximize
            // 
            this.PicMaximize.BackColor = System.Drawing.Color.Transparent;
            this.PicMaximize.Image = ((System.Drawing.Image)(resources.GetObject("PicMaximize.Image")));
            this.PicMaximize.Location = new System.Drawing.Point(2, 2);
            this.PicMaximize.Name = "PicMaximize";
            this.PicMaximize.Size = new System.Drawing.Size(17, 16);
            this.PicMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMaximize.TabIndex = 1;
            this.PicMaximize.TabStop = false;
            this.PicMaximize.Click += new System.EventHandler(this.PicMaximize_Click);
            this.PicMaximize.MouseEnter += new System.EventHandler(this.PicMaximize_MouseEnter);
            this.PicMaximize.MouseLeave += new System.EventHandler(this.PicMaximize_MouseLeave);
            // 
            // MaximizeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PicMaximize);
            this.Name = "MaximizeButton";
            this.Size = new System.Drawing.Size(20, 20);
            this.Click += new System.EventHandler(this.PicMaximize_Click);
            this.MouseEnter += new System.EventHandler(this.PicMaximize_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PicMaximize_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PicMaximize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMaximize;
    }
}
