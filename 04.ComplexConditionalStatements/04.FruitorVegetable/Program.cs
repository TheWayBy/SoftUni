﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitorVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if (product.ToLower().Equals("banana") || product.Equals("apple") || product.Equals("kiwi") || product.Equals("cherry") 
                || product.Equals("lemon") || product.Equals("grapes"))
                Console.WriteLine("fruit");
            else if (product.Equals("tomato") || product.Equals("cucumber") || product.Equals("pepper") || product.Equals("carrot"))
                Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
