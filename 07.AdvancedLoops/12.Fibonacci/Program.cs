using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int fib = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j < num; j++)
                {
                    fib = i * j;  
                }
            }
            Console.WriteLine(fib);
        }
    }
}
