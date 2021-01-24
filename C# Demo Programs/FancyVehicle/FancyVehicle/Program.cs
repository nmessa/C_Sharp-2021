using System;

namespace FancyVehicle
{
    class Vehicle
    {
        public int passengers; // number of passengers  
        public int fuelCap;    // fuel capacity in gallons 
        public int mpg;        // fuel consumption in miles per gallon 

        // Return the range. 
        public int range()
        {
            return mpg * fuelCap;
        }

        // Compute fuel needed for a given distance. 
        public double FuelNeeded(int miles)
        {
            return (double)miles / mpg;
        }
    }

    class CompFuel
    {
        static void Main()
        {
            Vehicle minivan = new Vehicle();
            Vehicle sportscar = new Vehicle();
            double gallons;
            int dist = 252;

            // Assign values to fields in minivan. 
            minivan.passengers = 7;
            minivan.fuelCap = 16;
            minivan.mpg = 21;

            // Assign values to fields in sportscar. 
            sportscar.passengers = 2;
            sportscar.fuelCap = 14;
            sportscar.mpg = 12;

            gallons = minivan.FuelNeeded(dist);
            Console.WriteLine("To go " + dist + " miles minivan needs " +
                               gallons + " gallons of fuel.");

            gallons = sportscar.FuelNeeded(dist);
            Console.WriteLine("To go " + dist + " miles sportscar needs " +
                               gallons + " gallons of fuel.");
        }
    }
}
