﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pop Quiz!");
            Console.WriteLine("Choose the most beautiful state in America to live in or visit:");
            string state = Console.ReadLine();
            bool correctState = state == "Oregon";

            do
            {
                switch (state)
                {
                    case "California":
                        Console.WriteLine("Oregon is full, go back home.");
                        Console.WriteLine("And you broke my progam...");
                        Console.Read();
                        System.Environment.Exit(0);
                        break;
                    case "Illinois":
                        Console.WriteLine("Chicago is beautiful, but those winters...No.");
                        Console.WriteLine("Try again");
                        state = Console.ReadLine();
                        break;
                    case "Nevada":
                        Console.WriteLine("The desert? No.");
                        Console.WriteLine("Try again");
                        state = Console.ReadLine();
                        break;
                    case "Washington":
                        Console.WriteLine("Very close, and also, very beautiful, but no. Think more beautiful...");
                        Console.WriteLine("Try again");
                        state = Console.ReadLine();
                        break;
                    case "Oregon":
                        Console.WriteLine("You've guessed correctly, although, while I'm pleased you can appreciate true beauty, just don't tell anyone");
                        correctState = true;
                        state = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Keep trying. Think green.");
                        state = Console.ReadLine();
                        break;
                }
            }
            while (!correctState);

            Console.ReadLine();
        }
    }
}
