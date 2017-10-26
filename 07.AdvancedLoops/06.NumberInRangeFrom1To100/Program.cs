using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberInRangeFrom1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]:");
            int num = int.Parse(Console.ReadLine());

            while (num >= 100 || num <= 0)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter a number in the range [1...100]:");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
