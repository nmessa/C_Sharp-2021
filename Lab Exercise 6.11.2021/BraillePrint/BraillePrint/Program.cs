//Braille Print Demo Program
//Author: nmessa
//Date: 6/11/2021
//Must use NSimSun font in your console indexer order to 
//display unicode characters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BraillePrint
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<string> braille = new List<string>();
            Console.OutputEncoding = Encoding.UTF8;
            //Define Braille characters
            //Not the " character must be defined as \"
            string b = " a1b'k2l@cif/msp\"e3h9o6r^djg>ntq'*5<-u8v.%[$+x!&;:4\0z7(_?w]#y)=";
            string phrase;
            string braillePhrase = "";
            int index;

            //Store Braille Character set
            braille.Add("\u2800");
            braille.Add("\u2801");
            braille.Add("\u2802");
            braille.Add("\u2803");
            braille.Add("\u2804");
            braille.Add("\u2805");
            braille.Add("\u2806");
            braille.Add("\u2807");
            braille.Add("\u2808");
            braille.Add("\u2809");
            braille.Add("\u280A");
            braille.Add("\u280B");
            braille.Add("\u280C");
            braille.Add("\u280D");
            braille.Add("\u280E");
            braille.Add("\u280F");
            braille.Add("\u2810");
            braille.Add("\u2811");
            braille.Add("\u2812");
            braille.Add("\u2813");
            braille.Add("\u2814");
            braille.Add("\u2815");
            braille.Add("\u2816");
            braille.Add("\u2817");
            braille.Add("\u2818");
            braille.Add("\u2819");
            braille.Add("\u281A");
            braille.Add("\u281B");
            braille.Add("\u281C");
            braille.Add("\u281D");
            braille.Add("\u281E");
            braille.Add("\u281F");
            braille.Add("\u2820");
            braille.Add("\u2821");
            braille.Add("\u2822");
            braille.Add("\u2823");
            braille.Add("\u2824");
            braille.Add("\u2825");
            braille.Add("\u2826");
            braille.Add("\u2827");
            braille.Add("\u2828");
            braille.Add("\u2829");
            braille.Add("\u282A");
            braille.Add("\u282B");
            braille.Add("\u282C");
            braille.Add("\u282D");
            braille.Add("\u282E");
            braille.Add("\u282F");
            braille.Add("\u2830");
            braille.Add("\u2831");
            braille.Add("\u2832");
            braille.Add("\u2833");
            braille.Add("\u2834");
            braille.Add("\u2835");
            braille.Add("\u2836");
            braille.Add("\u2837");
            braille.Add("\u2838");
            braille.Add("\u2839");
            braille.Add("\u283A");
            braille.Add("\u283B");
            braille.Add("\u283C");
            braille.Add("\u283D");
            braille.Add("\u283E");
            braille.Add("\u283F");

            Console.Write("Enter a phrase: ");
            phrase = Console.ReadLine();

            //Generate the Braille Phrase
            for (int i = 0; i < phrase.Length; i++)
            {
                index = b.IndexOf(phrase[i]);
                braillePhrase += (braille[index] + " ");
            }

            //Display the Braille phrase
            Console.WriteLine(braillePhrase);
        }
    }
}
