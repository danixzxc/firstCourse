using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Class1
    {
        public static int GetVariable() 
        {
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        public static double GetDouble()
        {
            double a = double.Parse(Console.ReadLine());
            return a;
        }
    }
}
