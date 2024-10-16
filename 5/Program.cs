using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            int a, b;
            Console.WriteLine("Exemple pentru operatori aritmetici");
            Console.Write("Dati primul numar intreg");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati al doilea numar intreg");
            b=Convert.ToInt32(Console.ReadLine());
                op = (char)Console.Read();
            switch (op)
            {
                case '+':
                    Console.WriteLine("Adunarea : {0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("Scadere : {0} + {1} = {2}",a,b, a + b);
                    break;
                case '*':
                    Console.WriteLine("Inmultire : {0} * {1} = {2}", a,b, a * b);
                    break;
                case '/':
                    Console.WriteLine("Impartire : {0} / {1} = {2}", a,b, (float)a / b);
                    break;
                case '%':
                    Console.WriteLine("Modulo : {0} % {1} = {2}", a, b, a % b);
                    break;
                default:
                    Console.WriteLine("Simbolul nu reprezinta o operatie aritmetica");
                break;

            }
            Console.ReadKey();
        }
    }
}
