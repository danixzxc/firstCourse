using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //2. Ввести вес и рост человека. Рассчитать и
            //вывести индекс массы тела (ИМТ) по формуле
            //I=m/(h*h); где m — масса тела в килограммах,
            //h — рост в метрах.
            Console.WriteLine("Введите вес");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            double h = double.Parse(Console.ReadLine());

            if (h > 10)
            {
                h = h / 100; //если были введены сантиметры
            }

            double i = m / (h * h);
            Console.WriteLine(i);
        }
    }
}
