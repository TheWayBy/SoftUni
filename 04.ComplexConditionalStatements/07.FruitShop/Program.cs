using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double money = 0;

            if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday") || day.Equals("Friday"))
            {
                if (fruit.Equals("banana")) { money = quantity * 2.5; }
                else if (fruit.Equals("apple")) { money = quantity * 1.20; }
                else if (fruit.Equals("orange")) { money = quantity * 0.85; }
                else if (fruit.Equals("grapefruit")) { money = quantity * 1.45; }
                else if (fruit.Equals("kiwi")) { money = quantity * 2.70; }
                else if (fruit.Equals("pineapple")) { money = quantity * 5.5; }
                else if (fruit.Equals("grapes")) { money = quantity * 3.85; }
                else
                {
                    Console.WriteLine("error");
                    return;
                };

                Console.WriteLine(money);
            }
            else if (day.Equals("Saturday") || day.Equals("Sunday"))
            {
                if (fruit.Equals("banana")) { money = quantity * 2.7; }
                else if (fruit.Equals("apple")) { money = quantity * 1.25; }
                else if (fruit.Equals("orange")) { money = quantity * 0.90; }
                else if (fruit.Equals("grapefruit")) { money = quantity * 1.60; }
                else if (fruit.Equals("kiwi")) { money = quantity * 3.00; }
                else if (fruit.Equals("pineapple")) { money = quantity * 5.6; }
                else if (fruit.Equals("grapes")) { money = quantity * 4.20; }
                else
                {
                    Console.WriteLine("error");
                    return;
                };

                Console.WriteLine(money);
            }
            else Console.WriteLine("error");
        }
    }
}
