﻿//Lab Exercise 2.16.2021 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of zip codes as strings
            string[] zips = new string[] {"03833", "03834", "03835", "03836", "03837",
                "03838", "03839", "03830", "03831", "03832"};

            //Create an array of delivery charges as doubles
            double[] charges = new double[] {1.23, 1.75, 2.12, 1.75, 1.98, 2.11, 
                2.65, 1.75, 2.89, 2.10};

            //Declare variables
            string zipCode, strCharge;
            int index;

            //Get zip code from user
            //Add code here


            //Get loaction of zip code in the array of zips
            //Add code here


            if (index != -1) //zip code is found
            {
                //Convert the delivery charge to a currency string
                //Add code here

            }
            else  //zip code not found
            {
                //Add code here

            }
            
        }
    }
}

//Sample Output
//Enter a zip code: 03836
//The delivery charge for delivery to 03836 is $1.75