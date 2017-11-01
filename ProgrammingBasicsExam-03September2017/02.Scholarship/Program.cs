using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dohod = decimal.Parse(Console.ReadLine());
            decimal uspeh = decimal.Parse(Console.ReadLine());
            decimal minZaplata = decimal.Parse(Console.ReadLine());
            decimal socStip = 0.0M;
            decimal stipUspeh = 0.0M;

            if (uspeh > 4.5M)
            {
                socStip = minZaplata * 0.35M;
                if (uspeh >= 5.5M)
                {
                    stipUspeh = uspeh * 25M;
                }

                if (dohod < minZaplata && socStip > stipUspeh)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStip));
                }
                else if (uspeh >= 5.5M)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(stipUspeh));
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}
