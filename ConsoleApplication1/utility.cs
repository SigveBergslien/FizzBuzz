using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class utility
    {
        public static void fizzBuzz(int i)
        {
            Console.Write(i + " ");
            if (i % 3 == 0)
                Console.Write("Fizz");
            if (i % 5 == 0)
                Console.Write("Buzz");
            Console.WriteLine();
        public static void fizzBuzz1_100()
        {
            for (int i = 1; i < 101; i++)
            {
                fizzBuzz(i);
            }
        }
    }
}
