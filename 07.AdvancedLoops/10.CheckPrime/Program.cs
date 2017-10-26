using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int del = 1;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    del++;
                }
            }
            if (del == 2 && n != 0 && n != 1)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("NOT Prime");
            }
        }
    }
}
