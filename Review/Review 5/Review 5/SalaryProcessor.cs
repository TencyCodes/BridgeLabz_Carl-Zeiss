using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class SalaryProcessor
    {
        public double GetTotalSalary(List<Employee> employees)
        {
            return employees.Sum(e => e.CalculateSalary());
        }

        public double GetAverageSalary(List<Employee> employees)
        {
            if (employees.Count == 0)
                return 0;
            return employees.Average(e => e.CalculateSalary());
        }

        public Employee GetHighestPaid(List<Employee> employees)
        {
            if (employees.Count == 0)
                return null;

            Employee highest = employees[0];

            foreach (var emp in employees)
            {
                if (emp.CalculateSalary() > highest.CalculateSalary())
                    highest = emp;
            }

            return highest;
        }
    }
}
