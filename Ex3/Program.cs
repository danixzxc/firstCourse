using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //3. С клавиатуры вводятся числа, пока не будет
            //введен 0. Подсчитать сумму всех нечетных
            //положительных чисел.

            int sum = 0;
            int a;
            for (; ; )
            {
                a = Class1.GetVariable();
                if (a > 0 && a % 2 != 0) sum += a;
                if (a == 0) break;
            }
            Console.WriteLine(sum);
        }
    }
}
