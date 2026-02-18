using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOStream.Streams
{
    internal class CreateFile
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "TestFile.txt");
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.CreateNew)) 
                {
                    Console.WriteLine("file created successfully");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File Already exists");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program Finished ");
        }

    }
}

