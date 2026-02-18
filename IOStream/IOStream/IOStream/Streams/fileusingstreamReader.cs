using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IOStream.Streams
{
    internal class fileusingstreamReader
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "File2.txt");

            using(FileStream fs = new FileStream(path,FileMode.Open, FileAccess.Read))
            using(StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("FileContent");
                Console.WriteLine(content);

            }
            Console.WriteLine("Program Executed Successfully");
        }
    }
}
