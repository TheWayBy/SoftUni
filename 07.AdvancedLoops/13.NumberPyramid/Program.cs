using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 0; i <= num; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write($"{count++} ");
                    if (count > num) break;
                }
                Console.WriteLine();
                if (count > num) break;
            }
        }
    }
}
