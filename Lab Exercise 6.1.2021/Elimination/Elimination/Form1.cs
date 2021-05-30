//Elimonation Game
//Author: nmessa
//Date: 6.12.2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elimination
{
    public partial class Form1 : Form
    {
        //Global variables
        //Add code here



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void endGame()
        {
            //Add code here

                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Add code here


        }

        private void rollDie1()
        {
            //Add code here


        }

        private void rollDie2()
        {
            //Add code here


        }

        private bool rollOver()
        {
            if (rolls > 30)
                return true;
            else
                return false;
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            //Add code here


            switch (roll1)
            {
                //Add code here

                  
                
                
            } //end of switch roll1

            switch (roll2)
            {
               //Add code here


           
            }//end of switch roll2

            //Add code here


        } //end of btnDice_Click

        private void restore(int die)
        {
            //Add code here


        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            //Add code here

            switch (roll1 + roll2)
            {
                //Add code here



            } //end of switch (roll1 + roll2)

            //Add code here



        } //end of btnSum_Click
    }
}
