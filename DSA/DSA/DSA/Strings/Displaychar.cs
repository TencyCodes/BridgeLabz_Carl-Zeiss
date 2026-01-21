using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class Displaychar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int length = str.Length;

            for (int i = 0;i<length;i++)
            {
                Console.Write(str[i]+" ");
            }
        
        }
    }
}
