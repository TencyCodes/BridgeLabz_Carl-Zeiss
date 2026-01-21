using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Methods
{
    internal class MethodsPractice
    {
        void SimpleInterest(double principal , double rate , double time)
        {
            double SI = (principal * rate * time) / 100;
            Console.WriteLine(SI);
        }
        public static void Main(string[] args)
        {
            MethodsPractice obj = new MethodsPractice();
            Console.WriteLine("Enter the Principal");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time");
            double time = Convert.ToDouble(Console.ReadLine());

            obj.SimpleInterest(principal, rate, time);
        }
    }
}
