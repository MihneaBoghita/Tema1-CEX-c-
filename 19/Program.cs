using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7, y;
            // y=x++;
            y = ++x;
            Console.WriteLine("x={0} y={1}", x, y);
            Console.ReadLine();
        }
    }
}
