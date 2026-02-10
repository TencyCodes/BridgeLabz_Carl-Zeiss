using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.Generics
{
    /* Problem 3: Write a generic method PrintArray<T>(T[] array).
     * It should loop through the array and print every item.
     * Test it with an integer array and a string array.
     */
    internal class Problem3
    {

        public static void PrintArray<T>(T[] array)
        {
            foreach (T i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] num = [1, 2, 4, 5, 6, 7, 8, 9,];
            PrintArray<int>(num);

            bool[] gamble = [true, false, true, true, false];
            PrintArray<bool>(gamble);

            

        }
    }
}
