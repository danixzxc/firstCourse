using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
                        Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());

            //int c = a; 3 переменные
            //a = b;
            //b = c;
            (a, b) = (b, a);

            Console.WriteLine($"a = {a}  b = {b}");
        }
    }
}
