using System;

namespace Operator_8
{
    class CastDemo
    {
        static void Main()
        {
            double x, y;
            byte b;
            int i;
            char ch;

            x = 10.0;
            y = 3.0;

            i = (int)(x / y);
            Console.WriteLine("Integer outcome of x / y: " + i);

            i = 100;
            b = (byte)i;
            Console.WriteLine("Value of b: " + b);

            i = 257;
            b = (byte)i;
            Console.WriteLine("Value of b: " + b);

            b = 88; // ASCII code for X 
            ch = (char)b;
            Console.WriteLine("ch: " + ch);
        }
    }
}
