using System;

namespace первый_вебинар
{
    class Program
    {
        static void Main(string[] args)
        {

            #region

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);
            #endregion

            #region

            Console.WriteLine("Введите ваше имя ");
            var fname = Console.ReadLine();
            Console.WriteLine($"Привет, {fname}!");

            #endregion
        }
    }
}
