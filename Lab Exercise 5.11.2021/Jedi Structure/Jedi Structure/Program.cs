//Lab Exercise 5.11.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jedi_Structure
{
    class Program
    {
        public struct Jedi
        {
            //Declare variables
            public string name;
            public string starName;
            public bool darkSide;
            public string rank;
            public string city;
            public string mother;

            public string starWarsName()
            {
                //Declare variables
                string first, last, swName;
                string[] names;
                //Add code here


                return swName;
            }
        }
        static void Main(string[] args)
        {
            Jedi joe = new Jedi();
            string message = "";
            joe.name = "Joe Smith";
            joe.darkSide = true;
            joe.rank = "Master";
            joe.city = "Boston";
            joe.mother = "Robinson";
            joe.starName = joe.starWarsName();
            message = "Name: " + joe.name + Environment.NewLine;
            message += "Star Wars Name: " + joe.starName + Environment.NewLine;
            message += "Rank: " + joe.rank + Environment.NewLine;
            message += "Dark Side Status: " + joe.darkSide;
            Console.WriteLine(message);
        }
    }
}

//Output
//Name: Joe Smith
//Star Wars Name: Smijo Robos
//Rank: Master
//Dark Side Status: True