using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructors
{
    internal class Chainingandoverloading
    {
        class BankAccount
        {
            string AccountNo;
            string HolderName;
            double Balance;
            string AccountType;

            public BankAccount(string accountNo, string holderName):this(accountNo,holderName,0,"Savings")
            {
                Console.WriteLine("Print 1 stuff");
            }
            public BankAccount(string accountNo, string holderName , double balance) : this(accountNo,holderName,balance , "Savings")
            {
                Console.WriteLine("pritn 2 stuff");

            }
            public BankAccount(string accountNo, string holderName, double balance,string accountType)
            {
                AccountNo=accountNo;
                HolderName = holderName;
                Balance = balance;
                AccountType = accountType;
            }
            public void DisplayAccountInfo()
            {
                Console.WriteLine(AccountNo + HolderName+Balance+AccountType);

            }
            public void Deposit(double amount)
            {
                Balance += amount;
            }
        }
        public static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("ACC001", "Saitama");
            b1.DisplayAccountInfo();

        }
    }
}
