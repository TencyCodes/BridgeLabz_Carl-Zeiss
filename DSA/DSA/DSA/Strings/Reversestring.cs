using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Reversestring
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str1 = Console.ReadLine();

            int size = str1.Length;

            for (int i = size-1; i>=0; i--)
            {
                Console.WriteLine(str1[i]);
            }
        }
    }
}
