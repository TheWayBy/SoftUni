using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
             int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int hours = 0;
            double energy = 0.0;
            int allEnergy = 100 * days * dancers;
            double izhabena = 0.0; 
            for (int i= 1; i <= days; i++)
            {
                hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (hours %2 == 0)
                    {
                        energy += 68 * dancers;
                    }
                    else
                    {
                        energy += 65 * dancers;
                    }
                }
                else
                {
                    if (hours % 2 == 0)
                    {
                        energy += 49 * dancers;
                    }
                    else
                    {
                        energy += 30 * dancers;
                    }
                }
        
            }
            izhabena = allEnergy - energy;
            double otg = izhabena / dancers / days;

            if (otg >= 50.00)
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", otg);
            }
            else
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", otg);
            }
        }
    }
}
