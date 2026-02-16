using System;

namespace AddressBook.Contact
{
    internal class LinkedLiat<T>
    {
        T data
        private static int IDCounter = 0;

        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ContactPerson(string name, string email, string phoneNumber, string address)
        {
            Id = ++IDCounter;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString() //object class and their methods read about it
            //types of generics 
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}";
        }
    }
}