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


            //6-8
            List<string> seasons = new List<string>() { "Summer", "Fall", "Winter", "Spring" };
            Console.WriteLine("What is your favorite season here in Portland?");
            string favSeason = Console.ReadLine();
            
            foreach (string season in seasons)
            {
                if (favSeason == "Summer")
                {
                    Console.WriteLine(seasons.IndexOf(favSeason));
                    Console.WriteLine("It's hard to beat the beautiful \nsummers here in Portland!");
                    Console.ReadLine();
                    break;
                }
                else if (favSeason == "Winter")
                {
                    Console.WriteLine(seasons.IndexOf(favSeason));
                    Console.WriteLine("Relaxing rain...");
                    Console.ReadLine();
                    break;
                }
                else if (favSeason == "Fall")
                {
                    Console.WriteLine(seasons.IndexOf(favSeason));
                    Console.WriteLine("The range of colors in nature can be quite a sight.");
                    Console.ReadLine();
                    break;
                }
                else if (favSeason == "Spring")
                {
                    Console.WriteLine(seasons.IndexOf(favSeason));
                    Console.WriteLine("Almost river weather..");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong text");
                    Console.ReadLine();
                    break;
                }
            }
            Console.ReadLine();

            //9,10
            List<string> colors = new List<string>() { "Red", "Blue", "Green" };
            Console.WriteLine("Choose your favorite color.");
            string favColor = Console.ReadLine();
            int indexBlue = colors.IndexOf("Blue");
            foreach (string color in colors)
            {
                if (favColor == "Blue")
                {
                    Console.WriteLine(colors.IndexOf("Blue"));
                    Console.ReadLine();
                    break;
                }
                else if (favColor == "Red")
                {
                    Console.WriteLine(colors.IndexOf("Red"));
                    Console.ReadLine();
                    break;
                }
                else if (favColor == "Green")
                {
                    Console.WriteLine(colors.IndexOf("Green"));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Text not in list");
                    Console.ReadLine();
                    break;
                }
            }
            Console.ReadLine();

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
        
    

