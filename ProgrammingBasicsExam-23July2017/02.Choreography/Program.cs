using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dansers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPday = Math.Ceiling(((steps/days)/ steps)*100);
            double stepsDancer = (stepsPday / dansers);

            if (stepsPday <= 13.00)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepsDancer);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsDancer);
            }
        }
    }
}
