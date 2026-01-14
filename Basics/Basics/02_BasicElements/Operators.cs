using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._02_BasicElements
{
    internal class Operators
    {
        public static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 4;

            //addition
            int addition = a + b;

            //subtraction 
            int subtraction = a - b;

            //multiplication 
            int multiplication = a * b;

            //div
            int division = a / b;

            //mod or remainder
            int modu = a % b;

            Console.WriteLine("Addition = " + addition);
            Console.WriteLine("Subraction = " + subtraction);
            Console.WriteLine("Multiplication = " + multiplication);
            Console.WriteLine("Division = " + division);
            Console.WriteLine("Modulus = " + modu);

            //Relational Operators
            Console.WriteLine("Enter value for c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (c > d)
            {
                Console.WriteLine("c is greater than d");
            }
            if (c < d)
            {
                Console.WriteLine("c is less than d");
            }
            if (c == d)
            {
                Console.WriteLine("c is equal to d");
            }

            //Logical Operators

            Console.WriteLine("Enter value for e: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for f: ");
            int f = Convert.ToInt32(Console.ReadLine());
            if(e>0 && f> 0 )
            {
                Console.WriteLine("Both e and f are positive numbers");
            }
            if (e > 0 || f > 0)
            {
                Console.WriteLine("At least one of e or f is a positive number");
            }
            if(!(e > 0) && !(f>0))
            {
                Console.WriteLine("e and f are not a positive number ");
            }
            Console.WriteLine("Enter your Age: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if(x>=18)
            {
                Console.WriteLine("You are eligible to vote");

            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

        }
    }
}
