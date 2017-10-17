using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int size = r*c;

            switch (type)
            {
                case "Premiere": Console.WriteLine("{0:F2}",size*12); break;
                case "Normal": Console.WriteLine("{0:F2}", size * 7.5); break;
                case "Discount": Console.WriteLine("{0:F2}", size * 5); break;

                default:
                    break;
            }
        }
    }
}
