using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); 
            Console.WriteLine("Person 1");      
            Console.WriteLine("Hourly Rate?");  
            string person1RateString = Console.ReadLine(); 
            int person1Rate = int.Parse(person1RateString);        
            Console.WriteLine("Hours worked per week?");   
            string person1HoursString = Console.ReadLine(); 
            int person1Hours = int.Parse(person1HoursString);        

            
            Console.WriteLine("Person 2");      
            Console.WriteLine("Hourly Rate?");   
            string person2RateString = Console.ReadLine();  
            int person2Rate = int.Parse(person2RateString);        
            Console.WriteLine("Hours worked per week?");   
            string person2HoursString = Console.ReadLine(); 
            int person2Hours = int.Parse(person2HoursString);        

            Console.WriteLine("Weekly salary of Person 1:");
            int person1Salary = person1Rate * person1Hours;     
            Console.WriteLine(person1Salary);

            Console.WriteLine("Weekly salary of Person 2:");
            int person2Salary = person2Rate * person2Hours; 
            Console.WriteLine(person2Salary);


            Console.WriteLine("Does Person 1 have more money than Person 2?");
            bool doesPerson1HaveMore = person1Salary > person2Salary;       
            Console.WriteLine(doesPerson1HaveMore);

            Console.ReadLine();     
        }
    }
}
        
    

