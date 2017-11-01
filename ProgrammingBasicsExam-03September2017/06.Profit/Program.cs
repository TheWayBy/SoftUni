using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int lev = int.Parse(Console.ReadLine());
            int dva = int.Parse(Console.ReadLine());
            int pet = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int otg = 0;

            for (int i = 0; i <= lev; i++)
            {
                for (int j = 0; j <= dva; j++)
                {
                    for (int k = 0; k <= pet; k++)
                    {
                        otg = i * 1 + j * 2 + k * 5;
                        if (otg == sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, j, k, sum);
                        }
                    }
                }
            }


        }
    }
}
