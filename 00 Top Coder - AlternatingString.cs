using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HackerrankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();

            AlternateString(input);

            Console.ReadLine();
        }

        public static void AlternateString(string input)
        {
            int count = 1;
            int lastcount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                char c1 = input[i - 1];
                char c2 = input[i];
                if (c1 != c2)
                {
                    count++;
                    continue;
                }
                else
                {
                    if (lastcount > count)
                        count = 1;
                    else
                    {
                        lastcount = count;
                        count = 1;
                    }
                }
            }

            Console.WriteLine("Total Alternate: {0}", lastcount);
        }
    }

}
