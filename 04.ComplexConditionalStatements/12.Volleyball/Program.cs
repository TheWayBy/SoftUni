using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double games = (48 - h) * (3.0 / 4);
            games += h;
            games += p * (2.0 / 3);

            if (year.Equals("leap"))
            {
                games += games * 0.15;
            }
            Console.WriteLine((int)games);
        }
    }
}
