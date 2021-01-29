//Lab Exercise 2.4.2021 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varaibles
            string person, userInput;
            double andreaSales=0, brittanySales=0, ericSales=0, amount=0;
            double andreaCommission, brittanyCommission, ericCommission;
            double andreaTotal, brittanyTotal, ericTotal;
            char p;
            string strAndrea, strBrittany, strEric;

            //Get salesperson ID as a char
            //Add code here 


            //If valid salesperson (not 'Z'), get their amount of weekly sales
            //Add code here 


            
            //Keep looping until Z entered
            while (p != 'Z')
            {
                //add amount to appropriate salesperson
                switch (p)
                {
                    //Add code here 


                }

                //Get another salesperson ID as a char
                //Add code here 


                //If valid salesperson (not 'Z'), get their amount of weekly sales
                //Add code here 

            }


            //Calculate Commissions
            //Add code here 


            //Calculate totals
            //Add code here 


            //Print Sales Totals
            //Add code here 


            //Print Sales Commisssions
            //Add code here 


            //Print Totals
            //Add code here 

        }
    }
}

//Sample Output
//Enter the salesperson (A, B, or E) (Z to quit): a
//Enter the amount of weekly sales: 1234.56
//Enter the salesperson (A, B, or E) (Z to quit): b
//Enter the amount of weekly sales: 2345.67
//Enter the salesperson (A, B, or E) (Z to quit): e
//Enter the amount of weekly sales: 3456.78
//Enter the salesperson (A, B, or E) (Z to quit): z

//Andrea Sales            $1,234.56
//Brittany Sales          $2,345.67
//Eric Sales              $3,456.78
//Andrea Commission       $123.46
//Brittany Commission     $234.57
//Eric Commission         $345.68
//Andrea Total            $1,358.02
//Brittany Total          $2,580.24
//Eric Total              $3,802.46
