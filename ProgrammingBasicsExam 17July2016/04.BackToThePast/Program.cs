using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            decimal need = 0.0M;
            int god = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    need += 12000M;
                }
                else
                {
                    need = need + 12000M + 50M * god;
                }
                god++;
            }
            if (money >= need)
            {
                money -= need;
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else
            {
                money = Math.Abs(money - need);
                Console.WriteLine("He will need {0:f2} dollars to survive.", money);
            }
        }
    }
}
