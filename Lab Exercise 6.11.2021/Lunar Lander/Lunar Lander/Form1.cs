//Lunar Lander Game
//Author: nmessa
//Date: 6/12/2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lunar_Lander
{
    public partial class Form1 : Form
    {
        //Declare global variables
        bool gameOver;
        double T, H, V, F, B, V1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create introductory message
            lblMessage.Text = "You are landing on the moon and have taken over" +
            "manual control of the lunar module." +
                "You are 500 feet above a good landing spot." + Environment.NewLine +
                "Good luck!";
            lblMessage.Text += lblMessage.Text + Environment.NewLine +
                ">>Click New Game To Start<<";
            btnNew.Focus();
        }

        //This event creates a new game
        private void btnNew_Click(object sender, EventArgs e)
        {
            gameOver = false;
            lblMessage.Text = "";
            nudBurn.Enabled = true;
            btnBurn.Enabled = true;
            btnNew.Enabled = false;
            btnExit.Text = "Stop";
            T = 0; //Time
            H = 500; //Altitude (feet)
            DrawRocket();
            V = 50; //Speed
            F = 120; //Fuel
            lblTime.Text = "0";
            lblAltitude.Text = "500";
            lblSpeed.Text = "50";
            lblFuel.Text = "120";
            nudBurn.Text = "0";
            nudBurn.Value = 0;
            nudBurn.Maximum = 30;
        }

        //This event either stops the game or exits the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Exit")
                this.Close();
            else
            {
                nudBurn.Enabled = false;
                btnBurn.Enabled = false;
                btnExit.Text = "Exit";
                btnNew.Enabled = true;
                if (!gameOver)
                    lblMessage.Text = "Game Stopped";
                btnNew.Focus();
            }
        }

        //This event executes an engine burn using the allocated amount of fuel
        private void btnBurn_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(nudBurn.Value);
            V1 = V - B + 5;
            F = F - B;
            H = H - 0.5 * (V + V1);
            if (H > 0)
            {
                DrawRocket();
                T = T + 1;
                V = V1;
                lblTime.Text = T.ToString("0");
                lblAltitude.Text = H.ToString("f1");
                lblSpeed.Text = V.ToString("0");
                lblFuel.Text = F.ToString("0");
                if (F > 0)
                {
                    if (F < 30)
                    {
                        if (Convert.ToDouble(nudBurn.Value) > F)
                            nudBurn.Value = Convert.ToInt32(F);
                        nudBurn.Maximum = Convert.ToInt32(F);
                    }
                }
                else
                {
                    B = 0;
                    nudBurn.Enabled = false;
                    btnBurn.Enabled = false;
                    lblMessage.Text = "Out of fuel!  In free-fall!";
                    lblMessage.Refresh();
                    tmrFalling.Enabled = true;
                }
            }
            else
            {
                nudBurn.Enabled = false;
                btnBurn.Enabled = false;
                Landed();
            }


        }


        //This event updates rocket ship parameters
        private void tmrFalling_Tick(object sender, EventArgs e)
        {
            V1 = V + 5;
            H = H - 0.5 * (V + V1);
            if (H <= 0)
            {
      	        H = 0;
      	        tmrFalling.Enabled = false;
      	        Landed();
            }
            else
            {
      	        T = T + tmrFalling.Interval / 1000;
      	        DrawRocket();
      	        V = V1;
      	        lblTime.Text = T.ToString("0");
      	        lblTime.Refresh();
      	        lblAltitude.Text = H.ToString("f1");
      	        lblAltitude.Refresh();
      	        lblSpeed.Text = V.ToString("0");
                lblSpeed.Refresh();
            }
        }

        //This method evaluates your landing
        private void Landed()
        {
            double D;

            //Final results
            gameOver = true;
            H = 0;
            DrawRocket();
            if (B != 5)
                D = (-V + Math.Sqrt(V * V + H * (10 - 2 * B))) / (5 - B);
            else
                D = H / V;
            
            V1 = V + (5 - B) * D;
            lblTime.Text = (T + D).ToString("f1");
            lblAltitude.Text = "0.0";
            lblSpeed.Text = V1.ToString("f1");
            lblFuel.Text = F.ToString("0");
            lblMessage.Text = "Touchdown at " + T.ToString("f2") + " seconds." + 
                Environment.NewLine;
            lblMessage.Text += "Landing velocity is " + V1.ToString("f2") + " ft/sec." +
                Environment.NewLine;
            lblMessage.Text +=  F.ToString("0") + " units of fuel remain." + 
                Environment.NewLine + Environment.NewLine;;
    
            if (V1 <= 2)
      	        lblMessage.Text += "Congratulations! A perfect landing!";
            else if ((Math.Abs(V1)) <= 10)
                lblMessage.Text += "You inflicted some craft damage. You are stranded until a rescue ship arrives.";
            else
      	        lblMessage.Text += "You blew it! " + 
                    "Condolences will be sent to the next of kin.";
            btnExit.PerformClick();
        }

        //This method updates the rocket position
        private void DrawRocket()
        {
            picRocket.Top = Convert.ToInt32((pnlSky.Height - picRocket.Height) * (1 - H / 500));
        }
    }
}
