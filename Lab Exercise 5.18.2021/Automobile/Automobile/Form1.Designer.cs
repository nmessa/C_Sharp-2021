namespace Automobile
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trkHeading = new System.Windows.Forms.TrackBar();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trkHP = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(437, 262);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(0, 13);
            this.lblHeading.TabIndex = 25;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(437, 212);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblSpeed.TabIndex = 24;
            // 
            // trkHeading
            // 
            this.trkHeading.Location = new System.Drawing.Point(181, 255);
            this.trkHeading.Maximum = 359;
            this.trkHeading.Name = "trkHeading";
            this.trkHeading.Size = new System.Drawing.Size(241, 45);
            this.trkHeading.TabIndex = 23;
            this.trkHeading.Scroll += new System.EventHandler(this.trkHeading_Scroll);
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(181, 201);
            this.trkSpeed.Maximum = 100;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(241, 45);
            this.trkSpeed.TabIndex = 22;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // btnPaint
            // 
            this.btnPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.Location = new System.Drawing.Point(58, 105);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(120, 32);
            this.btnPaint.TabIndex = 21;
            this.btnPaint.Text = "Paint Car";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(38, 385);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(120, 57);
            this.btnBuild.TabIndex = 20;
            this.btnBuild.Text = "Build Car";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // cboMake
            // 
            this.cboMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Items.AddRange(new object[] {
            "Honda",
            "Toyota",
            "Ford",
            "Chevrolet",
            "Jaguar",
            "Ferrarri",
            "Maserati",
            "Lamborghini"});
            this.cboMake.Location = new System.Drawing.Point(157, 152);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(246, 33);
            this.cboMake.TabIndex = 19;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(53, 249);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 25);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Heading";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(53, 201);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 25);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Speed";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(53, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 25);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Make";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(151, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 31);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Car Builder";
            // 
            // trkHP
            // 
            this.trkHP.Location = new System.Drawing.Point(181, 306);
            this.trkHP.Maximum = 1000;
            this.trkHP.Name = "trkHP";
            this.trkHP.Size = new System.Drawing.Size(241, 45);
            this.trkHP.TabIndex = 27;
            this.trkHP.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Horsepower";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(437, 313);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 13);
            this.lblHP.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 468);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.trkHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trkHeading);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Magic Car Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblHeading;
        internal System.Windows.Forms.Label lblSpeed;
        internal System.Windows.Forms.TrackBar trkHeading;
        internal System.Windows.Forms.TrackBar trkSpeed;
        internal System.Windows.Forms.Button btnPaint;
        internal System.Windows.Forms.Button btnBuild;
        internal System.Windows.Forms.ComboBox cboMake;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal System.Windows.Forms.TrackBar trkHP;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblHP;
    }
}

