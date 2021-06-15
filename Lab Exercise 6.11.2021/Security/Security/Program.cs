//Lab Exercise 6/11/2021 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Security
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of passengers
            List<string> passengers = new List<string>();
            string line;

            //Create FileStream and StreamReader to read passengers.txt
            FileStream fs = new FileStream("passengers.txt", FileMode.Open, FileAccess.Read);
            StreamReader textfile = new StreamReader(fs);

            //Prime the loop
            line = textfile.ReadLine();
            
            //Read in passengers and add to list
            while (line != null)
            {
                passengers.Add(line);
                line = textfile.ReadLine();
            }

            //close StreamReader and FileStream
            textfile.Close();
            fs.Close();

            //Create FileStream and StreamReader for luggage file
            fs = new FileStream("luggage.txt", FileMode.Open, FileAccess.Read);
            textfile = new StreamReader(fs);

            //Prime the loop by reading in first piece of luggage
            line = textfile.ReadLine();

            //Check luggage has a passenger associated with it
            while (line != null)
            {
                if (passengers.Contains(line))  //Luggage has matching passenger
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("WARNING: passenger not on board");
                }
                //Read in next piece of luggage
                line = textfile.ReadLine();
            }

            //Close StreamReader and FileStream
            textfile.Close();
            fs.Close();
        }
    }
}

//Sample Output
//OK
//WARNING: passenger not on board
//OK
//OK