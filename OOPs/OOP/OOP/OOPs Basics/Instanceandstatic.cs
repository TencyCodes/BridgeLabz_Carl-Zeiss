using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPs_Basics
{
    internal class Instanceandstatic
    {
        class BankAccount
        {
            //below 3 are instance members/fields
            private string AccountHolderName;
            private int AccountNumber;
            private double Balance;

            private static int totalAccounts = 0; //static member/field

            public BankAccount(string accountholdername, int accountnumber , double balance )
            {
                AccountHolderName = accountholdername;
                AccountNumber = accountnumber;
                Balance = balance;

                // increment totalAccounts everytime an instance of this class is created
                totalAccounts++;
            }

            public void Deposit(double amount)
            {
                if(amount>0) Balance += amount;

            }
            public void DisplayAccountInfo()
            {
                Console.WriteLine($"Holder-Name : {AccountHolderName} , Account-Number : {AccountNumber} , Account-Balance : {Balance}");
            }
            public static void TotalAccounts() //static method
            {
                Console.WriteLine($"Total Accounts :{totalAccounts}");
            }

        }
        class StudentGradeSystem
        {
            //Complete it later
        }
        public static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Rahul", 001321213, 5000);
            acc1.DisplayAccountInfo();
            BankAccount.TotalAccounts();

            BankAccount acc2 = new BankAccount("Paul Blanco", 676869, 1000000);
            acc2.DisplayAccountInfo();
            BankAccount.TotalAccounts();
        }
    }
}
