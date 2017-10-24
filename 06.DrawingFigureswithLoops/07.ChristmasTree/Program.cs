using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.Write(new string(' ', num - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.Write(new string(' ', num - i));
                Console.WriteLine();
            }
        }
    }
}
