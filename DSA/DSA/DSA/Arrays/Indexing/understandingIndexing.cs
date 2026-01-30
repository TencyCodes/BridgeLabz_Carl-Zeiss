using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Indexing
{
    internal class understandingIndexing
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int size = arr.Length;

            Console.WriteLine($"Value at Index 0 : {arr[0]}");
            Console.WriteLine($"Value at Index (length-1) {arr[size-1]}");
            int index = 0;
            foreach(int i in arr)
            {
                if(i==30)
                {
                    Console.WriteLine($"Index at which 30 is located : {index}");
                }
                index++;
            }
            
        }
    }
}
