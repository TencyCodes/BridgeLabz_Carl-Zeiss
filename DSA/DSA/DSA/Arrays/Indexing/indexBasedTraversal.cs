using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Indexing
{
    internal class indexBasedTraversal
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 15, 25, 35 };

            int size = arr.Length;

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Index {i} -> {arr[i]}");
            }

        }
    }
}
