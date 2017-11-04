using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dansers = int.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double price = 0.0; 

            if (place == "Bulgaria")
            {
                price = score * dansers;
                if (season == "summer")
                {
                    price = price - price * 0.05;
                }
                else
                {
                    price = price - price * 0.08;
                }
            }
            else if (place == "Abroad")
            {
                price = dansers * score;
                price = price + price * 0.50;
                if (season == "summer")
                {
                    price = price - price * 0.10;
                }
                else
                {
                    price = price - price * 0.15;
                }
            }
            double charity = price * 0.75;
            price = price - price * 0.75;

            double sum = price / dansers;
            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", sum);



        }
    }
}
