using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Output to match desired result
            Console.WriteLine("Person 1");      //Tells user person 1 input goes below
            Console.WriteLine("Hourly Rate?");   //Persons' 1 hourly rate
            string person1RateString = Console.ReadLine(); //Rate input, as a string. Use descriptive variable names 
            int person1Rate = int.Parse(person1RateString);        //Convert string to int
            Console.WriteLine("Hours worked per week?");   //Persons' 1 hourly rate
            string person1HoursString = Console.ReadLine(); //Hours input (as a string )
            int person1Hours = int.Parse(person1HoursString);        //Convert string to int

            //Make room whenever possible to increase readability
            Console.WriteLine("Person 2");      //Tells user person 2 input goes below
            Console.WriteLine("Hourly Rate?");   //Persons' 1 hourly rate
            string person2RateString = Console.ReadLine(); //Rate input, as a string. Use descriptive variable names 
            int person2Rate = int.Parse(person2RateString);        //Convert string to int
            Console.WriteLine("Hours worked per week?");   //Persons' 2 hourly rate
            string person2HoursString = Console.ReadLine(); //Hours input (as a string )
            int person2Hours = int.Parse(person2HoursString);        //Convert string to int

            Console.WriteLine("Weekly salary of Person 1:");        
            int person1Salary = person1Rate * person1Hours;     //Calculate person 1 salary
            Console.WriteLine(person1Salary);

            Console.WriteLine("Weekly salary of Person 2:");
            int person2Salary = person2Rate * person2Hours; //Calculate person 2 salary
            Console.WriteLine(person2Salary);


            Console.WriteLine("Does Person 1 have more money than Person 2?");
            bool doesPerson1HaveMore = person1Salary > person2Salary;       //Find out if person 1 has more money
            Console.WriteLine(doesPerson1HaveMore);

            Console.ReadLine();     //Pause execution to make sure user reads console
        }
    }
}
