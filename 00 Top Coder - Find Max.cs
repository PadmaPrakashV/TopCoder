using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerrankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total Questions: ");
            int t = Int32.Parse(Console.ReadLine());

            Console.Write("Total Guesses: ");
            int g = Int32.Parse(Console.ReadLine());

            Console.Write("Total Correct: ");
            int c = Int32.Parse(Console.ReadLine());

            findMax(t, g, c);

            Console.ReadLine();
        }

        static void findMax(int t, int g, int c)
        {
            int max = 0;
            if(g <= c)
                max = g;
            else
               max = c;
            int f = t - c;

            if ((t - g) <= f)
                max = max + (t - g);
            else
                max = max + f;

            Console.WriteLine("Max Mark: {0}", max);
        }
    }
}
