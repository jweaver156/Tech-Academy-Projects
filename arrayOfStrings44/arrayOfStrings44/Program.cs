using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayOfStrings44
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = {"red", "blue", "green"};
            Console.WriteLine("Choose a number between 0-2");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());
            if (chosenNumber > 2)
            {
                Console.WriteLine("Error, number too large");
            }
            Console.WriteLine(stringArray[chosenNumber]);
            Console.ReadLine();

            int[] integerArray = { 5, 10, 15, 20 };
            Console.WriteLine("Type a number between 0-3");
            int chosenInteger = Convert.ToInt32(Console.ReadLine());
            if (chosenInteger > 3)
            {
                Console.WriteLine("Error, number too large");
            }
            Console.WriteLine(integerArray[chosenInteger]);
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("Welcome");
            stringList.Add("To");
            stringList.Add("Football");
            stringList.Add("Season");
            Console.WriteLine("Choose a number between 0-3");
            int listNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[listNumber]);
            Console.ReadLine();


        }
    }
}
