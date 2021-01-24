using System;
namespace Break2
{
    class Program
    {
        static void Main()
        {
            char ch;

            for (; ; )
            {
                ch = (char)Console.Read();
                if (ch == 'q') break;
            }
            Console.WriteLine("You pressed q!");
        }
    }
}

