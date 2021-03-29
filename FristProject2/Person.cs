using System;
using System.Collections.Generic;
using System.Text;

// See Note 1 
namespace FristProject2
{
    public class Person
    {
        // Note 1:
        // ------------------------------------------------------------------------------------------
        // To get your program to work, change private to public.
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + Name + " and my age is " + Age);
        }
    }
}
