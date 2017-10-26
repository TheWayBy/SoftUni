using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivisorCGD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int del = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0 && del < i)
                {
                    del = i;
                }
            }
            Console.WriteLine(del);
        }
    }
}
