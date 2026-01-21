using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.OOPs
{
    internal class BankingManagementSystem
    {
        internal class BankAccount
        {
            
            private string accountNumber;
            private string accountHolderName;
            private double balance;
            
            public BankAccount(string account_Number, string account_HolderName , double balance_)
            {
                accountNumber = account_Number;
                accountHolderName = account_HolderName;
                balance = balance_;

            }
            public void  Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount");
                }

            }

            public double CheckBalance()
            {
                return balance;
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount<= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn : {amount} and New Balance : {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient Funds or Invalid Amount");
                }
       
            }
            public void GetAccountInfo()
            {
                Console.WriteLine($"Account Holder Name : {accountHolderName}, Account: {accountNumber}, Balance: {balance} ");
            }


        }
    }
}
