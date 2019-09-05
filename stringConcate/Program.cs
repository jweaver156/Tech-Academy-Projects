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
            string aString = first + second + third;
            Console.WriteLine(aString);

            StringBuilder myPara = new StringBuilder("\tI really enjoy the formatting of this C# course.");
            myPara.Append("I like how the drills are immediately following a lesson, rather than fifty pages later.");
            myPara.Append("The flow ensures a good understanding of the material, and I'm having a lot of fun in the process.");
            myPara.Append("I'm really looking forward to learning what else is in store.");
            Console.WriteLine(myPara);
            Console.ReadLine();


        }
    }
}
