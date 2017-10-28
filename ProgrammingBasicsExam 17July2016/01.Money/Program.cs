using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitkoins = double.Parse(Console.ReadLine());
            double iuons = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());
            double money = 0.0;

            bitkoins = bitkoins * 1168;
            iuons = iuons * 0.264;
            money = (bitkoins + iuons) / 1.95;
            money = money - (money*(komisionna / 100));
            Console.WriteLine("{0:f}",money);
        }
    }
}
