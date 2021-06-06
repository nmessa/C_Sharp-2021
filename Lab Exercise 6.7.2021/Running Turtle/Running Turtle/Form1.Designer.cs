namespace Running_Turtle
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
            this.components = new System.ComponentModel.Container();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(268, 263);
            this.btnFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(100, 28);
            this.btnFast.TabIndex = 7;
            this.btnFast.Text = "Fast";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(136, 263);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(100, 28);
            this.btnMedium.TabIndex = 6;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(11, 263);
            this.btnSlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(100, 28);
            this.btnSlow.TabIndex = 5;
            this.btnSlow.Text = "Slow";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImage.Location = new System.Drawing.Point(61, 32);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(187, 144);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 300;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Turtle Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFast;
        internal System.Windows.Forms.Button btnMedium;
        internal System.Windows.Forms.Button btnSlow;
        internal System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Timer tmrChangeImage;
    }
}

