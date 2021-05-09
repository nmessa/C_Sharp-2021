//Lab Exercise 5.13.2021 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student joe = new Student("Joseph", "Smith", 17, 3.45);
            Student mary = new Student("Mary", "Jones", 16, 3.75);
            Student alice = new Student("Alice", "Wilson", 18, 3.55);
            double averageGPA;
            double averageAge;
            joe.display();
            mary.display();
            alice.display();
            averageAge = (joe.getAge() + mary.getAge() + alice.getAge()) / 3.0;
            averageGPA = (joe.getGPA() + mary.getGPA() + alice.getGPA()) / 3.0;
            Console.WriteLine("Average age: " + averageAge.ToString("f2"));
            Console.WriteLine("Average GPA: " + averageGPA.ToString("n2"));
        }
    }
}

//Output
//Joseph Smith
//17
//3.45
//Mary Jones
//16
//3.75
//Alice Wilson
//18
//3.55
//Average age: 17.00
//Average GPA: 3.58