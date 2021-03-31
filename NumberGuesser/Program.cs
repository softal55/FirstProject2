using System;


namespace NumberGuesser
{
    class Program
    {
        public static void Main(String[] args)
        {
            AppInfo appInfo = new AppInfo();
            appInfo.GetAppInfo();

            Greeting greeting = new Greeting();
            greeting.GreetUser();
            
          
            // Note:
            // Move the while loop (starting at line 19) to its own file, with one static method.
            // Call the file 'RandomNumber.cs'
            // come up with a good name for the method inside that class
            // 
            // 
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

        // Note 2:
        // Move this mathod to its own file called 'MessagePrinter.cs'
        // keep it as static
       
        static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
