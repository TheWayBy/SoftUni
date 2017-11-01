using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= 2*num+8; i++)

            Console.Write(new string('.', (3 * num - 1) / 2));
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * num - 1) / 2));

            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('/');
            Console.Write('x');
            Console.Write('\\');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('x');
            Console.Write('|');
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            for (int i = 0; i < (num + 1) / 2; i++)
            {
                Console.Write(new string('.', (3 * num - 2 * (num + i)) / 2));
                Console.Write(new string('x', num + i));
                Console.Write('|');
                Console.Write(new string('x', num + i));
                Console.WriteLine(new string('.', (3 * num - 2 * (num + i)) / 2));
            }
            for (int i = 1; i <= (num - 1) / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('x', (3 * num - 1 - 2 * i) / 2));
                Console.Write('|');
                Console.Write(new string('x', (3 * num - 1 - 2 * i) / 2));
                Console.WriteLine(new string('.', i));
            }
            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('/');
            Console.Write('x');
            Console.Write('\\');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('\\');
            Console.Write('x');
            Console.Write('/');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            for (int i = 0; i < (num + 1) / 2; i++)
            {
                Console.Write(new string('.', (3 * num - 2 * (num + i)) / 2));
                Console.Write(new string('x', num + i));
                Console.Write('|');
                Console.Write(new string('x', num + i));
                Console.WriteLine(new string('.', (3 * num - 2 * (num + i)) / 2));
            }
            for (int i = 1; i <= (num - 1) / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('x', (3 * num - 1 - 2 * i) / 2));
                Console.Write('|');
                Console.Write(new string('x', (3 * num - 1 - 2 * i) / 2));
                Console.WriteLine(new string('.', i));
            }

            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('x');
            Console.Write('|');
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            Console.Write(new string('.', (3 * num - 3) / 2));
            Console.Write('\\');
            Console.Write('x');
            Console.Write('/');
            Console.WriteLine(new string('.', (3 * num - 3) / 2));

            Console.Write(new string('.', (3 * num - 1) / 2));
            Console.Write('x');
            Console.WriteLine(new string('.', (3 * num - 1) / 2));
        }
    }
}
