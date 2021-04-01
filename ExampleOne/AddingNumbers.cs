using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOne
{
    class AddingNumbers
    {

        // this method return a value of type int
        // int Sum means the method Sum return a value of type int
        public int Sum(int no1, int no2)
        {
            int add = no1 + no2;
            return add; // this is value that this method return to the caller (in this case 'Main' called this method)
        }
    }
}
