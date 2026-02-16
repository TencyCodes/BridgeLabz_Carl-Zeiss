using System;
using System.Collections.Generic;
using AddressBook.AddressLogic;
using AddressBook.Contact;

namespace AddressBook
{
    internal class Program
    {
        private static AddressLogic.AddressLogic addressLogic = new AddressLogic.AddressLogic();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nAddressBook Menu");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contacts by First Character");
                Console.WriteLine("3.Display All Contacts");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewContact();
                        break;

                    case "2":
                        DisplayContactsByCharacter();
                        break;
                    case "3":
                        GetAllContacts();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void GetAllContacts()
        {
            List<ContactPerson> allContacts = addressLogic.GetAllContacts();

            if (allContacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("\nAll Contacts:");
            foreach (ContactPerson contact in allContacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        private static void AddNewContact()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            bool result = addressLogic.AddContact(name, email, phoneNumber, address);

            if (result)
            {
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Failed Adding Contact.");
            }
        }

        private static void DisplayContactsByCharacter()
        {
            Console.Write("enter to search: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            char character = input[0];
            List<ContactPerson> contacts = addressLogic.GetContactsByFirstChar(character);

            if (contacts.Count == 0)
            {
                Console.WriteLine($"Contact not ffdound '{char.ToUpper(character)}'");
            }
            else
            {
                Console.WriteLine($"\nContacts starting with '{char.ToUpper(character)}':");
                foreach (ContactPerson contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }
    }
}