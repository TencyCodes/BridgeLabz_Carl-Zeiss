using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class FileManager
    {
        private string path = "employees.txt";

        public void SaveToFile(List<Employee> employees)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var emp in employees)
                {
                    writer.WriteLine(emp.Id + "," + emp.Name + "," + emp.Email + "," + emp.Phone + "," + emp.Department + "," + emp.CalculateSalary());
                }
            }
        }

        public List<string> ReadFromFile()
        {
            List<string> data = new List<string>();
            if (!File.Exists(path))
                return data;

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            return data;
        }
    }
}
