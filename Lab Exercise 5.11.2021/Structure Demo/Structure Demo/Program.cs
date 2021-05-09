using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Demo
{
    class Program
    {
        public struct Brain
        {
            public string fact1;
            public string fact2;
            public string fact3;
            public string fact4;

            public string brainDump()
            {
                string contents = "";
                contents = fact1 + Environment.NewLine;
                contents += fact2 + Environment.NewLine;
                contents += fact3 + Environment.NewLine;
                contents += fact4;
                return contents;
            }
        }


        static void Main(string[] args)
        {
            Brain ameoba = new Brain();
            string message;

            ameoba.fact1 = "The weight of all the ants on earth is equal to the weight of" + 
                " all the humans on earth." + Environment.NewLine;
            ameoba.fact2 = "The average person spends 6 months of their life sitting at " + 
                "red lights." + Environment.NewLine;
            ameoba.fact3 = "The electric chair was invented by a dentist." + 
                Environment.NewLine;
            ameoba.fact4 = "No word in the English language rhymes with month, orange, " + "silver and purple.";

            message = ameoba.brainDump();
            Console.WriteLine(message);
        }
    }
}
