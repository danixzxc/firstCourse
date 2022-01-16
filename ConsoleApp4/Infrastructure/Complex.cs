using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Infrastructure
{
    public struct Complex //структура, или класс
    {
        public double re;
        public double im;

        public Complex(double re, double im) //конструктор
        {
            this.re = re;
            this.im = im;
        }
        
        public string Print() //метод
        {
            return $"{re} + {im}i";
        }
    }
}
