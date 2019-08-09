namespace CIF_UserInterface
{
    partial class TaskbarApp
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
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.BottomLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(41, 39);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            this.iconBox.Click += new System.EventHandler(this.LocalEventHandler);
            this.iconBox.MouseEnter += new System.EventHandler(this.TaskbarAppHover);
            this.iconBox.MouseLeave += new System.EventHandler(this.TaskbarAppUnHover);
            // 
            // BottomLine
            // 
            this.BottomLine.BackColor = System.Drawing.Color.White;
            this.BottomLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLine.Location = new System.Drawing.Point(0, 39);
            this.BottomLine.Name = "BottomLine";
            this.BottomLine.Size = new System.Drawing.Size(41, 2);
            this.BottomLine.TabIndex = 2;
            this.BottomLine.Click += new System.EventHandler(this.LocalEventHandler);
            this.BottomLine.MouseEnter += new System.EventHandler(this.TaskbarAppHover);
            this.BottomLine.MouseLeave += new System.EventHandler(this.TaskbarAppUnHover);
            // 
            // TaskbarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.BottomLine);
            this.Name = "TaskbarApp";
            this.Size = new System.Drawing.Size(41, 41);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Panel BottomLine;
    }
}
