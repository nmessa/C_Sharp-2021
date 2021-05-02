//Lab Exercise 5.4.2021 Problem 3
//Author: 
//Pass an array to an function and the function returns an array
//of the square root of each element in the original array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Square_Root
{
    class Program
    {
        const int SIZE = 10;

        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[SIZE];
            double[] numbers2;

            //Fill the array with random integers from 1 to 10000
            //Add code here


            //Pass the array to a function that takes the square root of each element
            //Add code here


            //Print the contents of both arrays
            //Add code here

        }

        private static double[] on_all(int[] ary)
        {
            //Create an array to hold the square roots of the values in ary
            //Add code here


            //Traverse the array arr and store the square roots in the array just created
            //Add code here


            return a;
        }
    }
}

//Output
//2590  50.89
//2320  48.17
//7622  87.30
//7783  88.22
//4248  65.18
//3298  57.43
//3585  59.87
//1572  39.65
//930  30.50
//5560  74.57
