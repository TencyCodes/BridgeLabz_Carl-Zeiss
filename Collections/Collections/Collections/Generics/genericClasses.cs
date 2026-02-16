using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    class genericClasses<T>
    {
        private T genericField;

        public genericClasses(T val)
        {
            genericField = val;

        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine($"Parameter:{genericParameter}");
            return genericField;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            genericClasses<int> intObj = new genericClasses<int>(100);
            intObj.genericMethod(200);
            int result = intObj.genericMethod(400);
            Console.WriteLine(result);

        }
    }

}
