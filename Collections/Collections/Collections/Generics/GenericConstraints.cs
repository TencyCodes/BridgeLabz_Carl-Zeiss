using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    internal class GenericConstraints<T> where T:class
    {
        public T genericField;
        public GenericConstraints(T genericField)
        {
            this.genericField = genericField;
        }
        public void GenericMethod(T val1, T val2)
        {
            Console.WriteLine($"Field : {genericField}");
            Console.WriteLine($"Parameter1 : {val1}");
            Console.WriteLine($"Parameter2 : {val2}");
        }
    }
    class Program3
    {
        public static void Main(string[] args)
        {   
            GenericConstraints<string> gen1 = new GenericConstraints<string>("ABC");
            gen1.GenericMethod("Mok", "sh");

        }
    }
}
