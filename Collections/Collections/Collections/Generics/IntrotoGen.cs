using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    public class IntrotoGen
    {
        private static void Main()
        {
            bool isEquals = Calc.AreEqual<int>(123, 1223);
            if (isEquals)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();  
        }

    }
    public class Calc
    {
        //public static bool AreEqual(object val1, object val2) getting different parameters through object 
        //{
        //    return (val1 == val2);
        //}
        //public static bool AreEqual(int val1, int val2)
        //{
        //    return (val1 == val2);
        //}
        //public static bool AreEqual(string val1, string val2)
        //{
        //    return (val1 == val2);
        //}
        //public static bool AreEqual(double val1, double val2)
        //{
        //    return (val1 == val2);
        //}
        //Method Overloading is being done above but it 

        public static bool AreEqual<T>(T value1 , T value2)
        {
            return value1 != null && value1.Equals(value2);
        }
    }
}
