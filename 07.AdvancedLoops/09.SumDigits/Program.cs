using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digit = 0;
            int sum = 0;
            do
            {
                digit = num % 10;
                sum += digit;
                num /= 10;
            } while (num > 0);
            Console.WriteLine(sum);

        }
    }
}
