﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1 and the factorial of zero, 0, is defined as being 1. 
            
            //Solve this using both loops and recursion

            int num, n;

            Console.WriteLine("Welcome to Factorial Finder");
            Console.WriteLine("Please enter a number to get its factorial: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                n = num;
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
                num--;
            }

            Console.ReadLine();
        }
    }
}
