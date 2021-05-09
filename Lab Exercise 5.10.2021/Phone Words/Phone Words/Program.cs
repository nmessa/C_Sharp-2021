//Lab Exercise 5.10.2021 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Phone_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string number, numString, numString2;
            Console.Write("Enter a phone number (xxx-xxxx): ");
            number = Console.ReadLine();
            numString = number.Substring(0, 3);
            numString2 = number.Substring(4);
            Console.WriteLine("Words for " + numString);
            findMatches(numString);
            Console.WriteLine();
            Console.WriteLine("Words for " + numString2);
            findMatches2(numString2);
        }

        //This function finds matches of 3 letter words
        private static void findMatches(string ns)
        {
            //Create FileStream and StreamReader to open words.txt
            //Add code here


            //Create variables
            string word = "";
            string numWord = "";

            //Keep reading until you hit the end of file
            while (! reader.EndOfStream)
            {
                //Read in a word
                //Add code here


                //Only check 3 letter words
                if (word.Length == 3)
                {
                    //Convert word to a number word
                    //Add code here


                    //Write the word if the numWord matches ns 
                    //Add code here


                }
            }
            //Close the StreamReader and the Filestream
            //Add code here

            
        }

        //This function finds matches of 4 letter words
        private static void findMatches2(string ns)
        {
            //Ad code here


        }

        //This function results in translation of 3 letter words
        private static string convertWord(string w)
        {
            string temp = "";
            //translate each character in the 3 letter word
            //Add code here


            return temp;
        }

        //This function results in translation of 4 letter words
        private static string convertWord2(string w)
        {
            //Add code here


        }

        private static string translate(char ch)
        {
            //Add code here
                


        }
    }
}

//Sample Output
//Enter a phone number (xxx-xxxx): 772-3456
//Words for 772
//SPA

//Words for 3456
//FILM
//FILO
