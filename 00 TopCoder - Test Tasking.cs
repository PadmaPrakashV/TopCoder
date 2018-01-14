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
            int q = Int32.Parse(Console.ReadLine());
            int g = Int32.Parse(Console.ReadLine());
            int t = Int32.Parse(Console.ReadLine());

            checkNumber(q, g, t);

            Console.ReadLine();
        }

        static void checkNumber(int q, int g, int t)
        {
            int actualTrue;
            int actualFalse;
            int myFalse;
            int answer;

            if (g > t)
                actualTrue = t;
            else
                actualTrue = g;

            actualFalse = q - t;
            myFalse = q - g;
            if (myFalse > actualFalse)
                answer = actualTrue + actualFalse;
            else
                answer = actualTrue + myFalse;

            Console.WriteLine("Total Max Marks: {0}", answer);
        }
    }
}
