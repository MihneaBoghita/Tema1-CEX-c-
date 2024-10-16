using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string rezultat;
            Console.Write("Dati primul numar intreg : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati al doilea numar intreg : ");
            b=Convert.ToInt32(Console.ReadLine());
            if (a > b) rezultat = "primul este mai mare";
            else
                if (a < b) rezultat = "primul este mai mic";
            else rezultat = "numere egale";
            Console.WriteLine("Rezultatul comparatiei lui {0} cu {1} este \"{2}\"", a, b, rezultat);
            Console.ReadKey();
                  
        }
    }
}
