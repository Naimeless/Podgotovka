using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Authentification
    {
        public static bool Login(string login, string password)
        {
            if (login == "admin")
            {
                if (password == "admin") return true;
            }
            return false;
        }
    }
}
