using System;

namespace UseVehicle
{
    class Vehicle
    {
        public int Passengers; // number of passengers  
        public int FuelCap;    // fuel capacity in gallons 
        public int Mpg;        // fuel consumption in miles per gallon 
    }

    // This class declares an object of type Vehicle.  
    class VehicleDemo
    {
        static void Main()
        {
            Vehicle minivan = new Vehicle();
            int range;

            // Assign values to fields in minivan. 
            minivan.Passengers = 7;
            minivan.FuelCap = 16;
            minivan.Mpg = 21;

            // Compute the range assuming a full tank of gas. 
            range = minivan.FuelCap * minivan.Mpg;

            Console.WriteLine("Minivan can carry " + minivan.Passengers +
                               " with a range of " + range);
        }
    }
}
