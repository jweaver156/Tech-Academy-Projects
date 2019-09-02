using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string userNumberString = Console.ReadLine();
            uint userNumber = uint.Parse(userNumberString);
            Console.WriteLine(userNumber + " * 50 = " + (userNumber * 50));

            Console.WriteLine("Input a number");
            userNumberString = Console.ReadLine();
            userNumber = uint.Parse(userNumberString);
            Console.WriteLine(userNumber + " + 25 = " + (userNumber + 25));

            Console.WriteLine("Input a number");
            userNumberString = Console.ReadLine();
            userNumber = uint.Parse(userNumberString);
            Console.WriteLine(userNumber + " / 1.25 = " + (userNumber / 1.25));

            Console.WriteLine("Input a number");
            userNumberString = Console.ReadLine();
            userNumber = uint.Parse(userNumberString);
            Console.WriteLine(userNumber + " > 50 ? " + (userNumber > 50));


            Console.WriteLine("Input a number");
            userNumberString = Console.ReadLine();
            userNumber = uint.Parse(userNumberString);
            Console.WriteLine(userNumber + " % 7 = " + (userNumber % 7));

            Console.ReadLine();     //Pause execution for user feedback
        }
    }
}
        
    

