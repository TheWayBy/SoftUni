using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                int count = i;
                for (int j = 0; j < num -i ; j++)
                {
                    Console.Write($"{++count} ");
                }
                for (int j = i; j >=1; j--)
                {
                    Console.Write($"{--count} ");
                }
                Console.WriteLine();
            }
        }
    }
}
