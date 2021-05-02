//Array use in functions demo
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Function_Demo
{
    class Program
    {
        static Random r = new Random();

        static void Main(string[] args)
        {
            //Define array size
            const int SIZE = 10;

            //Create two arrays of same size
            int[] arr = new int[SIZE];
            int[] arrModified = new int[SIZE];

            //Fill the array with values
            fillArray(arr);
            printArray(arr);
            Console.WriteLine();

            //Pass the array to doubleAll and get back another array
            arrModified = doubleAll(arr);
            printArray(arrModified);
        }

        static void fillArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(1, 1000);
        }

        static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
        }

        static int[] doubleAll(int[] a)
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                newArray[i] = 2 * a[i];
            return newArray;
        }
    }
}
