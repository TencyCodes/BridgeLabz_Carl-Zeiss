using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class MultiplecatchBlock
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {num1 / num2}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine($"Operation Finished");
            }
        }

    }
}
