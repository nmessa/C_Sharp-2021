using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleConstructor
{
    class Vehicle
    {
        public int passengers; // number of passengers   
        public int fuelCap;    // fuel capacity in gallons  
        public int mpg;        // fuel consumption in miles per gallon  

        // This is a constructor for Vehicle. 
        public Vehicle(int p, int f, int m)
        {
            passengers = p;
            fuelCap = f;
            mpg = m;
        }

        // Return the range.  
        public int range()
        {
            return mpg * fuelCap;
        }

        // Compute fuel needed for a given distance. 
        public double fuelNeeded(int miles)
        {
            return (double)miles / mpg;
        }
    }

    class VehConsDemo
    {
        static void Main()
        {
            // Construct complete vehicles. 
            Vehicle minivan = new Vehicle(7, 16, 21);
            Vehicle sportscar = new Vehicle(2, 14, 12);
            double gallons;
            int dist = 252;

            gallons = minivan.fuelNeeded(dist);
            Console.WriteLine("To go " + dist + " miles minivan needs " +
                               gallons + " gallons of fuel.");

            gallons = sportscar.fuelNeeded(dist);
            Console.WriteLine("To go " + dist + " miles sportscar needs " +
                               gallons + " gallons of fuel.");
        }
    }
}
