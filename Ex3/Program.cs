using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Гришель
             // 3.а) Написать программу, которая подсчитывает
             //    расстояние между точками с координатами x1,
             //    y1 и x2,y2 по формуле r = Math.Sqrt
             //   (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
             //   .Вывести результат, используя спецификатор
             //   формата .2f(с двумя знаками после запятой);
            Console.WriteLine("Введите x1");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2");
            int y2 = int.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2)
                + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:f}", r);
        }
    }
}
