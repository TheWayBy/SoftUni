using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
              Console.Write("$");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
