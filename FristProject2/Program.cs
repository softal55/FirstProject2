using System;

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
