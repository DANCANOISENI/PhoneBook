using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Phone Book Menu:");
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Search contact");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        SearchContact();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddContact()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine();

            Console.Write("Enter contact number: ");
            string number = Console.ReadLine();

            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = number;
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Contact already exists.");
            }
        }

        static void SearchContact()
        {
            Console.Write("Enter contact name to search: ");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                string number = phoneBook[name];
                Console.WriteLine($"Contact found: {name} - {number}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
