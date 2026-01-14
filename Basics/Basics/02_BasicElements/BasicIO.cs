using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._02_BasicElements
{
    internal class BasicIO
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            int square = a * a;
            Console.WriteLine("result =" + square);


            Console.WriteLine("Enter your Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"My Name is{name} and I am {age} years old");

        }
        

    }
}
