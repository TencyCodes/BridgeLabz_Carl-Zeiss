using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._03_TypeConversion
{
    internal class TypeConversion
    {
        public static void Main()
        {
            string a = "123";
            int b = int.Parse(a);

            Console.WriteLine(b);

            string c = "abc";
            bool d = int.TryParse(c, out int result);

            if (d)
            {
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
