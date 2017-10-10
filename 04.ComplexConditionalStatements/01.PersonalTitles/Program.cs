using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (years >= 16)
            {
                if (sex.Equals("f"))
                {
                    Console.WriteLine("Ms.");
                }
                else if (sex.Equals("m"))
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (years < 16)
            {
                if (sex.Equals("f"))
                {
                    Console.WriteLine("Miss");
                }
                else if (sex.Equals("m"))
                {
                    Console.WriteLine("Master");
                }
            }

        }
    }
}
