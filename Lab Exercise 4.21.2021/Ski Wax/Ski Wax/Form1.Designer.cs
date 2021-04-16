namespace Ski_Wax
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
            this.btnWax = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cboConditions = new System.Windows.Forms.ComboBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWax
            // 
            this.btnWax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWax.Location = new System.Drawing.Point(280, 248);
            this.btnWax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWax.Name = "btnWax";
            this.btnWax.Size = new System.Drawing.Size(168, 78);
            this.btnWax.TabIndex = 11;
            this.btnWax.Text = "Determine Wax";
            this.btnWax.UseVisualStyleBackColor = true;
            this.btnWax.Click += new System.EventHandler(this.btnWax_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(44, 176);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 31);
            this.lblType.TabIndex = 10;
            // 
            // cboConditions
            // 
            this.cboConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConditions.FormattingEnabled = true;
            this.cboConditions.Items.AddRange(new object[] {
            "Powder",
            "Firm",
            "Crusty"});
            this.cboConditions.Location = new System.Drawing.Point(288, 96);
            this.cboConditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboConditions.Name = "cboConditions";
            this.cboConditions.Size = new System.Drawing.Size(160, 38);
            this.cboConditions.TabIndex = 9;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(240, 37);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(132, 37);
            this.txtTemperature.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(37, 100);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(218, 31);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Snow Conditions";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(169, 31);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Temperature";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(479, 248);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 78);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 349);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWax);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cboConditions);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ski Wax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnWax;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.ComboBox cboConditions;
        internal System.Windows.Forms.TextBox txtTemperature;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnReset;
    }
}

