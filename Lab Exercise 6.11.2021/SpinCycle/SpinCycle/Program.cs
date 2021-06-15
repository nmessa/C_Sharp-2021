//Lab Exercise 6.11.2021 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SpinCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create lists to hold gear teeth values and gear ratios
            List<double> ratios = new List<double>();
            List<int> crankGears = new List<int>();
            List<int> wheelGears = new List<int>();

            //Create FileStream and StreamReader to read bicycle.txt
            FileStream fs = new FileStream("bicycle.txt", FileMode.Open, FileAccess.Read);
            StreamReader textfile = new StreamReader(fs);

            //Declare variables
            int crankSprockets, wheelSprockets;
            double diameter;
            string[] temp;
            double distance = 0.0;
            int rotations;
            int gear;

            //read first line and store the number of wheel and crank sprockets and diameter of wheel
            string line = textfile.ReadLine();
            temp = line.Split(' ');
            crankSprockets = Convert.ToInt32(temp[0]);
            wheelSprockets = Convert.ToInt32(temp[1]);
            diameter = Convert.ToDouble(temp[2]);

            //read second line and store the crank gear teeth values
            line = textfile.ReadLine();
            temp = line.Split(' ');
            for (int i = 0; i < crankSprockets; i++)
                crankGears.Add(Convert.ToInt32(temp[i]));

            //read third line and store wheel gear teeth values
            line = textfile.ReadLine();
            temp = line.Split(' ');
            for (int i = 0; i < wheelSprockets; i++)
                wheelGears.Add(Convert.ToInt32(temp[i]));

            //Calculate all gear ratios
            for (int i = 0; i < crankSprockets; i++)
            {
                for (int j = 0; j < wheelSprockets; j++)
                {
                    ratios.Add(1.0 * crankGears[i] / wheelGears[j]);
                }
            }

            //Sort the gear ratios for gears 1 to 10
            ratios.Sort();

            //Print gear table
            Console.WriteLine("Gear" + "\t" + "Ratio");
            for (int i = 0; i < wheelSprockets * crankSprockets; i++)
            {
                Console.WriteLine((i+1) + "\t" + Math.Round(ratios[i], 5));
            }

            //Read in rotation and gear data
            while (true)
            {
                line = textfile.ReadLine();
                if (line == null) //stop loop when you run out of data
                    break;
                //break line into rotations and gear number
                temp = line.Split(' ');

                //Store number of rotations and which gear you are in
                rotations = Convert.ToInt32(temp[0]);
                gear = Convert.ToInt32(temp[1]);

                //Calculate distance traveled with this rotaton and gear data and add to distance
                //Be sure to multiply by PI to get the circumference of the wheel
                distance += diameter * ratios[gear - 1] * rotations * Math.PI;
            }

            //Convert to feet
            distance /= 12.0;

            //Output the result
            Console.WriteLine("Distance traveled: " + Math.Round(distance,2) + " feet");
        }
    }
}
