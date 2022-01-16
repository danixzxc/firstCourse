using System;
using System.Collections.Generic;
using System.Text;
using Lesson3.Model;

namespace Lesson3.Infrastructure
{
    class Menu
    {
        public static void Start()
        {
            int sum = 0;
            int a;
            Class1 class1 = new Class1();
            for (; ; )
            {
                a = class1.GetVariable();
                if (a > 0 && a % 2 != 0) sum += a;
                if (a == 0) break;
            }
            Console.WriteLine(sum);
        }
    }
}
