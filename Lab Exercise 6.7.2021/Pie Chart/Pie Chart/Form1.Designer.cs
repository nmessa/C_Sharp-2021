namespace Pie_Chart
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
            this.lblPercentages = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.lblDrawing = new System.Windows.Forms.Label();
            this.txtValue4 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblValuesPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPercentages
            // 
            this.lblPercentages.Location = new System.Drawing.Point(227, 74);
            this.lblPercentages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentages.Name = "lblPercentages";
            this.lblPercentages.Size = new System.Drawing.Size(245, 30);
            this.lblPercentages.TabIndex = 15;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(51, 257);
            this.btnChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(73, 28);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Chart";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // lblDrawing
            // 
            this.lblDrawing.Location = new System.Drawing.Point(196, 113);
            this.lblDrawing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawing.Name = "lblDrawing";
            this.lblDrawing.Size = new System.Drawing.Size(187, 172);
            this.lblDrawing.TabIndex = 14;
            // 
            // txtValue4
            // 
            this.txtValue4.Location = new System.Drawing.Point(420, 34);
            this.txtValue4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(52, 22);
            this.txtValue4.TabIndex = 12;
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(356, 34);
            this.txtValue3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(52, 22);
            this.txtValue3.TabIndex = 11;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(292, 34);
            this.txtValue2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(52, 22);
            this.txtValue2.TabIndex = 10;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(228, 34);
            this.txtValue1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(52, 22);
            this.txtValue1.TabIndex = 9;
            // 
            // lblValuesPrompt
            // 
            this.lblValuesPrompt.Location = new System.Drawing.Point(47, 34);
            this.lblValuesPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValuesPrompt.Name = "lblValuesPrompt";
            this.lblValuesPrompt.Size = new System.Drawing.Size(128, 20);
            this.lblValuesPrompt.TabIndex = 8;
            this.lblValuesPrompt.Text = "Enter four values:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 303);
            this.Controls.Add(this.lblPercentages);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.lblDrawing);
            this.Controls.Add(this.txtValue4);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblValuesPrompt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pie Chart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPercentages;
        internal System.Windows.Forms.Button btnChart;
        internal System.Windows.Forms.Label lblDrawing;
        internal System.Windows.Forms.TextBox txtValue4;
        internal System.Windows.Forms.TextBox txtValue3;
        internal System.Windows.Forms.TextBox txtValue2;
        internal System.Windows.Forms.TextBox txtValue1;
        internal System.Windows.Forms.Label lblValuesPrompt;
    }
}

