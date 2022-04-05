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
            Console.WriteLine("which address book do you enter1 or 2");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
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

                foreach (string s in AddressBook)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n enter the name you want to edit");
                string EditName = Console.ReadLine();
                Console.WriteLine("Enter the name to be replaced with");
                string ReplaceName = Console.ReadLine();
                for (int i = 0; i < AddressBook.Count; i++)
                {
                    if (AddressBook[i].Contains(EditName)) ;
                    AddressBook[i] = ReplaceName;
                }
                foreach (string s in AddressBook)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n enter the name you want to delete");
                string DeleteName = Console.ReadLine();

                for (int i = 0; i < AddressBook.Count; i++)
                {
                    if (AddressBook[i].Contains(DeleteName)) ;
                    AddressBook.Remove(AddressBook[i]);
                }
                foreach (string s in AddressBook)
                {
                    Console.WriteLine(s);
                }

            }
            else
            {
                HashSet<string> AddressBook2 = new HashSet<string>;
                Console.Write("Enter First Name: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Last Name: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Address : ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Phone Number: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Email: ");
                AddressBook2.Add(Console.ReadLine());

                Console.WriteLine("Iterating names of person");

                foreach (string m in AddressBook2)
                {
                    Console.WriteLine(m);
                }
            }
        }
    } 
}
