using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sir = "Acesta este un sir";
            char[] delimitor = { ' ', ',', '.', ':' };
            Console.WriteLine("Sirul care va fi impartit in cuvinte\n'{0}',",sir);
            string[] cuvant = sir.Split(delimitor);
            Console.WriteLine("Sunt {0} cuvinte in text : ", cuvant.Length);
            foreach (string s in cuvant)
            { 
                Console.WriteLine(s);
                Console.ReadLine();
            }
                
        }
    }
}
