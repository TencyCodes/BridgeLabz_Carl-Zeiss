using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class CustomException
    {
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException()
            {

            }
            public NegativeNumberException(string message): base(message)
            {

            }
            public NegativeNumberException(string message , Exception innerException): base(message, innerException)
            {

            }
        }
        
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number: ");
                int num1 = int.Parse(Console.ReadLine());
                
                Console.Write("Enter Second Number: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1<0 && num2<0)
                {
                    throw new NegativeNumberException("Number cannot be Negative");
                }

                int result = num1 / num2;
                Console.WriteLine("Result = " + result);
                
            }
            catch(NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
