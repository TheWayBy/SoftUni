using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string srok = Console.ReadLine();
            string type = Console.ReadLine();
            string net = Console.ReadLine();
            int meseci = int.Parse(Console.ReadLine());

            decimal money = 0.0M;

            if (srok == "one")
            {
                if (type == "Small") { money = 9.98M; }
                else if (type == "Middle") { money = 18.99M; }
                else if (type == "Large") { money = 25.98M; }
                else if (type == "ExtraLarge") { money = 35.99M; }

            }
            else if (srok == "two")
            {
                if (type == "Small") { money = 8.58M; }
                else if (type == "Middle") { money = 17.09M; }
                else if (type == "Large") { money = 23.59M; }
                else if (type == "ExtraLarge") { money = 31.79M; }
            }

            if (net == "yes")
            {
                if (type == "Small")
                { money += 5.50M; }
                else if (type == "Middle" || type == "Large")
                { money += 4.35M; }
                else if (type == "ExtraLarge")
                { money += 3.85M; }
            }

            if (srok == "two")
            {
                money = money - (money * 0.0375M);
            }

            Console.WriteLine("{0:f2} lv.", money*meseci);
        }
    }
}
