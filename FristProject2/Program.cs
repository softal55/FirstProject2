using System;

// To get the program to compile and run.
// Right-click on 'FirstProject2' then select 'Set as Startup Project'
namespace FristProject2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var person = new Person();

            person.Name = "Sofiane";
            person.Age = 16;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
