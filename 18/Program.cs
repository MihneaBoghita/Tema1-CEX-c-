using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 2;
            double z;
            z=Convert.ToDouble(x) / Convert.ToDouble(y);
            Console.WriteLine("z={0}", z);
            Console.WriteLine("z=" + z);
            Console.WriteLine(z.ToString());
            Console.ReadLine();

        }
    }
}
