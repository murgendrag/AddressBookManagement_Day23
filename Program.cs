using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement_Day23
{
    public class Person
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddPerson NewContact = new AddPerson();

            Console.Write("Enter First Name: ");
            NewContact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            NewContact.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            NewContact.Address = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            NewContact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            NewContact.Email= Console.ReadLine();

        }

        private static void PrintPerson(AddPerson person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("Email:" +person.Email);
            Console.WriteLine("-------------------------------------------");
        }
    }
    
}
