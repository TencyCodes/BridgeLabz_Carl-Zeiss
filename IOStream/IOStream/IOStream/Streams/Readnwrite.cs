using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOStream.Streams
{
    internal class Readnwrite
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "File2.txt");
            try
            {
                using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    string text = "C# File Written";
                    byte[] data = Encoding.UTF8.GetBytes(text);
                    fs.Write(data, 0, data.Length);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("File already exists");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program Executed Successfully");
        }
    }
}
