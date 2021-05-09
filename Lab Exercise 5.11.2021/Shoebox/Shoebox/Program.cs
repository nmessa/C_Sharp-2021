//Lab Exercise 5.11.2021 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shoebox
{
    class Program
    {
        public struct Box
        {
            //Delcare variables
            public double length;
            public double width;
            public double height;

            public double volume()
            {
                //Add code here
            }

            public double surfaceArea()
            {
                //Add code here


            }
        }

        static void Main(string[] args)
        {
            Box shoeBox = new Box();
            double vol, sa;
            string message = "";

            shoeBox.length = 22.84;
            shoeBox.width = 18.05;
            shoeBox.height = 12.94;
            vol = shoeBox.volume();
            sa = shoeBox.surfaceArea();
            message = "Box Characteristics" + Environment.NewLine +
                    "Length:" + '\t' + shoeBox.length.ToString("f3") + Environment.NewLine +
                    "Width:" + '\t' + shoeBox.width.ToString("f3") + Environment.NewLine +
                    "Height:" + '\t' + shoeBox.height.ToString("f3") + Environment.NewLine +
                    "Volume: " + '\t' + vol.ToString("f3") + Environment.NewLine +
                    "Surface Area: " + '\t' + sa.ToString("f3");

            Console.WriteLine(message);

        }
    }
}

//Output
//Box Characteristics
//Length: 22.840
//Width:  18.050
//Height: 12.940
//Volume:         5334.670
//Surface Area:   1882.757