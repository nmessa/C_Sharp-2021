//Lab Exercise 5.11.2021 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer
{
    class Program
    {
        public struct Computer
        {
            public int ram;
            public string os;
            public double clock;
            public string cpu;
            public int hd;
            public int[] driveSize;  //Supports more that one hard drive

            //Set the size of all hard drives in the system
            public void setSize()
            {
                //Add code here


            }
        }

        static void Main(string[] args)
        {
            Computer myComputer = new Computer();
            string message = "";
            myComputer.ram = 16;
            myComputer.os = "Windows 7";
            myComputer.clock = 4.0;
            myComputer.cpu = "I7";
            myComputer.hd = 3;
            myComputer.setSize();
            Console.WriteLine();

            message = "Computer information" + Environment.NewLine;
            message += "RAM: " + myComputer.ram + " Gigabytes" + Environment.NewLine;
            message += "Operating System: " + myComputer.os + Environment.NewLine;
            message += "Clock frequency: " + myComputer.clock + " GHz" + Environment.NewLine;
            message += "CPU: " + myComputer.cpu + Environment.NewLine;
            for (int i = 0; i < myComputer.hd; i++)
            {
                message += "Hard Drive " + i + ": " + myComputer.driveSize[i] + " Gigabytes" + Environment.NewLine;
            }

            Console.WriteLine(message);
        }
    }
}

//Sample Output
//Enter the size of drive 0 in Gigabytes: 256
//Enter the size of drive 1 in Gigabytes: 1000
//Enter the size of drive 2 in Gigabytes: 1000

//Computer information
//RAM: 16 Gigabytes
//Operating System: Windows 7
//Clock frequency: 4 GHz
//CPU: I7
//Hard Drive 0: 256 Gigabytes
//Hard Drive 1: 1000 Gigabytes
//Hard Drive 2: 1000 Gigabytes
