using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? True or False? ");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = int.Parse(Console.ReadLine());
            bool qualified = (age > 15 && dui == "False" && tickets <= 3);
            Console.Write("Qualified: ");
            Console.WriteLine(qualified);
            Console.ReadLine();


        }
    }
}
