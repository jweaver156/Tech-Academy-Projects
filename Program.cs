using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. and 5.
            try
            {
                List<int> numList = new List<int> { 200, 400, 600, 800 };
                Console.WriteLine("Enter a number single digit non negative whole number.");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numList)
                {
                    Console.WriteLine(num / divideBy);
                }
                Console.ReadLine();
            }  
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
                return;
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
                return;
            }
            finally
            {                
                Console.ReadLine();
            }
            Console.WriteLine("You have made it through the try catch block.");
            Console.ReadLine();
            //2. Entered 8 and the console read: 25 50 75 100.

            //3. Entered 0 and received a System.DivideByZeroException error.

            //4. Entered a string and the console returned a System.FormatException error.

        }
    }
}
