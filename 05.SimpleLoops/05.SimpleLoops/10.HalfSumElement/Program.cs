using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int maxNum = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (maxNum < num) { maxNum = num; } 
            }
            sum = sum - maxNum;
            if (maxNum == Math.Abs(sum))
            {
                Console.WriteLine("Yes, Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No, Diff = {0}", Math.Abs(sum - maxNum));
            }

        }
    }
}
