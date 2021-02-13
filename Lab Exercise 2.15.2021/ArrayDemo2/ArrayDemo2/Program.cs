using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            // defining array with size 5. add values later on
            int[] intArray1 = new int[5];

            // defining array with size 5 and adding values at the same time
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            // defining array with 5 elements which indicates the size of an array
            int[] intArray3 = { 5, 4, 3, 2, 1 };

            //Filling an array
            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray1[i] = r.Next(1,100);
            }

            //Displaying array1
            for (int i = 0; i < intArray1.Length; i++)
            {
                Console.WriteLine("intArray1[{0}] = {1}",i,intArray1[i]);
            }

            //Displaying array2
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.WriteLine("intArray2[{0}] = {1}", i, intArray2[i]);
            }

            //Displaying array3
            for (int i = 0; i < intArray3.Length; i++)
            {
                Console.WriteLine("intArray3[{0}] = {1}", i, intArray3[i]);
            }

            string[] names = new string[5];

            //Fill array with names
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter a name: ");
                names[i] = Console.ReadLine();
            }

            //Display names array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("names[{0}] = {1}", i, names[i]);
            }
        }
    }
}
//Sample Output
//intArray[0] = 34
//intArray[1] = 75
//intArray[2] = 34
//intArray[3] = 11
//intArray[4] = 93
//Enter a name: Joe
//Enter a name: Mary
//Enter a name: Fred
//Enter a name: Alex
//Enter a name: Pierre
//names[0] = Joe
//names[1] = Mary
//names[2] = Fred
//names[3] = Alex
//names[4] = Pierre