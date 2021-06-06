namespace Face
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
            this.btnWink = new System.Windows.Forms.Button();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.tmrWink = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWink
            // 
            this.btnWink.Enabled = false;
            this.btnWink.Location = new System.Drawing.Point(190, 27);
            this.btnWink.Name = "btnWink";
            this.btnWink.Size = new System.Drawing.Size(48, 23);
            this.btnWink.TabIndex = 7;
            this.btnWink.Text = "Wink";
            this.btnWink.Click += new System.EventHandler(this.btnWink_Click);
            // 
            // picFrame
            // 
            this.picFrame.Location = new System.Drawing.Point(46, 67);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(192, 168);
            this.picFrame.TabIndex = 6;
            this.picFrame.TabStop = false;
            // 
            // btnSad
            // 
            this.btnSad.Location = new System.Drawing.Point(118, 27);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(48, 23);
            this.btnSad.TabIndex = 5;
            this.btnSad.Text = "Sad";
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnHappy
            // 
            this.btnHappy.Location = new System.Drawing.Point(46, 27);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(48, 23);
            this.btnHappy.TabIndex = 4;
            this.btnHappy.Text = "Happy";
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // tmrWink
            // 
            this.tmrWink.Interval = 1000;
            this.tmrWink.Tick += new System.EventHandler(this.tmrWink_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnWink);
            this.Controls.Add(this.picFrame);
            this.Controls.Add(this.btnSad);
            this.Controls.Add(this.btnHappy);
            this.Name = "Form1";
            this.Text = "Face Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnWink;
        internal System.Windows.Forms.PictureBox picFrame;
        internal System.Windows.Forms.Button btnSad;
        internal System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Timer tmrWink;
    }
}

