using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.Generics
{
    internal class Problem1
    {
        public class Wrapper<T>
        {
            public T value { get; set; }
            public Wrapper(T value)
            {
                this.value = value;
            }
        }
        public static void Main(string[] args)
        {
            Wrapper<bool> wrapper = new Wrapper<bool>(true);
            

            Wrapper<double> wrapper1 = new Wrapper<double>(7.0);
            

            Console.WriteLine($"value of boolwrapper: {wrapper.value}");
            Console.WriteLine($"value of doublewrapper: {wrapper1.value}");
            
        }
    }
}
