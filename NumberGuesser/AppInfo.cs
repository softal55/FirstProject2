using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
     class AppInfo
    {
        // Note 2: Remove the keyword 'static'
        public  void GetAppInfo()
        {

            string appName = "Number Guesser";
            string appVersion = "1.O.O";
            string appAuthor = "Sofiane Taleb";

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
    }
}
