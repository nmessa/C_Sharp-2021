//Lab Exercise 5.12.2021 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        //Global variables
        static int coach;
        static int firstClass;
        static int regular;
        static int veggie;
        static int choice;
        static char selectClass;
        static char selectMeal;

        static void Main(string[] args)
        {
            
            while (true)
            {
                menu();
                switch (choice)
                {
                    case 1:
                        addPassenger();
                        break;
                    case 2:
                        report();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;      
                }
            }
        }

        //Function to display menu
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add an additional passenger");
            Console.WriteLine("2. Receive a passenger and meal report");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.Write("Enter a selection (1,2,3): ");
            choice = Convert.ToInt32(Console.ReadLine());
        }

        //Function to add a passenger
        static void addPassenger()
        {
            //Clear the console
            //Add code here


            //Get desired class from user as an upper case character
            //Add code here


            //Process class selection
            //Need to determine if first class or coach is full
            //or invalid choice
            //Also determine if plane is full
            switch (selectClass)
            {
                //Add code here



            }//end of switch

            //Get desired meal from user as an upper case character
            //Add code here


            //Process meal request as regular, vegetarian, of invalid choice
            switch (selectMeal)
            {
                //Add code here


            }
        }//end of addPassenger

        //Function to generate a report
        static void report()
        {
            Console.Clear();
            Console.WriteLine("First Class: " + firstClass);
            Console.WriteLine("Coach Class: " + coach);
            Console.WriteLine("Regular Meals: " + regular);
            Console.WriteLine("Vegetarian Meals: " + veggie);
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }
    }
}
