using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPs_Basics
{
    internal class ClassObjects
    {
        class Book
        {
            public string Title;
            public string Author;
            public int Pages;

            public Book(string title, string author, int pages) // this is how you initialize a constructor 
            {
                Title = title;
                Author = author;
                Pages = pages;

            }

            public void DisplayBookInfo()
            {

                Console.WriteLine($"Book Title : {Title}, Author : {Author}, Number of Pages : {Pages}");

            }
        }

        class MobilePhone
        {
            public string Brand;
            public string Model;
            public int BatteryLevel;

            public MobilePhone(string brand, string model, int _batterylevel=100) // Parameterized Constructor
            {
                Brand = brand;
                Model = model;
                BatteryLevel = _batterylevel;
            }
            public void UseBattery(int usage)
            {
                if(usage<BatteryLevel)
                {
                    BatteryLevel -= usage;

                }
                Console.Write($"BatteryLevel : {BatteryLevel}");
            }

            public void ChargeBattery()
            {
                BatteryLevel = 100;
            }
            public void ShowStatus()
            {
                Console.WriteLine($"MobilePhone Brand : {Brand}, PhoneModel : {Model}, Phone's Battery Level: {BatteryLevel}");
            }

        }

        
        public static void Main(string[] args)
        {
            Book b1 = new Book("Harry Potter", "J.K.Rowling", 320);
            b1.DisplayBookInfo();

            Book b2 = new Book("Wings of Fire", "APJ Abdul Kalam", 100);
            b2.DisplayBookInfo();

            MobilePhone m1 = new MobilePhone("Realme", "Narzo 50");
            m1.UseBattery(50);
            m1.ShowStatus();
            
        }

    }
}
