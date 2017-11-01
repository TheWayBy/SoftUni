using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string otg = null;
            int count = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                int d = i % 10;
                int c = (i / 10) % 10;
                int b = (i / 100) % 10;
                int a = (i / 1000);

                if ((a * b + c * d) == num)
                {
                    if (a < b && c > d)
                    {
                        Console.Write($"{a}{b}{c}{d} ");
                        count++;
                        if (count == 4)
                        {
                            otg = $"{a}{b}{c}{d}";
                        }
                    }
                }

            }

            Console.WriteLine();
            if (otg != null)
            {
                Console.WriteLine($"Password: {otg}");
            }
            else
            {
                Console.WriteLine("No!");
            }

        }
    }
}
