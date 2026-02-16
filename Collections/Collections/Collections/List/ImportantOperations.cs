using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    internal class ImportantOperations
    {
        public static void Main()
        {
            List<int> list = new List<int> { 1,3,5,6,7,8};

            bool isfive = list.Contains(5);

            int ind = list.IndexOf(5);

            list.Insert(3, 20);

            list.Clear();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
