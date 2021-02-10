//Function Demo
//Value parameters with return
//Demonstrates function overloading
//Author: nmessa
//Date: 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions3
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, length, width, circleArea, rectangleArea;

            //Find area of a circle and print out result
            Console.WriteLine("Area of Circle");
            Console.Write("Enter the radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            circleArea = area(radius);
            Console.WriteLine("Circle Area = {0}", circleArea);

            Console.Write("\n\n\n");
            //Find area of a rectangle and print out result
            Console.WriteLine("Area of Rectangle");
            Console.Write("Enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());
            rectangleArea = area(length, width);
            Console.WriteLine("Rectangle Area = {0}", rectangleArea);
        }

        //Returns the area of a circle with a radius of r
        static double area(double r)
        {
            double answer;
            answer = 2 * Math.PI * Math.Pow(r, 2);
            return answer;
        }

        //Returns the area of a rectangle of length l and 
        //width w
        static double area(double l, double w)
        {
            double answer;
            answer = l * w;
            return answer;
        }
    }
}
