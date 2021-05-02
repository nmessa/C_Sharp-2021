//Lab Exercise 5.5.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //Need to add this

namespace Amino_Acids_2
{
    class Program
    {
        //Globally declared constants
        const double OXYGEN = 15.9994;
        const double CARBON = 12.011;
        const double NITROGEN = 14.00674;
        const double SULPHUR = 32.066;
        const double HYDROGEN = 1.00794;

        static void Main(string[] args)
        {
            //Declare varaibles
            string molecule;
            string[] molecules;
            int C, O, N, S, H;
            double molWeight1, molWeight2, difference;

            //Create FileStream and StreamReader
            //Add code here


            //Read in first set of data from text file
            //Add code here


            //break up string into individual values
            //Add code here


            //Store values as integers
            //Add code here


            //calculate the molecular weight
            //Add code here


            //Display the first molecular weight
            //Add code here


            //Read in second set of data from text file
            //Add code here


            //break up string into individual values
            //Add code here


            //Store values as integers
            //Add code here


            //calculate the second molecular weight
            //Add code here


            //Display the second molecular weight
            //Add code here


            //Calculate the difference in molecular weights
            //Add code here


            //Display the difference in molecular weights
            //Add code here


            //Close StreamReader and FileStream
            //Add code here


            //Create FileStream and StreamWriter
            //Add code here


            //Write the first molecular weight to file
            //Add code here


            //Write the second molecular weight to file
            //Add code here


            //Write the difference in molecular weights
            //Add code here


            //Close StreamWriter and FileStream
            //Add code here


        }
    }
}

//Output
//The molecular weight of the first amino acid is 131.17
//The molecular weight of the second amino acid is 119.12
//The difference in weights is 12.05436