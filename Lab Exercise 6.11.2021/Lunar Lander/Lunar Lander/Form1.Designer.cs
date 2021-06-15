namespace Lunar_Lander
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
            this.grpSatus = new System.Windows.Forms.GroupBox();
            this.btnBurn = new System.Windows.Forms.Button();
            this.nudBurn = new System.Windows.Forms.NumericUpDown();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlSky = new System.Windows.Forms.Panel();
            this.picRocket = new System.Windows.Forms.PictureBox();
            this.tmrFalling = new System.Windows.Forms.Timer(this.components);
            this.grpSatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurn)).BeginInit();
            this.pnlChoice.SuspendLayout();
            this.pnlSky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSatus
            // 
            this.grpSatus.BackColor = System.Drawing.Color.Red;
            this.grpSatus.Controls.Add(this.btnBurn);
            this.grpSatus.Controls.Add(this.nudBurn);
            this.grpSatus.Controls.Add(this.lblFuel);
            this.grpSatus.Controls.Add(this.lblSpeed);
            this.grpSatus.Controls.Add(this.lblAltitude);
            this.grpSatus.Controls.Add(this.lblTime);
            this.grpSatus.Controls.Add(this.label5);
            this.grpSatus.Controls.Add(this.label4);
            this.grpSatus.Controls.Add(this.label3);
            this.grpSatus.Controls.Add(this.label2);
            this.grpSatus.Controls.Add(this.label1);
            this.grpSatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSatus.Location = new System.Drawing.Point(19, 11);
            this.grpSatus.Name = "grpSatus";
            this.grpSatus.Size = new System.Drawing.Size(317, 375);
            this.grpSatus.TabIndex = 0;
            this.grpSatus.TabStop = false;
            this.grpSatus.Text = "Lunar Module Status";
            // 
            // btnBurn
            // 
            this.btnBurn.Location = new System.Drawing.Point(71, 301);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(193, 50);
            this.btnBurn.TabIndex = 10;
            this.btnBurn.Text = "Perform Burn";
            this.btnBurn.UseVisualStyleBackColor = true;
            this.btnBurn.Click += new System.EventHandler(this.btnBurn_Click);
            // 
            // nudBurn
            // 
            this.nudBurn.Location = new System.Drawing.Point(167, 245);
            this.nudBurn.Name = "nudBurn";
            this.nudBurn.Size = new System.Drawing.Size(120, 31);
            this.nudBurn.TabIndex = 9;
            // 
            // lblFuel
            // 
            this.lblFuel.BackColor = System.Drawing.Color.White;
            this.lblFuel.Location = new System.Drawing.Point(165, 194);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(122, 33);
            this.lblFuel.TabIndex = 8;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BackColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(165, 143);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(122, 33);
            this.lblSpeed.TabIndex = 7;
            // 
            // lblAltitude
            // 
            this.lblAltitude.BackColor = System.Drawing.Color.White;
            this.lblAltitude.Location = new System.Drawing.Point(165, 92);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(122, 33);
            this.lblAltitude.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(165, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 33);
            this.lblTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Burn Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fuel (lbs)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed (ft/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altitude (ft)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time (s)";
            // 
            // pnlChoice
            // 
            this.pnlChoice.BackColor = System.Drawing.Color.Red;
            this.pnlChoice.Controls.Add(this.btnExit);
            this.pnlChoice.Controls.Add(this.btnNew);
            this.pnlChoice.Location = new System.Drawing.Point(19, 392);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(317, 97);
            this.pnlChoice.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(183, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 59);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(32, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 59);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(19, 500);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(317, 305);
            this.lblMessage.TabIndex = 2;
            // 
            // pnlSky
            // 
            this.pnlSky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSky.BackgroundImage")));
            this.pnlSky.Controls.Add(this.picRocket);
            this.pnlSky.Location = new System.Drawing.Point(359, 21);
            this.pnlSky.Name = "pnlSky";
            this.pnlSky.Size = new System.Drawing.Size(320, 793);
            this.pnlSky.TabIndex = 3;
            // 
            // picRocket
            // 
            this.picRocket.BackColor = System.Drawing.Color.Black;
            this.picRocket.Image = ((System.Drawing.Image)(resources.GetObject("picRocket.Image")));
            this.picRocket.Location = new System.Drawing.Point(97, 0);
            this.picRocket.Name = "picRocket";
            this.picRocket.Size = new System.Drawing.Size(98, 102);
            this.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRocket.TabIndex = 4;
            this.picRocket.TabStop = false;
            // 
            // tmrFalling
            // 
            this.tmrFalling.Tick += new System.EventHandler(this.tmrFalling_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 826);
            this.Controls.Add(this.pnlSky);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlChoice);
            this.Controls.Add(this.grpSatus);
            this.Name = "Form1";
            this.Text = "Lunar Lander";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSatus.ResumeLayout(false);
            this.grpSatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurn)).EndInit();
            this.pnlChoice.ResumeLayout(false);
            this.pnlSky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSatus;
        private System.Windows.Forms.Button btnBurn;
        private System.Windows.Forms.NumericUpDown nudBurn;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlSky;
        private System.Windows.Forms.PictureBox picRocket;
        private System.Windows.Forms.Timer tmrFalling;
    }
}

