using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Infrastructure;

namespace ConsoleApp4.Models
{
    class Model
    {   
        public static Complex Sum(Complex q, Complex w) =>
            new Complex(q.re + w.re, q.im + w.im);
        public static Complex Dif(Complex q, Complex w) =>
            new Complex(q.re - w.re, q.im - w.im);
        public static Complex Mult(Complex q, Complex w) =>
            new Complex((q.re * w.re) - (q.im * w.im),
                (q.im * w.re) + (q.re * w.im));
    }
}
