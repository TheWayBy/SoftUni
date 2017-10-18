using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MaxValue;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
