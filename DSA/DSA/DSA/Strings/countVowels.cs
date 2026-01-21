using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    internal class countVowels
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            int size = str.Length;
            int countVowels = 0;
            for(int i =0;i<size;i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'O' || str[i] == 'I' || str[i] == 'U')
                {
                    countVowels++;
                }
            }
            Console.WriteLine("Vowel Count is :" + countVowels);
        }
        


    }

}
