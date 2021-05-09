using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Name_Class
{
    class Name
    {
        private string first;
        private string middle;
        private string last;

        public Name(string f, string m, string l)
        {
            first = f;
            middle = m;
            last = l;
        }

        public void showName()
        {
            Console.WriteLine(first + " " + middle + " " + last);
        }

        public void changeLastName(string l)
        {
            last = l;
        }
    }
}
