using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (var col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }                        for (int i = n - 1; i >= 1; i--)
            {
                for (int b = 1; b <= n - i; b++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = n-1; col > n - i; col--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
