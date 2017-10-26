using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = ((i - 1) * 2 - 1);
                if (num == 1 || num <= n)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

