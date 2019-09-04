using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "This is my first string,";
            string second = " this is my second string,";
            string third = " and this is my third string!!!.";

            third = third.ToUpper();
            string cString = first + second + third;
            StringBuilder fString = new StringBuilder(cString);
            fString.Append("\n...and finally my fourth string");
            Console.WriteLine(fString); 
            Console.ReadLine();

            
        }
    }
}
