using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double time = 0.0;

            time = (1 / (1 / A + 1 / B + 1 / C)) + (1 / (1 / A + 1 / B + 1 / C)) * 0.15;
            Console.WriteLine("Cleaning time: {0:f2}", time);

            if (father - time > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(father - time));
            }
            else
            {
                time = Math.Abs(father - time);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(time));
            }
        }
    }
}
