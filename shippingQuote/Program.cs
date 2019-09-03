using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
            Console.WriteLine("Exactly how much does your package weigh:?");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)           
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Exact width of your package?:");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exact height of your package?:");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exact length of your package?:");
            int packLength = Convert.ToInt32(Console.ReadLine());
            int totalDimensions = packWidth + packHeight + packLength;
            if ( totalDimensions > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            int shippingCost = totalDimensions + packWeight;
            Console.WriteLine("Your estimated total for shipping with us today is: $" + (decimal)shippingCost / 100);             
            Console.ReadLine();



        }
    }
}
