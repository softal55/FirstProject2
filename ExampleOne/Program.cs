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

            // Since the method exists in another class, which is 'AddingNumbers'
            // Also since the method is not static, then we need to create an instance of that class
            //
            // Create an instance called addition
            AddingNumbers addition = new AddingNumbers();

            // now that we have the instance, we can use it like this
            int add = addition.Sum(num1, num2);
            // So, this means call the method 'Sum' which is declared in the class 'AddingNumbers'
            // and when the method adds the 2 numbers, it return the sum.
            // the sum is then stored in the variable add.



            //Program program = new Program();
            //int add = program.Sum(num1, num2);
            Console.WriteLine("Addition:{0}" , add);
            
        }

        
    }
}
