using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                if (i + 1 <= N / 2)
                {
                    Console.Write(new string('.', N + i));
                    Console.Write(new string('#', 5 * N - 2 * (N + i)));
                    Console.WriteLine(new string('.', N + i));
                }
                else if (i + 1 >= N / 2)
                {
                    Console.Write(new string('.', N + i));
                    Console.Write('#');
                    Console.Write(new string('.', (5 * N - 2 * (N + i)) - 2));
                    Console.Write('#');
                    Console.WriteLine(new string('.', N + i));
                }
            }
            Console.Write(new string('.', 2 * N));
            Console.Write(new string('#', N));
            Console.WriteLine(new string('.', 2 * N));

            for (int i = 0; i < N + 1; i++)
            {
                if (i == N/2)
                {
                    Console.Write(new string('.', (5*N -10)/2));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', (5 * N - 10) / 2));

                }
                Console.Write(new string('.', (5 * N - N - 3) / 2));
                Console.Write(new string('#', N + 4));
                Console.WriteLine(new string('.', (5 * N - N - 3) / 2));
            }
        }
    }
}
