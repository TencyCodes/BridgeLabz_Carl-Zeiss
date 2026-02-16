using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Dictionary
{
    internal class dic
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(1, 11);
            dict.Add(2, 12);
            dict.Add(3, 13);

            dict[1] = 10;

            dict.Remove(1);

            foreach(KeyValuePair<int,int> entry in dict)
            {
                Console.WriteLine($"{entry.Key}{entry.Value}");
            }
           
        }
        
    }
}
