//Lab Exercise 2.15.2021 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int drawers;
            char woodType;
            int cost;

            //Get the number of drawers the desk will have
            //Add code here


            //Get the type of wood the desk will have
            //Add code here


            //Call CalcCosts function to the cost of the desk based on number of 
            //drawers and type of wood which are passed as parameters
            //Add code here


            //Call the DisplayDesk function passing type of wood, number of drawers
            //and cost as parameters
            //Add code here

        }

        //This function gets the number of drawers and returns that value as an integer
        static int NumberOfDrawers()
        {
            int numDrawers;
            string userInput;
            //Add code here


            return numDrawers;
        }

        //This function gets the type of wood and returns that value as a char
        static char TypeOfWood()
        {
            string wood;
            //Add code here


        }

        //This function is passed the number of drawers ad type of wood as parameters
        //and returns cost of desk
        static int CalcCosts(int numDrawers, char woodType)
        {
            int cost;
            const int DRAWER_COST = 30;

            //Get base cost
            switch (woodType)
            {
                //Add code here

            }

            //Add drawer surcharge
            //Add code here


            return cost;
        }

        //This function displays desk information based on the parameters
        //passed to it (type of wood, number of drawers, and cost)
        static void DisplayDesk(char woodType, int numDrawers, int cost)
        {
            string wood = "";
            string strCost;
            switch (woodType)
            {
                 //Add code here


            }

            //Convert cost to a currency string
            //Add code here


            //Output report
            //Add code here


        }
    }
}
//Sample Output
//How many drawers does the desk have? 4
//What type of wood? ('m' = mahogany 'o' = oak 'p' = pine
//o
//Wood Type             Oak
//Number of drawers     4
//Final Price           $260.00