using System;
namespace BreakDemo
{
    class Program
    {
        static void Main()
        {
            int num;

            num = 100;

            // Loop while i squared is less than num. 
            for (int i = 0; i < num; i++)
            {

                // Terminate loop if i*i >= 100. 
                if (i * i >= num) break;

                Console.Write(i + " ");
            }
            Console.WriteLine("Loop complete.");
        }
    }
}
