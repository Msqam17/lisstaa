using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6_namn_sortering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<string> names = InitializeNames();
                DisplayNames("Original list:", names);

                names.Sort(); // Sort the names alphabetically
                DisplayNames("\nSorted list:", names);

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
            static void SearchName(List<string> names)
            {
                Console.WriteLine("\nEnter name to search:");
                string searchName = Console.ReadLine();

                // Felhantering för användarinmatning
                if (string.IsNullOrWhiteSpace(searchName))
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    return;
                }

                Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
            Console.ReadKey();
        }
    }
}
