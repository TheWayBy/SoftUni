using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // soluion 1
            //for (int i = 0; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("{0}", Math.Pow(2, i));
            //    }
            //}

            // solution 2
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine("{0}", Math.Pow(2, i));
            }
        }
    }
}
