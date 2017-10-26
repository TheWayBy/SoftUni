using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter even number: ");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0 && num != 0)
                    {
                        Console.WriteLine("Even number entered: {0}", num);
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
