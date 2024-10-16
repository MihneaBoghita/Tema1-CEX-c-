using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Alegeti un numar dintre 1, 2 si 3");
            do
            {
                Console.WriteLine("variante=");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("ati ales varianta 1");
                        goto case 4;
                    case 2:
                        Console.WriteLine("ati ales varianta 2");
                        break;
                    case 3:
                        Console.WriteLine("ati ales varianta 3");
                        break;
                    case 4:
                        Console.WriteLine("Sunteti norocosi beneficiati si de varianta 4");
                        break;
                }

            } while (n != 1 && n!=2 && n!=3);
            Console.ReadLine();
        }
    }
}
