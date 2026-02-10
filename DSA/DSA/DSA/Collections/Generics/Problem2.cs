using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DSA.Collections.Generics.Problem2;

namespace DSA.Collections.Generics
{
    internal class Problem2
    {
        public class Pair<TFirst, TSecond>
        {
            public TFirst First{ get; set; }
            public TSecond Second{ get; set; }

            public Pair(TFirst first , TSecond second)
            {
                First = first;
                Second = second;
            }
        }
            public static void Main(string[] args)
            {
                Pair<int, string> pair = new Pair<int, string>(101, "carreras");
                Console.WriteLine($"First : {pair.First}");
                Console.WriteLine($"Second : {pair.Second}");
            }
    }
    
}
