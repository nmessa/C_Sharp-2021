using System;

namespace DataTypes_10
{
    class ImpTypedVar
    {
        static void Main()
        {

            // These are implicitly typed variables.  
            var pi = 3.1416; // pi is a double 
            var radius = 10; // radius is an int 

            // Both msg and msg2 are string types. 
            var msg = "Radius: ";
            var msg2 = "Area: ";

            // Explicitly declare area as a double. 
            double area;

            Console.WriteLine(msg + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg2 + area);

            Console.WriteLine();

            radius = radius + 2;

            Console.WriteLine(msg + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg2 + area);

            // The following statement will not compile because 
            // radius is an int and cannot be assigned a floating- 
            // point value. 
            //    radius = 12.2;  // Error! 
        }
    }
}
