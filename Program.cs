using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on? ");
        string course = Console.ReadLine();
        Console.WriteLine("What page are you on? ");
        int page = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? ");
        string help = Console.ReadLine();
        Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific. ");
        string posExperience = Console.ReadLine();
        Console.WriteLine("Is there any other feeback you'd like to provide? Please be specific. ");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study? ");
        int hours = int.Parse(Console.ReadLine());
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.Read();

    }
}
