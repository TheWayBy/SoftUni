using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < num; i++)
            {
                count = i;
                int emo = 0;

                for (int j = 0; j < num; j++)
                {
                    emo++;
                    if (count < num)
                    {
                        Console.Write(++count);
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write(--count);
                            emo++;
                            if (emo >= 5) break;
                        }
                         break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
