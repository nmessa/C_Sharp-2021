//Lab Exercise 6/11/2021 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array with all of the Morse codes for the letters A to Z
            string[] codes = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.","....", "..", ".---",
                                 "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...",
                                 "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
            string phrase;
            string morse = "";

            //Get phrase to encode from user and convert to upper case
            Console.Write("Enter a phrase: ");
            phrase = Console.ReadLine().ToUpper();

            //Parse the phrase character by character and translate to Morse Code
            for (int i = 0; i < phrase.Length; i++)
            {
                if (Char.IsLetter(phrase[i]))  //Encode all of the letters
                {
                    morse += codes[phrase[i] - 65];
                }
                else //encode punctuations
                {
                    switch (phrase[i])
                    {
                        case '_':
                            morse += "..--";
                            break;
                        case '.':
                            morse += "---.";
                            break;
                        case ',':
                            morse += ".-.-";
                            break;
                        case '?':
                            morse += "----";
                            break;
                        case ' ':
                            morse += " ";
                            break;
                    }
                }
                morse += " ";
            }

            //print the Morse Code
            Console.WriteLine(morse);
        }
    }
}

//Sample Output
//Enter a phrase: this is a test
//- .... .. ...   .. ...   .-   - . ... -
