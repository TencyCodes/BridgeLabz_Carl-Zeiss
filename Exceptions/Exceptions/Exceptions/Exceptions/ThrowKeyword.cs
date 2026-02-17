using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    internal class ThrowKeyword
    {
        public static void Main(string[] args)
        {
            try
            {
                ThrowKeyword th = new ThrowKeyword();
                th.ValidAge(17);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
        public void ValidAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("age should be above 18");
            }
        }
    }
}
