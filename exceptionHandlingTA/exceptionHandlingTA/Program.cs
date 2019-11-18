using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstlist = new List<int>() { 11, 22, 33, 44 };

            try     
            {
                Console.Write("Enter a number:");    
                int num = Convert.ToInt32(Console.ReadLine());  
               
                foreach (int item in firstlist)     
                {
                    Console.WriteLine(item + " / " + num + " = " + item / num);  
                }
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("divide by zero exception raised");   
            }
            catch (FormatException) 
            {
                Console.WriteLine("Wrong format used"); 
            }
            finally     
            {
                Console.WriteLine("-----finally block executed-----");  
            }

            Console.WriteLine("rest of the program"); 
            Console.ReadLine();
        }
    }

}
