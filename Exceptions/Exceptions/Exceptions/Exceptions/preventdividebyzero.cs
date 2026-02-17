using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class preventdividebyzero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Second Number cannot be zero");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            } 
        }
    }
}
