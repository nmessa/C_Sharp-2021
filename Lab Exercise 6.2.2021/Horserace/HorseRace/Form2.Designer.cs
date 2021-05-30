namespace HorseRace
{
    partial class Form2
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.pbWinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(44, 322);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 25);
            this.lblWinner.TabIndex = 2;
            // 
            // pbWinner
            // 
            this.pbWinner.Location = new System.Drawing.Point(12, 12);
            this.pbWinner.Name = "pbWinner";
            this.pbWinner.Size = new System.Drawing.Size(357, 288);
            this.pbWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWinner.TabIndex = 3;
            this.pbWinner.TabStop = false;
            this.pbWinner.Click += new System.EventHandler(this.pbWinner_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 364);
            this.Controls.Add(this.pbWinner);
            this.Controls.Add(this.lblWinner);
            this.Name = "Form2";
            this.Text = "Winner\'s Circle";
            ((System.ComponentModel.ISupportInitialize)(this.pbWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblWinner;
        internal System.Windows.Forms.PictureBox pbWinner;
    }
}