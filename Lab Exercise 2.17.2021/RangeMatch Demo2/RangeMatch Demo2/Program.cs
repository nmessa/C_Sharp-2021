//Range match demo using upper limits for ranges
//Author: nmessa
//Date: 2.17.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangeMatch_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int numOfItems, discount;
            double customerDiscount;
            int index = 0;

            //Get number of items to purchase from user
            Console.Write("Enter the number of items to purchase: ");
            numOfItems = Convert.ToInt32(Console.ReadLine());

            //Declare arrays of discounts and range limits
            int[] discountRangeUpperLimit = { 12, 49, 99, 199, 9999999 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            
            //Finde the index for discount
            while (index < discountRangeUpperLimit.Length && 
                numOfItems > discountRangeUpperLimit[index])
                ++index;

            //Get discount
            customerDiscount = discounts[index];

            //Convert discount to percent
            discount = Convert.ToInt32(customerDiscount * 100);

            //Output result
            Console.WriteLine("Your discount is {0}%", discount);
        }
    }
}
