namespace Flying_Bird
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
            this.btnSlow = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(244, 303);
            this.btnFast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(99, 23);
            this.btnFast.TabIndex = 5;
            this.btnFast.Text = "Speed Up";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(115, 303);
            this.btnSlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(91, 23);
            this.btnSlow.TabIndex = 4;
            this.btnSlow.Text = "Slow Down";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImage.Location = new System.Drawing.Point(37, 27);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(373, 238);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(456, 348);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Jonathan Livingston Seagull";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnFast;
        internal System.Windows.Forms.Button btnSlow;
        internal System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Timer tmrChangeImage;
    }
}

