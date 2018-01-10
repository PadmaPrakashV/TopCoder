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
            Console.WriteLine("Enter input string: ");
            string input = Console.ReadLine();

            string r = "buffalo";
            string output = "Not Good";

            string[] arr = input.Split(' ').ToArray();

            foreach (var s in arr)
            {
                if (s.ToLower() == r)
                    output = "Good";
                else
                {
                    output = "Not Good";
                    break;
                }                    
            }

            Console.WriteLine("Output: {0}", output);

            Console.ReadLine();
        }
    }
}
