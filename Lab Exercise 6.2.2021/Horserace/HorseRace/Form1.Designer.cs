namespace HorseRace
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
            this.lblHorse3 = new System.Windows.Forms.Label();
            this.lblHorse2 = new System.Windows.Forms.Label();
            this.lblHorse1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWager = new System.Windows.Forms.TextBox();
            this.lblBankRoll = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.rbHorse3 = new System.Windows.Forms.RadioButton();
            this.rbHorse2 = new System.Windows.Forms.RadioButton();
            this.rbHorse1 = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHorse3
            // 
            this.lblHorse3.Image = global::HorseRace.Properties.Resources.horse3;
            this.lblHorse3.Location = new System.Drawing.Point(20, 319);
            this.lblHorse3.Name = "lblHorse3";
            this.lblHorse3.Size = new System.Drawing.Size(107, 84);
            this.lblHorse3.TabIndex = 11;
            // 
            // lblHorse2
            // 
            this.lblHorse2.Image = global::HorseRace.Properties.Resources.horse2;
            this.lblHorse2.Location = new System.Drawing.Point(20, 228);
            this.lblHorse2.Name = "lblHorse2";
            this.lblHorse2.Size = new System.Drawing.Size(107, 80);
            this.lblHorse2.TabIndex = 10;
            // 
            // lblHorse1
            // 
            this.lblHorse1.Image = global::HorseRace.Properties.Resources.horse1;
            this.lblHorse1.Location = new System.Drawing.Point(20, 130);
            this.lblHorse1.Name = "lblHorse1";
            this.lblHorse1.Size = new System.Drawing.Size(107, 83);
            this.lblHorse1.TabIndex = 9;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtWager);
            this.GroupBox1.Controls.Add(this.lblBankRoll);
            this.GroupBox1.Controls.Add(this.lblBank);
            this.GroupBox1.Controls.Add(this.lblAmount);
            this.GroupBox1.Controls.Add(this.rbHorse3);
            this.GroupBox1.Controls.Add(this.rbHorse2);
            this.GroupBox1.Controls.Add(this.rbHorse1);
            this.GroupBox1.Location = new System.Drawing.Point(154, 10);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(249, 97);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Wager Board";
            // 
            // txtWager
            // 
            this.txtWager.Location = new System.Drawing.Point(137, 29);
            this.txtWager.Name = "txtWager";
            this.txtWager.Size = new System.Drawing.Size(70, 20);
            this.txtWager.TabIndex = 6;
            this.txtWager.TextChanged += new System.EventHandler(this.txtWager_TextChanged);
            // 
            // lblBankRoll
            // 
            this.lblBankRoll.AutoSize = true;
            this.lblBankRoll.BackColor = System.Drawing.Color.White;
            this.lblBankRoll.Location = new System.Drawing.Point(149, 68);
            this.lblBankRoll.Name = "lblBankRoll";
            this.lblBankRoll.Size = new System.Drawing.Size(31, 13);
            this.lblBankRoll.TabIndex = 5;
            this.lblBankRoll.Text = "1000";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(88, 68);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(45, 13);
            this.lblBank.TabIndex = 4;
            this.lblBank.Text = "Bankroll";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(88, 32);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // rbHorse3
            // 
            this.rbHorse3.AutoSize = true;
            this.rbHorse3.Location = new System.Drawing.Point(6, 74);
            this.rbHorse3.Name = "rbHorse3";
            this.rbHorse3.Size = new System.Drawing.Size(62, 17);
            this.rbHorse3.TabIndex = 2;
            this.rbHorse3.TabStop = true;
            this.rbHorse3.Text = "Horse 3";
            this.rbHorse3.UseVisualStyleBackColor = true;
            // 
            // rbHorse2
            // 
            this.rbHorse2.AutoSize = true;
            this.rbHorse2.Location = new System.Drawing.Point(6, 46);
            this.rbHorse2.Name = "rbHorse2";
            this.rbHorse2.Size = new System.Drawing.Size(62, 17);
            this.rbHorse2.TabIndex = 1;
            this.rbHorse2.TabStop = true;
            this.rbHorse2.Text = "Horse 2";
            this.rbHorse2.UseVisualStyleBackColor = true;
            // 
            // rbHorse1
            // 
            this.rbHorse1.AutoSize = true;
            this.rbHorse1.Location = new System.Drawing.Point(6, 23);
            this.rbHorse1.Name = "rbHorse1";
            this.rbHorse1.Size = new System.Drawing.Size(62, 17);
            this.rbHorse1.TabIndex = 0;
            this.rbHorse1.TabStop = true;
            this.rbHorse1.Text = "Horse 1";
            this.rbHorse1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(23, 27);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(75, 23);
            this.btnRace.TabIndex = 6;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HorseRace.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.lblHorse3);
            this.Controls.Add(this.lblHorse2);
            this.Controls.Add(this.lblHorse1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRace);
            this.Name = "Form1";
            this.Text = "Hayburners";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblHorse3;
        internal System.Windows.Forms.Label lblHorse2;
        internal System.Windows.Forms.Label lblHorse1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtWager;
        internal System.Windows.Forms.Label lblBankRoll;
        internal System.Windows.Forms.Label lblBank;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.RadioButton rbHorse3;
        internal System.Windows.Forms.RadioButton rbHorse2;
        internal System.Windows.Forms.RadioButton rbHorse1;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

