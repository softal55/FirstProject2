using System;


namespace NumberGuesser
{
    class Program
    {
        public static void Main()
        {
            AppInfo appInfo = new AppInfo();
            appInfo.GetAppInfo();

            Greeting greeting = new Greeting();
            greeting.GreetUser();
            
            RandomNumber randomNumber = new RandomNumber();
            randomNumber.RandNumb();
            
            PrintColorMessage();


            // Note:
            // Move the while loop (starting at line 19) to its own file, with one static method.
            // Call the file 'RandomNumber.cs'
            // come up with a good name for the method inside that class
            // 
            // 


            // Note 2:
            // Move this mathod to its own file called 'MessagePrinter.cs'
            // keep it as static

        }
    }
}
