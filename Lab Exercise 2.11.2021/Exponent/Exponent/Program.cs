//Lab Exercise 2/11/2021 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number, squareValue, cubeValue;
            string userInput;

            //Get an integer value from the user
            //Add code here


            //Call function to calculate the square of a number
            //Add code here


            //Call function to calculate the cube of a number
            //Add code here


            //Output the results
            Console.WriteLine("{0} squared = {1}", number, squareValue);
            Console.WriteLine("{0} cubed = {1}", number, cubeValue);
        }

        //This fucntion is passed an integer and returns the square of that integer
        static int Square(int n)
        {
            //Add code here

        }

        //This function is passed an integer and returns the cube of that integer
        //it also calls the Square function
        static int Cube(int n)
        {
            //Add code here

        }
    }
}

//Sample Output
//Enter an integer value: 12
//12 squared = 144
//12 cubed = 1728