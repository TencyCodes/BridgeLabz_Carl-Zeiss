using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PillarsRevision
{
    internal class Inheritance
    {
        class Employee
        {
            public string name;
            public int empId;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name : {name}, Empid : {empId}, Age : {age} ");
            }
        }
        class Developer : Employee
        {
            public string role;

            public void DisplayDevInfo()
            {
                base.DisplayInfo(); 
                Console.WriteLine($"Role : {role}");
            }
        }
        
        public static void Main(string[] args)
        {
            
        }
        class Account
        {
            private string accountHolderName;
            private int accountNumber;
            private double balance;

            public Account(string accountHolderName, int accountNumber, double balance)
            {
                this.accountHolderName = accountHolderName;
                this.accountNumber = accountNumber;
                this.balance = balance;
            }
            public void DisplayAccountInfo()
            {
                Console.WriteLine($"AccountHolder Name: {accountHolderName}, AccountNumber : {accountNumber}, Balance: {balance}");
            }

        }

    }
}
