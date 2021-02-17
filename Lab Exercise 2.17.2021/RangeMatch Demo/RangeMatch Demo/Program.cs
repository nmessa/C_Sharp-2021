using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangeMatch_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int numOfItems, discount, index;
            double customerDiscount;

            //Get number of items to purchase from user
            Console.Write("Enter the number of items to purchase: ");
            numOfItems = Convert.ToInt32(Console.ReadLine());

            //Create arrays with range low limits and discounts
            int[] discountRangeLowLimit = { 1, 13, 50, 100, 200 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            
            //Find the index to determine discount
            index = discountRangeLowLimit.Length - 1;
            while (index >= 0 && numOfItems < discountRangeLowLimit[index])
                index--;

            //Get discount
            customerDiscount = discounts[index];

            //Convert discount to percent
            discount = Convert.ToInt32(customerDiscount * 100);
            Console.WriteLine("Your discount is {0}%", discount);
        }
    }
}
