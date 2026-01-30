using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Traversal
{
    internal class ReversalTraversal
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int size = arr.Length;

            for(int i = size - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
