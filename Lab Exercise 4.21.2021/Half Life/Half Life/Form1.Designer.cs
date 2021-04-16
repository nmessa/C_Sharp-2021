namespace Half_Life
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHalfLife = new System.Windows.Forms.TextBox();
            this.txtInitialCount = new System.Windows.Forms.TextBox();
            this.txtFinalCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAge = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Halflife";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Count Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Count Rate";
            // 
            // txtHalfLife
            // 
            this.txtHalfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHalfLife.Location = new System.Drawing.Point(144, 40);
            this.txtHalfLife.Name = "txtHalfLife";
            this.txtHalfLife.Size = new System.Drawing.Size(116, 38);
            this.txtHalfLife.TabIndex = 0;
            // 
            // txtInitialCount
            // 
            this.txtInitialCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialCount.Location = new System.Drawing.Point(274, 92);
            this.txtInitialCount.Name = "txtInitialCount";
            this.txtInitialCount.Size = new System.Drawing.Size(160, 38);
            this.txtInitialCount.TabIndex = 1;
            // 
            // txtFinalCount
            // 
            this.txtFinalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalCount.Location = new System.Drawing.Point(276, 149);
            this.txtFinalCount.Name = "txtFinalCount";
            this.txtFinalCount.Size = new System.Drawing.Size(158, 38);
            this.txtFinalCount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age:";
            // 
            // btnAge
            // 
            this.btnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAge.Location = new System.Drawing.Point(168, 290);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(192, 59);
            this.btnAge.TabIndex = 3;
            this.btnAge.Text = "Calculate Age";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(113, 226);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 31);
            this.lblAge.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 381);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinalCount);
            this.Controls.Add(this.txtInitialCount);
            this.Controls.Add(this.txtHalfLife);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHalfLife;
        private System.Windows.Forms.TextBox txtInitialCount;
        private System.Windows.Forms.TextBox txtFinalCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Label lblAge;
    }
}

