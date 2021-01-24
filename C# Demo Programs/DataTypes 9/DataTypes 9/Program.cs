using System;

namespace DataTypes_9
{
    class DynInit
    {
        static void Main()
        {
            double radius = 4, height = 5;

            // Dynamically initialize volume. 
            double volume = 3.1416 * radius * radius * height;

            Console.WriteLine("Volume is " + volume);
        }
    }

}
