using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double harvest = double.Parse(Console.ReadLine());
            double need = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());

            double wine = 0.0;
            double ost = 0.0;

            wine = (area * 0.4 * harvest) / 2.5;

            if (wine >= need)
            {
                ost = wine - need;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(ost), Math.Ceiling(ost / people));
            }
            else
            {
                ost = need - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(ost));
            }


        }
    }
}
