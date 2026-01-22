using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPs_Basics
{
    internal class PublicandPrivateFields
    {
        class Employee
        {
            public string Name;
            public int Id;
            public double Salary;

            public Employee(string name,int id,double salary)
            {
                Name = name;
                Id = id;
                Salary = salary;
            }
            
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee Name : {Name}, Employee Id: {Id} , Employee Salary : {Salary}");
            }

        }
        class Circle
        {
            private double Radius;

            public Circle (double radius)
            {
                if(radius > 0)
                {
                    Radius = radius;
                }
                else
                {
                    radius = 1.0;
                    Radius = radius;
                }
            }
            public void GetRadius()
            {
                Console.WriteLine($"radius of Circle is : {Radius}");
            }
            public void SetRadius(double newradius)
            {
                if (newradius > 0)
                {
                    Radius = newradius;
                }
                
            }
            public void CalculateArea()
            {
                Console.WriteLine($"Area : {Math.PI * Radius * Radius} Square Units");
            }

            public void Circumference()
            {
                Console.WriteLine($"Circumference : {2 * Math.PI * Radius}");
            }


        }
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Tency",137,2000000.00);
            emp1.DisplayEmployeeInfo();

            Circle c1 = new Circle(5.0);
            c1.GetRadius();
            c1.SetRadius(9.0);
            c1.GetRadius();
            c1.CalculateArea();
            c1.Circumference();
        }
    }
}
