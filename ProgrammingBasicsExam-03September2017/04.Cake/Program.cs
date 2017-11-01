using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            string str;
            int parcheta = shirochina * duljina;

            while ((str = Console.ReadLine()) != "STOP")
            {
                int num = int.Parse(str);
                parcheta -= num;
                if (parcheta < 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(parcheta));
                    break;
                }
            }

            if (str == "STOP")
            {
                Console.WriteLine("{0} pieces are left.", parcheta);
            }

        }
    }
}
