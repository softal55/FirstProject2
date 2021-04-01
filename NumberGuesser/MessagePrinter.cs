using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NumberGuesser
{
    class MessagePrinter
    {
        
        
        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }

      
    }
}
