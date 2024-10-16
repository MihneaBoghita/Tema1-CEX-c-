using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int faina, oua;
            try
            {
                Console.Write("Dati cantitatea de faina : ");
                faina = int.Parse(Console.ReadLine());
                Console.Write("Dati numarul de oua : ");
                oua = Convert.ToInt16(Console.ReadLine());

            }
            catch(Exception ex)  
            { 
                Console.WriteLine(ex.Message);
                faina = 0;
                oua = 0;
            }
            if (faina >= 500)
            {
                if (oua >= 4)
                    Console.WriteLine("Facem prajitura");

            }
            else
                Console.WriteLine("Nu facem nimic :(");
            Console.ReadLine();
        }
    }
}
