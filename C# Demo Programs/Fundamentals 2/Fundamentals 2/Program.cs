using System;

namespace Fundamentals_2
{
    class UseVars
    {
        static void Main()
        {
            int length; // this declares a variable  
            int width;  // this declares another variable  
            int area;   // this is a third variable 

            // Assign length the value 9. 
            length = 9;

            // This display the current value of length. 
            Console.WriteLine("length contains " + length);

            // Assign width the value 7. 
            width = 7;

            // This display the current value of width. 
            Console.WriteLine("width contains " + width);

            // Assign to area the product of length and width. 
            area = length * width;

            // Display the result. 
            Console.Write("area contains length * width: ");
            Console.WriteLine(area);
        }
    }

}
