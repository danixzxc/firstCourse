using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Model
{
    class Class1
    {
        public int GetVariable() 
        {
            int.TryParse(Console.ReadLine(), out int a);
            return a;
        }
    }
}   
