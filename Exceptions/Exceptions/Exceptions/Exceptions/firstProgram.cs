using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class firstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birthday Cake Divider");
            Console.WriteLine("How many Slices of Cake ?");
            int totalSlices = int.Parse(Console.ReadLine());

            Console.WriteLine("How many People?");
            int people = int.Parse(Console.ReadLine());

            try
            {
                int slices = totalSlices / people;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ooops you cant divide any no by 0");
            }
            finally
            {
                Console.WriteLine("Cake over! Party Over!");
            }

        }
    }
}
