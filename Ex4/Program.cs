using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLibrary;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гришель
            //4. Реализовать метод проверки логина и пароля.
            //На вход метода подается логин и пароль. На
            //выходе истина, если прошел авторизацию, и
            //ложь, если не прошел (Логин: root, Password:
            //GeekBrains). Используя метод проверки логина
            //и пароля, написать программу: пользователь
            //вводит логин и пароль, программа пропускает
            //его дальше или не пропускает. С помощью
            //цикла do while ограничить ввод пароля тремя
            //попытками.
            int i = 3;
            string login;
            string password;
            do
            {
                Console.WriteLine("Введите логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                i--;
                if (Class1.Check(login, password))
                {
                    Console.WriteLine("Данные введены верно");
                    break;
                }
                else if (!Class1.Check(login, password))
                {
                    Console.WriteLine($"Данные введены некорректно, у вас еще {i} попыток"); ;
                }
            } while (i > 0);
        }
    }
}
