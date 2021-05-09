namespace Structure_Demo_Windows
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
            this.btnDump = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(83, 138);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(110, 43);
            this.btnDump.TabIndex = 0;
            this.btnDump.Text = "Brain Dump";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(83, 64);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 43);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Amoeba";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDump);
            this.Name = "Form1";
            this.Text = "Amoeba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnCreate;
    }
}

