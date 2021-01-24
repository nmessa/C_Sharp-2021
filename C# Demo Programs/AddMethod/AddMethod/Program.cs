using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddMethod
{
    // A class that encapsulates information about vehicles. 
    class Vehicle
    {
        public int Passengers; // number of passengers  
        public int FuelCap;    // fuel capacity in gallons 
        public int Mpg;        // fuel consumption in miles per gallon 

        // Display the range. 
        public void range()
        {
            Console.WriteLine("Range is " + FuelCap * Mpg);
        }
    }

    class AddMethod
    {
        static void Main()
        {
            Vehicle minivan = new Vehicle();
            Vehicle sportscar = new Vehicle();

            // Assign values to fields in minivan. 
            minivan.Passengers = 7;
            minivan.FuelCap = 16;
            minivan.Mpg = 21;

            // Assign values to fields in sportscar. 
            sportscar.Passengers = 2;
            sportscar.FuelCap = 14;
            sportscar.Mpg = 12;

            //Output information
            Console.Write("Minivan can carry " + minivan.Passengers + ". ");
            minivan.range(); // display range of minivan.
            Console.Write("Sportscar can carry " + sportscar.Passengers + ". ");
            sportscar.range(); // display range of sportscar. 
        }
    }
}
