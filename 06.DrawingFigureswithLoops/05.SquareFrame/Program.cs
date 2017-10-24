using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int a = 1; a <= num -2; a++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 1; i <= num - 2; i++)
            {
                Console.Write("|");
                for (int inside = 1; inside <= num - 2; inside++)
                { Console.Write(" -"); }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int b = 1; b <= num - 2; b++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
