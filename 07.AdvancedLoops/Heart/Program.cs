using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("H E A R T ");

            int num = int.Parse(Console.ReadLine());
            // int count = 2; 
            for (int i = 1; i < (num / 2) + 1; i++)
            {
                Console.Write(new string('-', (num - i * 2) / 2));
                Console.Write(new string('*', i * 2));
                Console.Write(new string('-', (num - i * 2) / 2));
                Console.Write(new string('-', (num - i * 2) / 2));
                Console.Write(new string('*', i * 2));
                Console.Write(new string('-', (num - i * 2) / 2));
                Console.WriteLine();
            }
            for (int i = 1; i < (num / 2) + 1; i++)
            {
                Console.WriteLine(new string('*', num * 2));
            }
            // Console.WriteLine();
            for (int i = 0; i < num ; i++)
            {
                Console.Write(new string ('-', i));
                Console.Write(new string('*', (num - i)*2));
                Console.WriteLine(new string('-', i));

            }

        }
    }
}
