using System;

namespace ReturnMethod
{
    // A class that encapsulates information about vehicles. 
    class Vehicle
    {
        public int Passengers; // number of passengers  
        public int FuelCap;    // fuel capacity in gallons 
        public int Mpg;        // fuel consumption in miles per gallon 

        // Return the range. 
        public int range()
        {
            return Mpg * FuelCap;
        }
    }

    class RetMeth
    {
        static void Main()
        {
            Vehicle minivan = new Vehicle();
            Vehicle sportscar = new Vehicle();

            int range1, range2;

            // Assign values to fields in minivan. 
            minivan.Passengers = 7;
            minivan.FuelCap = 16;
            minivan.Mpg = 21;

            // Assign values to fields in sportscar. 
            sportscar.Passengers = 2;
            sportscar.FuelCap = 14;
            sportscar.Mpg = 12;

            // Get the ranges. 
            range1 = minivan.range();
            range2 = sportscar.range();

            //Output the information
            Console.WriteLine("Minivan can carry " + minivan.Passengers +
                             " with range of " + range1 + " miles.");
            Console.WriteLine("Sportscar can carry " + sportscar.Passengers +
                             " with range of " + range2 + " miles.");
        }
    }
}
