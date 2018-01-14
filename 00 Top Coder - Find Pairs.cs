using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace HackerrankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = Array.ConvertAll(s, Int32.Parse);

            findPairs(n);

            Console.ReadLine();
        }

        static void findPairs(int[] arr)
        {
            int finalSum = 0;
            foreach (var item in arr)
            {
                finalSum = finalSum + (item / 2);
            }
            Console.WriteLine("Result: {0}", finalSum);
        }
    }
}
