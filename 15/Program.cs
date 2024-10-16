using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.Write("{0} ", i);
                i++;
                if (i < 10)
                    continue;
                else
                    break;
            }
            Console.ReadLine();
        }
    }
}
