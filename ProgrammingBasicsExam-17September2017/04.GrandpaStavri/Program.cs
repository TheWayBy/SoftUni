using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double liters = 0.0;
            double degree = 0.0;

            for (int i = 1; i <= days; i++)
            {
                double liter = double.Parse(Console.ReadLine());
                liters += liter;
                degree += liter * double.Parse(Console.ReadLine());
            }

            double deg = Math.Round(degree / liters, 2);

            Console.WriteLine("Liter: {0:f2}", liters);
            Console.WriteLine("Degrees: {0:f2}", deg);

            if (deg < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (deg >= 38 && deg < 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        
        }
    }
}
