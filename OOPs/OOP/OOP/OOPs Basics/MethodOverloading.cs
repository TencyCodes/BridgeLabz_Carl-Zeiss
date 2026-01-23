using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPs_Basics
{
    internal class MethodOverloading
    {
        class Calculator
        {
            public int Add(int a,int b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public double Add(double a, double b)
            {
                return a + b;
            }

         }
        public static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            int result = c1.Add(2, 3);
            c1.Add(3, 4, 5);
            c1.Add(2.5, 5.6);
            
            Calculator c2 = new Calculator();
            c2.Add(3, 4, 5);
            c2.Add(2, 4);
            c2.Add(4.5, 3.5);
            Console.WriteLine(result);

        }
    }
}
