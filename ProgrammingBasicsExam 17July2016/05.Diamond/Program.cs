using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i == 0 || i == num)
                {
                    Console.Write(new string('.', num - i));
                    Console.Write(new string('*', (5 * num) - 2 * (num - i)));
                    Console.WriteLine(new string('.', num - i));
                }
                else
                {
                    Console.Write(new string('.', num - i));
                    Console.Write('*');
                    Console.Write(new string('.', (5 * num) - 2 * (num - i) - 2));
                    Console.Write('*');
                    Console.WriteLine(new string('.', num - i));
                }
            }
            for (int i = 1; i <= 2*num + 1; i++)
            {
                if (i == 2 * num + 1)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('*', 5 * num - 2 * i));
                    Console.WriteLine(new string('.', i));

                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write('*');
                    Console.Write(new string('.', (5 * num) - 2 * i - 2));
                    Console.Write('*');
                    Console.WriteLine(new string('.', i));
                }
               
            }
        }
    }
}
