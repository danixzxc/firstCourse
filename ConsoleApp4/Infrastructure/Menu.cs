using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Presenter;

namespace ConsoleApp4.Infrastructure
{
    class Menu
    {
        public static void Start() 
        {
            Calc calc = new Calc(new View.ConsoleView());

            while (true)
            {
                Console.WriteLine("Для суммы нажмите S");
                Console.WriteLine("Для разности нажмите R");
                Console.WriteLine("Для произведения нажмите P");
                Console.WriteLine("Для выхода нажмите esc\n\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        calc.Sum();
                        break;
                    case ConsoleKey.R:
                        calc.Dif();
                        break;
                    case ConsoleKey.P:
                        calc.Mult();
                        break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
