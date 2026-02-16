using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    internal class genericMethods
    {
        public void GenMethod<T1,T2>(T1 val1,T2 val2)
        {
            Console.WriteLine($"Gneric Method : {val1} parameter 2: {val2}");
            Console.WriteLine($"Gneric Method : {typeof(T1)} type 2: {typeof(T2)}");

        }

        
    }
    class Program1
    {
        public static void Main(string[] args)
        {
            genericMethods gen1 = new genericMethods();
            gen1.GenMethod<int, int>(12, 434);
            Console.ReadKey();
        }
    }
}
