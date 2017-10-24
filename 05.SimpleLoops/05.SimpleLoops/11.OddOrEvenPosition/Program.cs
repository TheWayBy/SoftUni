using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 0; i < n; i = i + 2)
            {
                double oddNum = double.Parse(Console.ReadLine());
                double evenNum = double.Parse(Console.ReadLine());
              //  Console.WriteLine("oddNum = {0}", oddNum);
              // Console.WriteLine("evenNum = {0}", evenNum);

                oddSum += oddNum;
                evenSum += evenNum;
                Console.WriteLine("oddSum = {0}", oddSum);
                Console.WriteLine("evenSum = {0}", evenSum);

                if (oddMin > oddNum) { oddMin = oddNum; }
                if (oddMax < oddNum) { oddMax = oddNum; }

                if (evenMin > evenNum) { evenMin = evenNum; }
                if (evenMax < evenNum) { evenMax = evenNum; }
            }
            Console.WriteLine("OddSum = {0}", oddSum);
            if (oddMin == 0) { Console.WriteLine("OddMin = No"); }
            else { Console.WriteLine("OddMin = {0}", oddMin); }
            if (oddMax == 0) { Console.WriteLine("OddMax = No"); }
            else { Console.WriteLine("OddSum = {0}", oddMax); }

            Console.WriteLine("EvenSum = {0}", evenSum);
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMin = {0}", evenMin);
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
