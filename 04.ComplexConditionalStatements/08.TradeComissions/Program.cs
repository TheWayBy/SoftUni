using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double add = 0;

            if (town.Equals("Sofia"))
            {
                if (s >= 0 && s <= 500) { add = s * 0.05; }
                else if (s > 500 && s <= 1000) { add = s * 0.07; }
                else if (s > 1000 && s <= 10000) { add = s * 0.08; }
                else if (s > 10000) { add = s * 0.12; }
                else { Console.WriteLine("error"); return; }
            }
            else if (town.Equals("Varna"))
            {
                if (s >= 0 && s <= 500) { add = s * 0.045; }
                else if (s > 500 && s <= 1000) { add = s * 0.075; }
                else if (s > 1000 && s <= 10000) { add = s * 0.10; }
                else if (s > 10000) { add = s * 0.13; }
                else { Console.WriteLine("error"); return; }
            }
            else if (town.Equals("Plovdiv"))
            {
                if (s >= 0 && s <= 500) { add = s * 0.055; }
                else if (s > 500 && s <= 1000) { add = s * 0.08; }
                else if (s > 1000 && s <= 10000) { add = s * 0.12; }
                else if (s > 10000) { add = s * 0.145; }
                else { Console.WriteLine("error"); return; }
            }
            else { Console.WriteLine("error"); }

            Console.WriteLine("{0:F2}", add);

        }
    }
}

