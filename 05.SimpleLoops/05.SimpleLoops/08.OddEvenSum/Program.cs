using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even += int.Parse(Console.ReadLine()); ;
                }
                else
                {
                    odd += int.Parse(Console.ReadLine()); ;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes Sum = {0}", odd);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(odd - even));
            }
        }
    }
}
