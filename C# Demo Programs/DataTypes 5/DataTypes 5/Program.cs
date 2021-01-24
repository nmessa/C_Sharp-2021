using System;

namespace DataTypes_5
{
    class BoolDemo
    {
        static void Main()
        {
            bool b;

            b = false;
            Console.WriteLine("b is " + b);
            b = true;
            Console.WriteLine("b is now " + b);

            // A bool value can control the if statement. 
            if (b) Console.WriteLine("This is executed.");

            b = false;
            if (b) Console.WriteLine("This is not executed.");

            // The outcome of a relational operator is a bool value. 
            Console.WriteLine("88 > 17 is " + (88 > 17));
        }
    }

}
