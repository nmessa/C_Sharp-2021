using System;

namespace TwoVehicles
{
    // A class that encapsulates information about vehicles. 
    class Vehicle
    {
        public int Passengers; // number of passengers  
        public int FuelCap;    // fuel capacity in gallons 
        public int Mpg;        // fuel consumption in miles per gallon 
    }

    // This class declares two objects of type Vehicle.  
    class Program
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

            // Compute the ranges assuming a full tank of gas. 
            range1 = minivan.FuelCap * minivan.Mpg;
            range2 = sportscar.FuelCap * sportscar.Mpg;

            Console.WriteLine("Minivan can carry " + minivan.Passengers +
                               " with a range of " + range1);

            Console.WriteLine("Sportscar can carry " + sportscar.Passengers +
                               " with a range of " + range2);
        }
    }
}
