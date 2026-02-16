using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    internal class structConstraint<T> where T : struct 
    {
        public T Message;

        public void GenericMethod(T param1 , T param2)
        {
            Console.WriteLine($"Message : {Message}");
            Console.WriteLine($"Param1 : {param1}");
            Console.WriteLine($"Param2 : {param2}");
        }
    }
    class Program5
    {
        public static void Main(string[] args)
        {
            structConstraint <int>num1 = new structConstraint<int>();
            num1.Message = 10;
            num1.GenericMethod(1, 2);   
        }
    }
    
}
