using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            decimal ost = 0.0M;
            decimal need = 0.0M;

            if (people >= 1 && people <= 4)
            {
                ost = money - money * 0.75M;
            }
            else if (people >= 5 && people <= 9)
            {
                ost = money - money * 0.60M;
            }
            else if (people >= 10 && people <= 24)
            {
                ost = money - money * 0.50M;
            }
            else if (people >= 25 && people <= 49)
            {
                ost = money - money * 0.40M;
            }
            else if (people >= 50)
            {
                ost = money - money * 0.25M;
            }

            if (ticket == "VIP")
            {
                need = people * 499.99M;
            }
            else if (ticket == "Normal")
            {
                need = people * 249.99M;
            }

            ost = ost - need;
            if (ost >= 0)
            {
                Console.WriteLine("Yes! You have {0} leva left.", Math.Round(ost, 2));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f} leva.", Math.Abs(ost));
            }
        }
    }
}
