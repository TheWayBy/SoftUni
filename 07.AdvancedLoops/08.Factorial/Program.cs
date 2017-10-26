using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int factorial = 1; 
            if (num > 0 && num <= 12)
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i; 
                }
            }
            Console.WriteLine(factorial);
        }
    }
}
