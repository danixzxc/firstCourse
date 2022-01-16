using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //5.а) Написать программу, которая
            //запрашивает массу и рост человека,
            //вычисляет его индекс массы и сообщает,
            //нужно ли человеку похудеть, набрать
            //вес или всё в норме.
            Console.WriteLine("Введите ваш вес");
            double m = Class1.GetDouble();
            Console.WriteLine("Введите ваш рост (в метрах)");
            double h = Class1.GetDouble();
            double index = m/(h*h);
            Console.WriteLine("Норма индекса массы от 18 до 25");
            Console.WriteLine($"Ваш индекс массы {index}");
            if (index < 18)
            {
                Console.WriteLine("Вам следует набрать вес");  
            }
            else if (index > 25)
            {
                Console.WriteLine("Вам следует похудеть");
            }
            else Console.WriteLine("Ваш индекс массы тела в норме");
        }
    }
}
