using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b, x;
            Console.WriteLine("Se citesc doua numere care vor reprezenta capetele intervalului");
            Console.Write("Dati prima valoarea : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati a doua valoare : ");
            b= Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }
            Console.Write("x = ");
            x= Convert.ToInt32(Console.ReadLine());
            if (x >= a && x <= b)
                Console.WriteLine("Numarul {0} este in intervalul [{1},{2}] ", x, a, b);
           
            else
                Console.WriteLine("Numarul {0} nu este in intervalul [{1},{2}]",x,a,b);
            Console.ReadKey();
        }
    }
}
