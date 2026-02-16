using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    internal class ListBasic
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            //add
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            //read
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            //update
            numbers[1] = 7;
            numbers[2] = 8;

            numbers.Remove(1);
            numbers.RemoveAt(2);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

        }



    }
}
