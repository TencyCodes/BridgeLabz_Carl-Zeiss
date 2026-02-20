using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Review_5
{
    public abstract class Employee
    {
        //Adding Properties of each employee keeping them private using Access Modifier
        private int id;
        private string name;
        private string email;
        private string phone;
        private string department;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set
            { //validate name
                if (!Regex.IsMatch(value, @"^[A-Za-z\s]{3,50}$"))
                    throw new ValidationException("Invalid Name");

                name = value; 
            }
        }
        public string Email
        {
            get { return email; }
            set
            { //validate Email
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    throw new ValidationException("Invalid Email");
                }
                    
                email = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9]{10}$"))
                    throw new ValidationException("Invalid Phone");
                phone = value;
            }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public abstract double CalculateSalary();
    }
    
}
