using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArraysLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] bestAuthors = { "Michael Heiser", "Carl Teichrib", "David Flynn" };
            Console.WriteLine("Name your favorite author.");
            string lesser = Console.ReadLine();
            for (int i = 0; i < bestAuthors.Length; i++)
            {
                Console.WriteLine(bestAuthors[i] + " is a superior author compared to " + lesser);
            }
            Console.ReadLine();

            //2-3
            while (true)
            {
                Console.WriteLine("INFINITE LOOOOOOOP!");
                Console.WriteLine("infinite loop no more..");
                break;
            }
            Console.ReadLine();

            //4
            int x = 1;
            while (x < 4)
            {
                Console.WriteLine("Less than three");
                x++;
            }
            Console.ReadLine();

            //5
            int xx = 1;
            while (xx <= 5)
            {
                Console.WriteLine("Less Than Four");
                xx++;
            }
            Console.ReadLine();

            //6-10
            var strings = new List<string>
            {
                "This",
                "Is",
                "A",
                "Unique",
                "List",
                "Of",
                "Strings"
            };

            Console.WriteLine("Enter text to search the unique list of string for: ");
            var input = Console.ReadLine();
            var matchFound = false;
            strings.ForEach(s =>
            {
                if (s == input)
                {
                    matchFound = true; Console.WriteLine($"Match found at index: {strings.IndexOf(s)}");
                }
            });
            if (!matchFound)
            {
                Console.WriteLine("No match found");
            }
            matchFound = false;
            strings = new List<string>
            {
                "This",
                "Is",
                "Not",
                "Not",
                "Not",
                "A",
                "Unique",
                "List",
                "Of",
                "Strings"
            };

            input = Console.ReadLine();
            matchFound = false;
            strings.ForEach(s =>
            {
                if (s == input)
                {
                    matchFound = true; Console.WriteLine($"Match found at index: {strings.IndexOf(s)}");
                }
            });
            if (!matchFound)
            {
                Console.WriteLine("No match found");
            }

            //11.
            int index = 0;
            string[] stringarr = new string[] { "Element 1", "Element 2", "Element 3", "Element 0", "Element 1", "Element 3", "Element 2", "Element 4" };

            foreach (var item in stringarr)
            {
                int count = 1;

                for (int i = 0; i < index; i++)
                {
                    if (item == stringarr[i])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(item + " has already appeared");
                }
                else
                {
                    Console.WriteLine(item + " did not appeared before");
                }
                index++;
            }
            Console.ReadLine();
        }
    }
}
        
    

