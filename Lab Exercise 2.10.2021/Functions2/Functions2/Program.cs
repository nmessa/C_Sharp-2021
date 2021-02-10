//Function Demo
//Value parameters with void return
//Demonstrates function overloading
//Author: nmessa
//Date: 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, length, width;

            //Find area of a circle and print out result
            Console.WriteLine("Area of Circle");
            Console.Write("Enter the radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            area(radius);
            
            Console.Write("\n\n\n");
            //Find area of a rectangle and print out result
            Console.WriteLine("Area of Rectangle");
            Console.Write("Enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());
            area(length, width);
            
        }

        //Prints the area of a circle with a radius of r
        static void area(double r)
        {
            double circleArea;
            circleArea = 2 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Circle Area = {0}", circleArea);
        }

        //Prints the area of a rectangle of length l and width w
        static void area(double l, double w)
        {
            double rectangleArea;
            rectangleArea = l * w;
            Console.WriteLine("Rectangle Area = {0}", rectangleArea);
        }
    }
}

//Sample Output
//Area of Circle
//Enter the radius: 23
//Circle Area = 3323.805027498



//Area of Rectangle
//Enter the length: 25
//Enter the width: 21
//Rectangle Area = 525
