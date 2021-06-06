namespace Photo_Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnArrow = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(30, 95);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(56, 64);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPhoto.TabIndex = 12;
            this.picPhoto.TabStop = false;
            // 
            // btnArrow
            // 
            this.btnArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnArrow.Image")));
            this.btnArrow.Location = new System.Drawing.Point(246, 23);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(48, 48);
            this.btnArrow.TabIndex = 11;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.Location = new System.Drawing.Point(30, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 32);
            this.lblName.TabIndex = 10;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 462);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnArrow);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Photo Album";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picPhoto;
        internal System.Windows.Forms.Button btnArrow;
        internal System.Windows.Forms.Label lblName;
    }
}

