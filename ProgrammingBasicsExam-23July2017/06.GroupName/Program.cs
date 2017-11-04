using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLeter = Console.ReadLine();
            string secondLeter = Console.ReadLine();
            string thirdLeter = Console.ReadLine();
            string fourLeter = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            int answer = 0;
            string name = $"{firstLeter}{secondLeter}{thirdLeter}{fourLeter}{num}";
            for (int i = 'A'; i <= firstLeter[0]; i++)
            for (int j = 'a'; j <= secondLeter[0]; j++)
            for (int k = 'a'; k <= thirdLeter[0]; k++)
            for (int m = 'a'; m <= fourLeter[0]; m++)
            for (int l = 0; l <= num; l++)
            {
                string suggest = $"{(char)i}{(char)j}{(char)k}{(char)m}{l}";
                if (suggest == name)
                {
                    Console.WriteLine(answer);
                    return;
                }

                answer++;
            }
        }
    }
}
