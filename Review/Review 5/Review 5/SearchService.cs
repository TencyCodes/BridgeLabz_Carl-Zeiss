using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class SearchService
    {
        public Employee LinearSearchById(List<Employee> employees, int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }

        public Employee BinarySearchById(List<Employee> employees, int id)
        {
            employees.Sort((x, y) => x.Id.CompareTo(y.Id));

            int left = 0;
            int right = employees.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (employees[mid].Id == id)
                    return employees[mid];

                if (employees[mid].Id < id)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
