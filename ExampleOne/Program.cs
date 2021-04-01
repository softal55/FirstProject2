using System;

namespace ExampleOne
{
    class Program
    {
        public static void Main()
        {
            

            Console.Write("Enter First number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int num2= Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            int add = program.Sum(num1, num2);
            Console.WriteLine("Addition:{0}" , add);
            
        }

        
    }
}
