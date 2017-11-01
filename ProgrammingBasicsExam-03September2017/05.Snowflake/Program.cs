using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', 1));
                if (N - i == 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(new string('.', N - i));
                }
                Console.Write(new string('*', 1));
                if (N - i == 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(new string('.', N - i));
                }
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', i));
            }

            Console.WriteLine(new string('*', 2 * N + 3));

            for (int i = N - 1; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', 1));
                if (N - i == 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(new string('.', N - i));
                }
                Console.Write(new string('*', 1));
                if (N - i == 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(new string('.', N - i));
                }
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', i));
            }
        }
    }
}
