//Function Demo
//Value and reference parameters with void return
//Demonstrates function overloading
//Author: nmessa
//Date: 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Function_Demo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Function Demo Program
	        int number1 = 42;
	        int number2 = 17;

	        Console.WriteLine("Number 1 = {0}", number1);
	        Console.WriteLine("Number 2 = {0}", number2);
	        Console.WriteLine("Pass by value");
	        swap(number1, number2);
	        Console.WriteLine("Number 1 = {0}", number1);
	        Console.WriteLine("Number 2 = {0}", number2);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Number 1 = {0}", number1);
            Console.WriteLine("Number 2 = {0}", number2);
            Console.WriteLine("Pass by reference");
            swap(ref number1, ref number2);
            Console.WriteLine("Number 1 = {0}", number1);
            Console.WriteLine("Number 2 = {0}", number2);
        }

        //Pass by value swap function
        static void swap(int n1, int n2)
        {
	        int temp;
	        temp = n1;
	        n1 = n2;
	        n2 = temp;
        }

        //Pass by reference swap function
        static void swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}

