using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
    class Greeting
    {
        public static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }
    }
}
