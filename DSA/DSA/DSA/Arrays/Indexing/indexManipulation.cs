using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Indexing
{
    internal class indexManipulation
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            int size = arr.Length;
            arr[0] = 100;
            arr[size - 1] = 200;
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        


    }
}
