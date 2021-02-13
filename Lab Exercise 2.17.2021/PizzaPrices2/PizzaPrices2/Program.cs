//Lab Exercise 2.17.2021 Probelm 2b
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaPrices2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create 2 arrays of sizes and prices
            //Add code here


            //Declare variables
            string size, strCost, strTotal, strFinal;
            int index, number, discount;
            double cost, total, final;

            //Get size of pizza
            //Add code here


            //Find the index of the size
            //Add code here


            //Get number of pizza's
            //Add code here


            if (index != -1)  //Valid size entered
            {
                //get cost of 1 pizza
                //Add code here


                //calculate total cost
                //Add code here


                //Find discount
                switch (number)
                {
                    //Add code here

                }

                //Calculate final cost
                //Add code here


                //Convert cost, total, and final to currency strings
                //Add code here


                //Output report
                //Add code here



            }
            else  //Invalid size entered
            {
                //Add code here

            }
        }
    }
}

//Sample Output
//Enter the size of the pizza(S, M, L, of X): L
//How many pizza's do you wish? 4
//Your L pizza normally costs $12.50
//The total would normally be $50.00
//Because you ordered 4, your discount is 15%
//For a final total of $42.50