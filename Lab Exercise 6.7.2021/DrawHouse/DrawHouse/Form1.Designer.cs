namespace DrawHouse
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
            this.lblDraw = new System.Windows.Forms.Label();
            this.grpRoof = new System.Windows.Forms.GroupBox();
            this.radPurpleRoof = new System.Windows.Forms.RadioButton();
            this.radBrownRoof = new System.Windows.Forms.RadioButton();
            this.grpDoor = new System.Windows.Forms.GroupBox();
            this.radWhiteDoor = new System.Windows.Forms.RadioButton();
            this.radBlackDoor = new System.Windows.Forms.RadioButton();
            this.grpSky = new System.Windows.Forms.GroupBox();
            this.radCyanSky = new System.Windows.Forms.RadioButton();
            this.radBlueSky = new System.Windows.Forms.RadioButton();
            this.grpSun = new System.Windows.Forms.GroupBox();
            this.radYellowSun = new System.Windows.Forms.RadioButton();
            this.radRedSun = new System.Windows.Forms.RadioButton();
            this.grpHouse = new System.Windows.Forms.GroupBox();
            this.radMagentaHouse = new System.Windows.Forms.RadioButton();
            this.radGreenHouse = new System.Windows.Forms.RadioButton();
            this.grpRoof.SuspendLayout();
            this.grpDoor.SuspendLayout();
            this.grpSky.SuspendLayout();
            this.grpSun.SuspendLayout();
            this.grpHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDraw
            // 
            this.lblDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDraw.Location = new System.Drawing.Point(143, 30);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(264, 336);
            this.lblDraw.TabIndex = 12;
            // 
            // grpRoof
            // 
            this.grpRoof.BackColor = System.Drawing.Color.Transparent;
            this.grpRoof.Controls.Add(this.radPurpleRoof);
            this.grpRoof.Controls.Add(this.radBrownRoof);
            this.grpRoof.Location = new System.Drawing.Point(15, 166);
            this.grpRoof.Name = "grpRoof";
            this.grpRoof.Size = new System.Drawing.Size(112, 64);
            this.grpRoof.TabIndex = 11;
            this.grpRoof.TabStop = false;
            this.grpRoof.Text = "Roof";
            // 
            // radPurpleRoof
            // 
            this.radPurpleRoof.Location = new System.Drawing.Point(8, 40);
            this.radPurpleRoof.Name = "radPurpleRoof";
            this.radPurpleRoof.Size = new System.Drawing.Size(72, 16);
            this.radPurpleRoof.TabIndex = 1;
            this.radPurpleRoof.Tag = "6";
            this.radPurpleRoof.Text = "Purple";
            this.radPurpleRoof.CheckedChanged += new System.EventHandler(this.radPurpleRoof_CheckedChanged);
            // 
            // radBrownRoof
            // 
            this.radBrownRoof.Location = new System.Drawing.Point(8, 16);
            this.radBrownRoof.Name = "radBrownRoof";
            this.radBrownRoof.Size = new System.Drawing.Size(56, 16);
            this.radBrownRoof.TabIndex = 0;
            this.radBrownRoof.Tag = "5";
            this.radBrownRoof.Text = "Brown";
            this.radBrownRoof.CheckedChanged += new System.EventHandler(this.radBrownRoof_CheckedChanged);
            // 
            // grpDoor
            // 
            this.grpDoor.BackColor = System.Drawing.Color.Transparent;
            this.grpDoor.Controls.Add(this.radWhiteDoor);
            this.grpDoor.Controls.Add(this.radBlackDoor);
            this.grpDoor.Location = new System.Drawing.Point(15, 310);
            this.grpDoor.Name = "grpDoor";
            this.grpDoor.Size = new System.Drawing.Size(112, 64);
            this.grpDoor.TabIndex = 10;
            this.grpDoor.TabStop = false;
            this.grpDoor.Text = "Door";
            // 
            // radWhiteDoor
            // 
            this.radWhiteDoor.Location = new System.Drawing.Point(8, 40);
            this.radWhiteDoor.Name = "radWhiteDoor";
            this.radWhiteDoor.Size = new System.Drawing.Size(72, 16);
            this.radWhiteDoor.TabIndex = 1;
            this.radWhiteDoor.Tag = "10";
            this.radWhiteDoor.Text = "White";
            this.radWhiteDoor.CheckedChanged += new System.EventHandler(this.radWhiteDoor_CheckedChanged);
            // 
            // radBlackDoor
            // 
            this.radBlackDoor.Location = new System.Drawing.Point(8, 16);
            this.radBlackDoor.Name = "radBlackDoor";
            this.radBlackDoor.Size = new System.Drawing.Size(80, 16);
            this.radBlackDoor.TabIndex = 0;
            this.radBlackDoor.Tag = "9";
            this.radBlackDoor.Text = "Black";
            this.radBlackDoor.CheckedChanged += new System.EventHandler(this.radBlackDoor_CheckedChanged);
            // 
            // grpSky
            // 
            this.grpSky.BackColor = System.Drawing.Color.Transparent;
            this.grpSky.Controls.Add(this.radCyanSky);
            this.grpSky.Controls.Add(this.radBlueSky);
            this.grpSky.Location = new System.Drawing.Point(15, 22);
            this.grpSky.Name = "grpSky";
            this.grpSky.Size = new System.Drawing.Size(112, 64);
            this.grpSky.TabIndex = 9;
            this.grpSky.TabStop = false;
            this.grpSky.Text = "Sky";
            // 
            // radCyanSky
            // 
            this.radCyanSky.Location = new System.Drawing.Point(8, 40);
            this.radCyanSky.Name = "radCyanSky";
            this.radCyanSky.Size = new System.Drawing.Size(96, 16);
            this.radCyanSky.TabIndex = 1;
            this.radCyanSky.Tag = "2";
            this.radCyanSky.Text = "Light Sky Blue";
            this.radCyanSky.CheckedChanged += new System.EventHandler(this.radCyanSky_CheckedChanged);
            // 
            // radBlueSky
            // 
            this.radBlueSky.Location = new System.Drawing.Point(8, 16);
            this.radBlueSky.Name = "radBlueSky";
            this.radBlueSky.Size = new System.Drawing.Size(104, 16);
            this.radBlueSky.TabIndex = 0;
            this.radBlueSky.Tag = "1";
            this.radBlueSky.Text = "Deep Sky Blue";
            this.radBlueSky.CheckedChanged += new System.EventHandler(this.radBlueSky_CheckedChanged);
            // 
            // grpSun
            // 
            this.grpSun.BackColor = System.Drawing.Color.Transparent;
            this.grpSun.Controls.Add(this.radYellowSun);
            this.grpSun.Controls.Add(this.radRedSun);
            this.grpSun.Location = new System.Drawing.Point(15, 94);
            this.grpSun.Name = "grpSun";
            this.grpSun.Size = new System.Drawing.Size(112, 64);
            this.grpSun.TabIndex = 8;
            this.grpSun.TabStop = false;
            this.grpSun.Text = "Sun";
            // 
            // radYellowSun
            // 
            this.radYellowSun.Location = new System.Drawing.Point(8, 40);
            this.radYellowSun.Name = "radYellowSun";
            this.radYellowSun.Size = new System.Drawing.Size(72, 16);
            this.radYellowSun.TabIndex = 1;
            this.radYellowSun.Tag = "4";
            this.radYellowSun.Text = "Yellow";
            this.radYellowSun.CheckedChanged += new System.EventHandler(this.radYellowSun_CheckedChanged);
            // 
            // radRedSun
            // 
            this.radRedSun.Location = new System.Drawing.Point(8, 16);
            this.radRedSun.Name = "radRedSun";
            this.radRedSun.Size = new System.Drawing.Size(56, 16);
            this.radRedSun.TabIndex = 0;
            this.radRedSun.Tag = "3";
            this.radRedSun.Text = "Red";
            this.radRedSun.CheckedChanged += new System.EventHandler(this.radRedSun_CheckedChanged);
            // 
            // grpHouse
            // 
            this.grpHouse.BackColor = System.Drawing.Color.Transparent;
            this.grpHouse.Controls.Add(this.radMagentaHouse);
            this.grpHouse.Controls.Add(this.radGreenHouse);
            this.grpHouse.Location = new System.Drawing.Point(15, 238);
            this.grpHouse.Name = "grpHouse";
            this.grpHouse.Size = new System.Drawing.Size(112, 64);
            this.grpHouse.TabIndex = 7;
            this.grpHouse.TabStop = false;
            this.grpHouse.Text = "House";
            // 
            // radMagentaHouse
            // 
            this.radMagentaHouse.Location = new System.Drawing.Point(8, 40);
            this.radMagentaHouse.Name = "radMagentaHouse";
            this.radMagentaHouse.Size = new System.Drawing.Size(80, 16);
            this.radMagentaHouse.TabIndex = 1;
            this.radMagentaHouse.Tag = "8";
            this.radMagentaHouse.Text = "Slate Gray";
            this.radMagentaHouse.CheckedChanged += new System.EventHandler(this.radMagentaHouse_CheckedChanged);
            // 
            // radGreenHouse
            // 
            this.radGreenHouse.Location = new System.Drawing.Point(8, 16);
            this.radGreenHouse.Name = "radGreenHouse";
            this.radGreenHouse.Size = new System.Drawing.Size(56, 16);
            this.radGreenHouse.TabIndex = 0;
            this.radGreenHouse.Tag = "7";
            this.radGreenHouse.Text = "Olive";
            this.radGreenHouse.CheckedChanged += new System.EventHandler(this.radGreenHouse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.grpRoof);
            this.Controls.Add(this.grpDoor);
            this.Controls.Add(this.grpSky);
            this.Controls.Add(this.grpSun);
            this.Controls.Add(this.grpHouse);
            this.Name = "Form1";
            this.Text = "Draw House";
            this.grpRoof.ResumeLayout(false);
            this.grpDoor.ResumeLayout(false);
            this.grpSky.ResumeLayout(false);
            this.grpSun.ResumeLayout(false);
            this.grpHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblDraw;
        internal System.Windows.Forms.GroupBox grpRoof;
        internal System.Windows.Forms.RadioButton radPurpleRoof;
        internal System.Windows.Forms.RadioButton radBrownRoof;
        internal System.Windows.Forms.GroupBox grpDoor;
        internal System.Windows.Forms.RadioButton radWhiteDoor;
        internal System.Windows.Forms.RadioButton radBlackDoor;
        internal System.Windows.Forms.GroupBox grpSky;
        internal System.Windows.Forms.RadioButton radCyanSky;
        internal System.Windows.Forms.RadioButton radBlueSky;
        internal System.Windows.Forms.GroupBox grpSun;
        internal System.Windows.Forms.RadioButton radYellowSun;
        internal System.Windows.Forms.RadioButton radRedSun;
        internal System.Windows.Forms.GroupBox grpHouse;
        internal System.Windows.Forms.RadioButton radMagentaHouse;
        internal System.Windows.Forms.RadioButton radGreenHouse;
    }
}

