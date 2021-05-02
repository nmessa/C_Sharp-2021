namespace Mandelbrot
{
    partial class Form1
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(0, 27);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(413, 282);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScaleToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(421, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ScaleToolStripMenuItem
            // 
            this.ScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullScaleToolStripMenuItem});
            this.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem";
            this.ScaleToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ScaleToolStripMenuItem.Text = "Scale";
            // 
            // FullScaleToolStripMenuItem
            // 
            this.FullScaleToolStripMenuItem.Name = "FullScaleToolStripMenuItem";
            this.FullScaleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.FullScaleToolStripMenuItem.Text = "Full Scale";
            this.FullScaleToolStripMenuItem.Click += new System.EventHandler(this.FullScaleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 309);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Mandelbrot Zoomer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ScaleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FullScaleToolStripMenuItem;
    }
}

