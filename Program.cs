using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("Singleton fallo, las variables contienen diferentes instancias.");
            }

            Console.ReadLine();
        }
    }
}
