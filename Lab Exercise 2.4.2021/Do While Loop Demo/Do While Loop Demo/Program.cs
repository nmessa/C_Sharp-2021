using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_While_Loop_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            }
            while (count <= 10);
        }
    }
}
