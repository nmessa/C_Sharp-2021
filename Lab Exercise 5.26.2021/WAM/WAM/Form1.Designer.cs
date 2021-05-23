namespace WAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMoles = new System.Windows.Forms.Label();
            this.pbGrass = new System.Windows.Forms.PictureBox();
            this.pbMole = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoles
            // 
            this.lblMoles.AutoSize = true;
            this.lblMoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoles.Location = new System.Drawing.Point(347, 502);
            this.lblMoles.Name = "lblMoles";
            this.lblMoles.Size = new System.Drawing.Size(221, 31);
            this.lblMoles.TabIndex = 25;
            this.lblMoles.Text = "Moles Whacked: ";
            // 
            // pbGrass
            // 
            this.pbGrass.Image = global::WAM.Properties.Resources.grass;
            this.pbGrass.Location = new System.Drawing.Point(15, 12);
            this.pbGrass.Name = "pbGrass";
            this.pbGrass.Size = new System.Drawing.Size(37, 31);
            this.pbGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrass.TabIndex = 24;
            this.pbGrass.TabStop = false;
            this.pbGrass.Visible = false;
            // 
            // pbMole
            // 
            this.pbMole.BackColor = System.Drawing.Color.Transparent;
            this.pbMole.Image = global::WAM.Properties.Resources.whack_a_mole;
            this.pbMole.Location = new System.Drawing.Point(58, 12);
            this.pbMole.Name = "pbMole";
            this.pbMole.Size = new System.Drawing.Size(39, 30);
            this.pbMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMole.TabIndex = 23;
            this.pbMole.TabStop = false;
            this.pbMole.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(103, 502);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 22;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.Image = global::WAM.Properties.Resources.grass;
            this.pb9.Location = new System.Drawing.Point(391, 394);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(53, 51);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 21;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(232, 394);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(53, 51);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 20;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(82, 394);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(53, 51);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 19;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.Image = ((System.Drawing.Image)(resources.GetObject("pb6.Image")));
            this.pb6.Location = new System.Drawing.Point(541, 262);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(53, 51);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 18;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(382, 262);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(53, 51);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 17;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(232, 262);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(53, 51);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Image = global::WAM.Properties.Resources.grass;
            this.pb3.Location = new System.Drawing.Point(412, 131);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(53, 51);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 15;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(253, 131);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(53, 51);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = global::WAM.Properties.Resources.grass;
            this.pb1.Location = new System.Drawing.Point(103, 131);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(53, 51);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WAM.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(618, 553);
            this.Controls.Add(this.lblMoles);
            this.Controls.Add(this.pbGrass);
            this.Controls.Add(this.pbMole);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMoles;
        internal System.Windows.Forms.PictureBox pbGrass;
        internal System.Windows.Forms.PictureBox pbMole;
        internal System.Windows.Forms.Button btnPlay;
        internal System.Windows.Forms.PictureBox pb9;
        internal System.Windows.Forms.PictureBox pb8;
        internal System.Windows.Forms.PictureBox pb7;
        internal System.Windows.Forms.PictureBox pb6;
        internal System.Windows.Forms.PictureBox pb5;
        internal System.Windows.Forms.PictureBox pb4;
        internal System.Windows.Forms.PictureBox pb3;
        internal System.Windows.Forms.PictureBox pb2;
        internal System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

