using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("{0,3}", n);
                n++;
            }
            while (n<= 10);
            Console.ReadLine();
        }
    }
}
