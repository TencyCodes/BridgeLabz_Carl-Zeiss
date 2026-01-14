using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._04_LogicalConstructs
{
    internal class IfElse
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >0)
            {
                Console.WriteLine("The Number is Positive");

            }
            else if (number<0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }

            Console.WriteLine("Enter 1st Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            if(Num1 > Num2)
            {
                Console.WriteLine("greatest num = " + Num1);
            }
            else
            {
                Console.WriteLine("greatest num = "+ Num2);
            }
        }
    }
}
