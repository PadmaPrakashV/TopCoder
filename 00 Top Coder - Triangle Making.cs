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

            maxPerimeter(n);

            Console.ReadLine();
        }

        static void maxPerimeter(int[] arr)
        {
            int a, b, c;
            int sum;
            Array.Sort(arr);

            a = arr[0];
            b = arr[1];
            c = arr[2];

            if (c >= (a + b))
                c = (a + b) - 1;

            sum = a + b + c;
            Console.WriteLine("Perimeter: {0}", sum);
        }

    }
}
