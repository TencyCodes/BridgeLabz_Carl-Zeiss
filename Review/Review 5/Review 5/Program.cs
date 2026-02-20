using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            SalaryProcessor processor = new SalaryProcessor();
            SearchService search = new SearchService();
            FileManager fileManager = new FileManager();

            try
            {
                FullTimeEmployee e1 = new FullTimeEmployee
                {
                    Id = 1,
                    Name = "Arjun Mehta",
                    Email = "neha@zeiss.com",
                    Phone = "9876543210",
                    Department = "IT",
                    MonthlySalary = 80000
                };

                PartTimeEmployee e2 = new PartTimeEmployee
                {
                    Id = 2,
                    Name = "Neha Sharma",
                    Email = "neha@zeiss.com",
                    Phone = "9123456789",
                    Department = "HR",
                    HourlyRate = 500,
                    HoursWorked = 80
                };

                ContractEmployee e3 = new ContractEmployee
                {
                    Id = 3,
                    Name = "Rohit Verma",
                    Email = "rohit@zeiss.com",
                    Phone = "9988776655",
                    Department = "IT",
                    ContractAmount = 60000
                };

                manager.AddEmployee(e1);
                manager.AddEmployee(e2);
                manager.AddEmployee(e3);

                var employees = manager.GetAllEmployees();

                // View All Employees
                Console.WriteLine("\n--- All Employees ---");
                Console.WriteLine($"{"ID",-5} {"Name",-20} {"Email",-25} {"Phone",-12} {"Department",-10} {"Type",-12} {"Salary",12}");
                Console.WriteLine(new string('-', 100));

                foreach (var emp in employees)
                {
                    string empType = emp switch
                    {
                        FullTimeEmployee => "Full-Time",
                        PartTimeEmployee => "Part-Time",
                        ContractEmployee => "Contract",
                        _ => "Unknown"
                    };
                    Console.WriteLine($"{emp.Id,-5} {emp.Name,-20} {emp.Email,-25} {emp.Phone,-12} {emp.Department,-10} {empType,-12} {emp.CalculateSalary(),12:N2}");
                }
                Console.WriteLine($"\nTotal Employees: {employees.Count}");

                Console.WriteLine("\n--- Salary Statistics ---");
                Console.WriteLine("Total Salary: " + processor.GetTotalSalary(employees));
                Console.WriteLine("Average Salary: " + processor.GetAverageSalary(employees));
                Console.WriteLine("Highest Paid: " + processor.GetHighestPaid(employees).Name);

                var found = search.BinarySearchById(employees, 2);
                if (found != null)
                    Console.WriteLine("\nFound Employee: " + found.Name);

                Console.WriteLine("Duplicate Email: " + manager.FindFirstDuplicateEmail());

                fileManager.SaveToFile(employees);

                Console.WriteLine("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}