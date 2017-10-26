using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (num + 1) / 2; i++)
            {
                if (num % 2 == 0)
                {
                    Console.Write(new string('-', (num / 2) - i));
                    Console.Write(new string('*', i * 2));
                    Console.Write(new string('-', (num / 2) - i));
                }
                else
                {
                    Console.Write(new string('-', (num /2) - i - 1));
                    Console.Write(new string('*', i == 1 ? i : i*2 - 1));
                    Console.Write(new string('-', (num / 2) - i - 1));
                }
                Console.WriteLine();
            }
        }
    }
}
