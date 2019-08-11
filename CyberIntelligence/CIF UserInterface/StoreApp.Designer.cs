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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(60, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 20);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Application Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(62, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 88);
            this.label2.TabIndex = 31;
            this.label2.Text = "Application Description bla bla bla";
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(0, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(300, 1);
            this.BorderTop.TabIndex = 32;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 119);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(300, 1);
            this.BorderBottom.TabIndex = 33;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 1);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 118);
            this.BorderLeft.TabIndex = 34;
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(299, 1);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 118);
            this.BorderRight.TabIndex = 35;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "StoreApp";
            this.Size = new System.Drawing.Size(300, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderRight;
    }
}
