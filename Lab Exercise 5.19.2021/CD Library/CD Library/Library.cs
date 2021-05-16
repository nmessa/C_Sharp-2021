//Library Class
//Author: 
//Date 5.19.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CD_Library
{
    class Library
    {
        //Class properties
        private int myNumCDs;
        private CD[] myCDs; //Empty array that can hold CD objects

        //Constructor
        public Library()
        {
            int index;

            //Open a file to read in songs information
            //Add code here


            //Read in the number of CDs in the library
            //Add code here


            //Resize the array to hold the number of CDs
            //Add code here


            //Fill array with CD objects
            //Add code here


            //Close the file
            //Add code here

        }

        //Display the Library
        public void showLibrary()
        {
            int index;
            Console.WriteLine("The CD Library Contains: ");

            //Display each CD in the Library
            for (index = 0; index < myNumCDs; index++)
                myCDs[index].showCD();
        }
    }
}
