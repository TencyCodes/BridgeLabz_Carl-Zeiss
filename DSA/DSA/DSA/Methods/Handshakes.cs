using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Methods
{
    internal class Handshakes
    {
        public static int handshakes(int numStudents)
        {
            numStudents = (numStudents * (numStudents - 1)) / 2;
            return numStudents;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int students = Convert.ToInt32(Console.ReadLine());

           int result =  handshakes(students);
           Console.WriteLine("Number of Handshakes : " + result);

        }
    }
}
