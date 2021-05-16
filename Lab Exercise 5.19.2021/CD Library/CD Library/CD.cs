//CD Class
//Author: 
//Date 5.19.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Library
{
    class CD
    {
        //Class properties
        private string myArtist;
        private string myTitle;
        private int myNumSongs;
        private Song[] mySongs;      //empty array that can hold Song objects

        //Constructor
        public CD()
        {
            //Declare variables
            int mins, secs, index, count;
            string duration, title;

            //read CD title
            //Add code here


            //read artist name
            //Add code here


            //read the number of songs on the CD
            //Add code here


            //Resize array to appropriate size
            //Add code here


            //Fill array with song objects
            for (count = 0; count < myNumSongs; count++)
            {
                //Read song title
                //Add code here


                //Read song duration in seconds
                //Add code here


                //Convert duration into minutes and seconds
                //Add code here


                //Construct song object and place in mySongs array
                //Add code here

            }
        }

        //Show the CD information
        public void showCD()
        {
            int index;
            Console.WriteLine();
            Console.WriteLine("CD Title: " + myTitle);
            Console.WriteLine("Artist: " + myArtist);
            Console.WriteLine("Songs:");
            for (index = 0; index < myNumSongs; index++)
            {
                //Show each song on the CD
                Console.WriteLine("\t" + mySongs[index].ToString());
            }
            Console.WriteLine();
        }
    }
}
