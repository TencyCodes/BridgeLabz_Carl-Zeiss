using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Revision
{
    internal class HospitalManagementSystem
    {
        class Person
        {
            //Fields Creation
            private int id;
            protected string name;
            private int age;

            //Properties (decides which fields can be read and which could be read and written both)
            public int Id { get { return id; } } //controlled access
            public string Name { get { return name; } set {name=value; } }
            public int Age { get { return age; } set { age = value; } }

            public Person(int _id , string _name, int _age)
            {
                if(_age<0)
                {
                    throw new ArgumentException("Age cannot be Negative");
                }
                if (string.IsNullOrEmpty(_name))
                {
                    throw new ArgumentException("Name cannot be Null");
                }
                id = _id;
                name = _name;
                age = _age;
            }
            public virtual void DisplayInfo()
            {
                //Console.WriteLine($"Id : {id}, Name : {name}, Age : {age}"); using fields
                Console.WriteLine($"Id : {Id}, Name : {Name}, Age : {Age}");  //using Properties
            }

        }
        class Patient : Person
        {
            private string disease;
            private readonly string patientId;

            public string Disease { get; set; }
            public string PatientId { get; }
            


            public Patient(string _name,int _age, string _disease) : base( 0,_name,_age )
            {

            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person(221100, "Park Gyu Young", 28);
            person1.DisplayInfo();
            Console.WriteLine("-------------");

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Id);
            Console.WriteLine(person1.Age);

            Console.WriteLine("-------------");

            person1.Name = "Park seo joon";
            person1.Age=32;
            person1.DisplayInfo();
        }
    }
}
