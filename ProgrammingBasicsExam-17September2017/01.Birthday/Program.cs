using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double duljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double visohcina = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double obem = 0.0;
            obem = duljina * shirina * visohcina * 0.001;
            obem = obem - obem * (procent / 100);
            Console.WriteLine("{0:f3}", Math.Round(obem, 3));
        }
    }
}
