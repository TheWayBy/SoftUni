using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double money = 0;

            if (town.Equals("Sofia"))
            {
                if (product.Equals("coffee")) money = quantity * 0.5;
                else if (product.Equals("water")) money = quantity * 0.8;
                else if (product.Equals("beer")) money = quantity * 1.20;
                else if (product.Equals("sweets")) money = quantity * 1.45;
                else if (product.Equals("peanuts")) money = quantity * 1.60;
            }
            if (town.Equals("Plovdiv"))
            {
                if (product.Equals("coffee")) money = quantity * 0.4;
                else if (product.Equals("water")) money = quantity * 0.7;
                else if (product.Equals("beer")) money = quantity * 1.15;
                else if (product.Equals("sweets")) money = quantity * 1.30;
                else if (product.Equals("peanuts")) money = quantity * 1.50;
            }
            if (town.Equals("Varna"))
            {
                if (product.Equals("coffee")) money = quantity * 0.45;
                else if (product.Equals("water")) money = quantity * 0.7;
                else if (product.Equals("beer")) money = quantity * 1.10;
                else if (product.Equals("sweets")) money = quantity * 1.35;
                else if (product.Equals("peanuts")) money = quantity * 1.55;
            }
            Console.WriteLine(money);
        }
    }
}
