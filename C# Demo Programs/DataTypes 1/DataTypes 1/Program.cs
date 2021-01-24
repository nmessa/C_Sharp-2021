using System;

namespace DataTypes_1
{
    class Inches
    {
        static void Main()
        {
            long ci;
            long im;

            im = 5280 * 12;

            ci = im * im * im;

            Console.WriteLine("There are " + ci + " cubic inches in cubic mile.");
        }
    }
}
