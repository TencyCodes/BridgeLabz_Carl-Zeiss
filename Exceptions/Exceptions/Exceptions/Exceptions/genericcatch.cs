using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class genericcatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int divide = num1 / num2;
                Console.WriteLine($"{divide}");
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
