using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double daljinaZ = double.Parse(Console.ReadLine());
            double shirinaZ = double.Parse(Console.ReadLine());
            double garderob = double.Parse(Console.ReadLine());
            double tanc = 0.0;

            double zala = daljinaZ * shirinaZ;
            garderob = garderob * garderob;
            zala = zala - zala / 10;
            zala -= garderob;
            zala = zala * 10000; 
            tanc = zala / 7040;
            Console.WriteLine("{0}", Math.Floor(tanc));


        }
    }
}
