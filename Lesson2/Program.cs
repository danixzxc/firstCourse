using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //1. Написать метод, возвращающий
            //минимальное из трёх чисел.
            int a = Class1.GetVariable();
            int b = Class1.GetVariable();
            int c = Class1.GetVariable();
            int max;
            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;
            Console.WriteLine(max);
        }
    }
}
