using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            string razmer = Console.ReadLine();
            string poruchkaTip = Console.ReadLine();
            decimal sum = 0.0M;

            if (razmer == "9X13")
            {
                sum = broi * 0.16M;
                if (broi >= 50)
                {
                    sum -= sum * 0.05M;
                }
            }
            else if (razmer == "10X15")
            {
                sum = broi * 0.16M;
                if (broi >= 80)
                {
                    sum -= sum * 0.03M;
                }
            }
            else if (razmer == "13X18")
            {
                sum = broi * 0.38M;
                if (broi >= 50 && broi <= 100)
                {
                    sum -= sum * 0.03M;
                }
                else if (broi > 100)
                {
                    sum -= sum * 0.05M;
                }
            }
            else if (razmer == "20X30")
            {
                sum = broi * 2.90M;
                if (broi >= 10 && broi <= 50)
                {
                    sum -= sum * 0.07M;
                }
                else if (broi > 50)
                {
                    sum -= sum * 0.09M;
                }
            }

            if (poruchkaTip == "online")
            {
                sum -= sum * 0.02M;
            }


            Console.WriteLine("{0:f2}BGN", sum);
        }
    }
}
