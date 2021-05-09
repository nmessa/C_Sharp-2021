//Class Design Demo
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Name_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Name joe = new Name("Joseph", "Alan", "Jones");
            Name mary = new Name("Mary", "Alice", "Rogers");
            joe.showName();

            mary.showName();
            Console.WriteLine("Joe and Mary got married");
            mary.changeLastName("Jones");
            mary.showName();
        }
    }
}

//Output
//Joseph Alan Jones
//Mary Alice Rogers
//Joe and Mary got married
//Mary Alice Jones