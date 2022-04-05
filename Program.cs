using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AddressBookManagement_Day23
{
    public class program
    {
        public static void Main(string[] args)
        {

            List<string> AddressBook = new List<string>();

            Console.WriteLine("Welcome to Address Book Program");

            Console.Write("Enter First Name: ");
            AddressBook.Add(Console.ReadLine());

            Console.Write("Enter Last Name: ");
            AddressBook.Add(Console.ReadLine());

            Console.Write("Enter Address : ");
            AddressBook.Add(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            AddressBook.Add(Console.ReadLine());

            Console.Write("Enter Email: ");
            AddressBook.Add(Console.ReadLine());

            Console.WriteLine("Iterating names of person");
          
            foreach(string s in AddressBook)
            {
                Console.Write(s);
            }
  
        }
    } 
}
