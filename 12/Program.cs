using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.81, d = 0, dd;
            int t= 0;
            Console.Write("Dati distanta maxima ");
            try
            {   
                dd = int.Parse(Console.ReadLine());           
                while (d <= dd)
                {
                    d = (g * t * t) / 2;
                    Console.WriteLine(t.ToString() + " " + d);
                    t++;
                }
                t = 0;
                do
                {
                    d = (g * t * t) / 2;
                    Console.WriteLine(t.ToString() + " " + d);
                    t++;
                } while (d <= dd);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
