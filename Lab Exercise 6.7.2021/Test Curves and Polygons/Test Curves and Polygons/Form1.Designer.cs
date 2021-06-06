namespace Test_Curves_and_Polygons
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
            this.lblFillPolygon = new System.Windows.Forms.Label();
            this.lblDrawPolygon = new System.Windows.Forms.Label();
            this.lblFillClosedCurve = new System.Windows.Forms.Label();
            this.lblDrawClosedCurve = new System.Windows.Forms.Label();
            this.lblDrawCurve = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFillPolygon
            // 
            this.lblFillPolygon.Location = new System.Drawing.Point(287, 145);
            this.lblFillPolygon.Name = "lblFillPolygon";
            this.lblFillPolygon.Size = new System.Drawing.Size(150, 100);
            this.lblFillPolygon.TabIndex = 16;
            this.lblFillPolygon.Text = "FillPolygon";
            // 
            // lblDrawPolygon
            // 
            this.lblDrawPolygon.Location = new System.Drawing.Point(111, 145);
            this.lblDrawPolygon.Name = "lblDrawPolygon";
            this.lblDrawPolygon.Size = new System.Drawing.Size(150, 100);
            this.lblDrawPolygon.TabIndex = 15;
            this.lblDrawPolygon.Text = "DrawPolygon";
            // 
            // lblFillClosedCurve
            // 
            this.lblFillClosedCurve.Location = new System.Drawing.Point(375, 25);
            this.lblFillClosedCurve.Name = "lblFillClosedCurve";
            this.lblFillClosedCurve.Size = new System.Drawing.Size(150, 100);
            this.lblFillClosedCurve.TabIndex = 14;
            this.lblFillClosedCurve.Text = "FillClosedCurve";
            // 
            // lblDrawClosedCurve
            // 
            this.lblDrawClosedCurve.Location = new System.Drawing.Point(199, 25);
            this.lblDrawClosedCurve.Name = "lblDrawClosedCurve";
            this.lblDrawClosedCurve.Size = new System.Drawing.Size(150, 100);
            this.lblDrawClosedCurve.TabIndex = 13;
            this.lblDrawClosedCurve.Text = "DrawClosedCurve";
            // 
            // lblDrawCurve
            // 
            this.lblDrawCurve.Location = new System.Drawing.Point(23, 25);
            this.lblDrawCurve.Name = "lblDrawCurve";
            this.lblDrawCurve.Size = new System.Drawing.Size(150, 100);
            this.lblDrawCurve.TabIndex = 12;
            this.lblDrawCurve.Text = "DrawCurve";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(237, 265);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "Draw";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 318);
            this.Controls.Add(this.lblFillPolygon);
            this.Controls.Add(this.lblDrawPolygon);
            this.Controls.Add(this.lblFillClosedCurve);
            this.Controls.Add(this.lblDrawClosedCurve);
            this.Controls.Add(this.lblDrawCurve);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Test Curves adn Polygons";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblFillPolygon;
        internal System.Windows.Forms.Label lblDrawPolygon;
        internal System.Windows.Forms.Label lblFillClosedCurve;
        internal System.Windows.Forms.Label lblDrawClosedCurve;
        internal System.Windows.Forms.Label lblDrawCurve;
        internal System.Windows.Forms.Button btnDraw;
    }
}

