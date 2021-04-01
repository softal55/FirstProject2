using System;

namespace ExampleOne
{
    class Program
    {
        public static void Main()
        {

            int num1 = 0, num2 = 0;

            Console.Write("Enter First number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Program program = new Program();
            int add = program.sum(num1, num2);
            Console.WriteLine("Addition:{0}" , add);
        }

        public int sum(int no1, int no2)
        {
            int add = no1 + no2;
            return add;
        }
    }
}
