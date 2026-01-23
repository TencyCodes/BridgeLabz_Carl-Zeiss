using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructors
{
    internal class DefaultConstructor
    {
        class Student
        {
            private string Name;
            private int Rollno;
            private int Marks;
            private string Grade;

            public Student() //Default Constructor
            {
                Name = "Unknown";
                Rollno = 0;
                Marks = 0;
                Grade = "Not Assigned";
            }

            public Student(string name, int rollno)
            {
                Name = name;
                Rollno = rollno;
                Marks = 0;
                Grade = "Not Assigned";
            }
            public Student(string name, int rollno, int marks)
            {
                Name = name;
                Rollno = rollno;
                Marks = marks;

                CalculateGrade();
                
            }
            private void CalculateGrade()
            {
                if (Marks >= 90)
                    Grade = "A+";
                else if (Marks >= 75)
                    Grade = "A";
                else if (Marks >= 60)
                    Grade = "B";
                else if (Marks >= 40)
                    Grade = "C";
                else
                    Grade = "F";
            }
            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"RollNo : {Rollno}");
                Console.WriteLine($"Marks : {Marks}");
                Console.WriteLine($"Grade : {Grade}");
            }
        }
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.DisplayStudentInfo();
            Student s2 = new Student("Rishu" ,101);
            s2.DisplayStudentInfo();
            Student s3 = new Student("Priya", 102, 9);
            s3.DisplayStudentInfo();
        }
    }
}
