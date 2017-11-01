using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal pokrivka = 0.0M;
            decimal kare = 0.0M;
            decimal sum = 0.0M;

            pokrivka = (a + 2 * 0.3M) * (b + 2 * 0.3M) * num;
            kare = ((a/2) *( a/2)) * num;
            sum = pokrivka * 7 + kare * 9;

            Console.WriteLine("{0:f2} USD\n{1:f2} BGN", sum, sum * 1.85M);


        }
    }
}
