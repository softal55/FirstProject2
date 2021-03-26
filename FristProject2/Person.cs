using System;
using System.Collections.Generic;
using System.Text;

namespace FristProject2
{
    public class Person
    {
        // Change the keyword from 'public' to private 
        private string Name;
        private int Age;
        private bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + Name + " and my age is " + Age);
        }
    }
}
