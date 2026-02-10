using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.Generics
{
    internal class Problem4
    {
        class Factory<T> where T : new()
        {
            
            public T CreateNew()
            {
                return new T();
            }
            
        }

        class Singer
        {
            public string name { get; set; }
            public Singer()
            {
                name = "Ado";
                Console.WriteLine("Ado created");
            }
        }

        public static void Main(string[] args)
        {
            Factory <Singer>singer = new Factory<Singer>();

            Singer singer1 =  singer.CreateNew();

            Console.WriteLine($"Name : {singer1.name}");
            

        }

    }
}
