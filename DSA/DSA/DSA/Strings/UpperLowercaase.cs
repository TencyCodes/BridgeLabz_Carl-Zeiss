using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class UpperLowercaase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int size = str.Length;

            string upperCas = str.ToUpper();
            string lowerCas = str.ToLower();

            Console.WriteLine("Uppercase String : " + upperCas);
            Console.WriteLine("Uppercase String : " + upperCas);

        }
    }
}
