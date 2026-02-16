using System;
using System.Collections.Generic;
using AddressBook.Contact;

namespace AddressBook.AddressLogic
{
    internal class AddressLogic 
    {
        
        private Dictionary<char, List<ContactPerson>> contacts;

        
        private HashSet<string> emails;

        
        public AddressLogic()
        {
            contacts = new Dictionary<char, List<ContactPerson>>();
            emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        public bool AddContact(string name, string email, string phoneNumber, string address)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            if (emails.Contains(email))
            {
                return false; 
            }
            char firstLetter = char.ToUpper(name[0]);

            ContactPerson newContact = new ContactPerson(name, email, phoneNumber, address);
            Console.WriteLine(newContact);
            if (contacts.ContainsKey(firstLetter) == false)
            {
                
                contacts[firstLetter] = new List<ContactPerson>();
            }
            contacts[firstLetter].Add(newContact);
            emails.Add(email);
            return true; 
        }

        public List<ContactPerson> GetContactsByFirstChar(char character)
        {
            char searchKey = char.ToUpper(character);

            if (contacts.ContainsKey(searchKey))
            {
                
                return contacts[searchKey];
            }
            else
            {
                
                return new List<ContactPerson>();
            }
        }

        public List<ContactPerson> GetAllContacts()
        {
            List<ContactPerson> allContacts = new List<ContactPerson>();
            foreach (char key in contacts.Keys)
            {
                
                List<ContactPerson> contactsForThisLetter = contacts[key];

                
                foreach (ContactPerson contact in contactsForThisLetter)
                {
                    
                    allContacts.Add(contact);
                }
            }

            return allContacts;
        }
    }
}