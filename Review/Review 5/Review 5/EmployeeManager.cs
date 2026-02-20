using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class EmployeeManager
    {   
            private Dictionary<string, List<Employee>> departmentEmployees = new Dictionary<string, List<Employee>>();

            public void AddEmployee(Employee emp)
            {
                if (!departmentEmployees.ContainsKey(emp.Department))
                    departmentEmployees[emp.Department] = new List<Employee>();

                departmentEmployees[emp.Department].Add(emp);
            }

            public List<Employee> GetAllEmployees()
            {
                return departmentEmployees.Values.SelectMany(x => x).ToList();
            }

            public Dictionary<string, List<Employee>> GetGroupedByDepartment()
            {
                return departmentEmployees;
            }

            public string FindFirstDuplicateEmail()
            {
                HashSet<string> emails = new HashSet<string>();
                foreach (var emp in GetAllEmployees())
                {
                    if (!emails.Add(emp.Email))
                        return emp.Email;
                }
                return null;
            }
    }
}
