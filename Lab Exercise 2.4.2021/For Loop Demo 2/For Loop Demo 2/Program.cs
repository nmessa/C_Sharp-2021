using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_Loop_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count <= 10; count++)
            {
                if (count % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(count);
            }
        }
    }
}
