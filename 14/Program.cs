using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zi;
            Console.WriteLine("Dati ziua");
            try
            {
                zi = int.Parse(Console.ReadLine());
                switch (zi)
                {
                    case 1: Console.WriteLine("Luni"); break;
                    case 2: Console.WriteLine("Marti"); break;
                    case 3: Console.WriteLine("Miercuri"); break;
                    case 4: Console.WriteLine("Joi"); break;
                    case 5: Console.WriteLine("Vineri"); break;
                    case 6: Console.WriteLine("Sambata"); break;
                    case 7: Console.WriteLine("Duminica"); break;
                    default: Console.WriteLine("zi eronata"); break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

        }
    }
}
