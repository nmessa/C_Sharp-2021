namespace Planet_Weight
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPlanet = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(27, 117);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 13);
            this.lblWeight.TabIndex = 11;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(162, 22);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(132, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Enter your weight on Earth";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Select your planet";
            // 
            // cboPlanet
            // 
            this.cboPlanet.FormattingEnabled = true;
            this.cboPlanet.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Moon",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto",
            "Eric Clapton",
            "Jerry Garcia"});
            this.cboPlanet.Location = new System.Drawing.Point(162, 64);
            this.cboPlanet.Name = "cboPlanet";
            this.cboPlanet.Size = new System.Drawing.Size(121, 21);
            this.cboPlanet.TabIndex = 8;
            this.cboPlanet.Text = "Earth";
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(41, 167);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 201);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboPlanet);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Weight on other planets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblWeight;
        internal System.Windows.Forms.TextBox txtWeight;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboPlanet;
        internal System.Windows.Forms.Button btnConvert;
    }
}

