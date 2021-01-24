using System;

namespace DataTypes_3
{
    class Hypot
    {
        static void Main()
        {
            double x, y, z;

            x = 3;
            y = 4;

            z = Math.Sqrt(x * x + y * y);

            Console.WriteLine("Hypotenuse is " + z);
        }
    }
}
