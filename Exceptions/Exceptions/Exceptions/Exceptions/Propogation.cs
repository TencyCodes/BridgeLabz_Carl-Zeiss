using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class Propogation
    {
        public static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }
        public static void Method1()
        {
            Method();
        }
        public static void Method()
        {
            Console.WriteLine("Enter Number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int divide = num1 / num2;
            Console.WriteLine($"{divide}");
        }
    }
}
