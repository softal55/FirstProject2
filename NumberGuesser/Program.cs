﻿using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();

                int CorrectNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != CorrectNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);
                    
                    if (guess != CorrectNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                Console.WriteLine("play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo() {

            string appName = "Number Guesser";
            string appVersion = "1.O.O";
            string appAuthor = "Sofiane Taleb";

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
 // Enjoy the game :)