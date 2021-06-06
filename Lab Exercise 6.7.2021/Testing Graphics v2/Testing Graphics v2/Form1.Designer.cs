namespace Testing_Graphics_v2
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
            this.btnDrawHere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrawHere
            // 
            this.btnDrawHere.Location = new System.Drawing.Point(197, 237);
            this.btnDrawHere.Name = "btnDrawHere";
            this.btnDrawHere.Size = new System.Drawing.Size(75, 23);
            this.btnDrawHere.TabIndex = 1;
            this.btnDrawHere.Text = "Draw Here";
            this.btnDrawHere.Click += new System.EventHandler(this.btnDrawHere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDrawHere);
            this.Name = "Form1";
            this.Text = "Testing Graphics Version 2";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnDrawHere;
    }
}

