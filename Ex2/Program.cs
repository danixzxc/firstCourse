using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //2. Написать метод подсчета
            //количества цифр числа.

            int a = Class1.GetVariable();
            Console.WriteLine(a.ToString().Length);
        }
    }
}
