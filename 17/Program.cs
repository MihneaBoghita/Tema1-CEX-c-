using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, nr;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            int s = 0;
            for(; ; )
            {
                Console.Write("nr=");
                nr=int.Parse(Console.ReadLine());
                if (s + nr < n)
                {
                    s = s + nr;
                    continue;
                }
                else
                    break;
            }
            Console.WriteLine("suma la care s a ajuns este "+s);
            Console.ReadLine();
        }
    }
}
