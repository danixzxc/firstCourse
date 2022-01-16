using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace Ex7
{
    class Program
    {

        static void FOR(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) FOR(a + 1, b);
        }
        static void Main(string[] args)
        {
            //Гришель
            //7.a) Разработать рекурсивный метод,
            //который выводит на экран числа
            //от a до b(a < b).
            int a = Class1.GetVariable();
            int b = Class1.GetVariable();
            FOR (a, b) ;
        }
    }
}
