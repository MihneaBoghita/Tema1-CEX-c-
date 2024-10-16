using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sir = { 3, 6, -9, 2, -11, 2, 6, 9 };
            int sum = 0;
            for(int i=0; i<sir.Length; i++) 
            {
                sum+=sir[i];
            }
            Console.WriteLine("Suma elementelor este " +sum);
            sum = 0;
            foreach(int a in sir)
                sum +=a;
            Console.WriteLine("Suma elementelor este "+ sum);
            Console.ReadLine();
        }
    }
}
