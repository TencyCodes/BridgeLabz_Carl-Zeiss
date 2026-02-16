using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Hashset
{
    internal class hashsetbasic
    {
        public static void Main(string[] args)
        {
            HashSet<int> has = new HashSet<int>();

            has.Add(1);
            has.Add(2);
            has.Add(3);

            Console.WriteLine(has.Count);

            bool isalive = has.Contains(2);
            Console.WriteLine(isalive);
            has.Remove(3);

            foreach(int i in has)
            {
                Console.WriteLine(i);
            }
        }
    }
}
