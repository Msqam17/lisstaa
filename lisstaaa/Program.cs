using System;
using System.Collections.Generic;

namespace Uppgift_6_namn_sortering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = InitializeNames();
            DisplayNames("Original list:", names);

            // Sortera namn
            List<string> sortedNames = SortNames(names);
            DisplayNames("\nSorted list:", sortedNames);

            SearchName(names);
            Console.ReadKey();
        }

        static List<string> InitializeNames()
        {
            return new List<string> { "Anna", "John", "Alice", "Bob", "Carols" };
        }

        static void DisplayNames(string title, List<string> names)
        {
            Console.WriteLine(title);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static List<string> SortNames(List<string> names)
        {
            // Sortera listan och returnera
            names.Sort(StringComparer.CurrentCulture);
            return names;
        }

        static void SearchName(List<string> names)
        {
            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();

            // Felhantering för userinmatning
            if (string.IsNullOrWhiteSpace(searchName))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                return;
            }

            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
        }
    }
}