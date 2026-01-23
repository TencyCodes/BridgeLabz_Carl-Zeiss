using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPs_Basics
{
    internal class @readonly
    {
        class BankAccount
        {
            public readonly string AccountNumber;

            public BankAccount(string accNumber)
            {
                AccountNumber = accNumber;

            }
            public void ChangeAccountNo()
            {
               // AccountNumber = "fsdakjds";  Not Allowed
            }

        }
        public static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("ABC123");
            Console.WriteLine(b1.AccountNumber);
        }
    }
}
