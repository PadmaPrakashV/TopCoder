using System;
using System.Collections.Generic;
using System.IO;

namespace CodeChefProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number Pair");
            Console.Write("Enter a1: ");
            int a1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter r1: ");
            int r1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a2: ");
            int a2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter r2: ");
            int r2 = Int32.Parse(Console.ReadLine());

            RepeatNumberCompare rn = new RepeatNumberCompare();
            Console.WriteLine(rn.compare(a1,r1,a2,r2));

            Console.ReadLine();
        }


        public class RepeatNumberCompare
        {
            public string compare(int a1, int r1, int a2, int r2)
            {
                string retVal;
                long a = Int64.Parse(buildString(a1, r1));
                long b = Int64.Parse(buildString(a2, r2));

                if (a > b)
                    retVal = "Greater";
                else if (a < b)
                    retVal = "Less";
                else
                    retVal = "Equal";

                return retVal;
            }

            public static string buildString(int a, int r)
            {
                string retVal = "";

                for (int i = 0; i < r; i++)
                {
                    retVal = retVal + a.ToString();
                }

                return retVal;
            }

        }
    }
}
