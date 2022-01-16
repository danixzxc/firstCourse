using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLibrary
{
    public class Class1
    {
        public static bool Check(string login, string password)
        {
            if (login == "root" &&
                password == "GeekBrains")
            {
                return true;
            }
            else return false;
        }
    }
}
