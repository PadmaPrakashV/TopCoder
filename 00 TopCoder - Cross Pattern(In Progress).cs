using System;
using System.IO;
using System.Collections.Generic;

namespace TopCoderProgram
{
    class Cross
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find Cross in the pattern");
            Console.Write("Enter the Value of i: ");
            int i = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the Value of j: ");
            int j = Int32.Parse(Console.ReadLine());

            string[,] pattern = new string[i, j];
            

            Console.ReadLine();
        }

        public static string exist(string[] pattern)
        {
            string returnValue = "";

            return returnValue;
        }

        public static void buildArray(string[,] pattern,int l1,int l2)
        {
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    Console.Write("Enter Value of [{0},{1}]: ", i,j );
                    pattern[i, j] = Console.ReadLine();
                }
            }
        }

        public static void buildArray(string[,] pattern, int l1, int l2)
        {
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    Console.Write("Enter Value of [{0},{1}]: ", i, j);
                    pattern[i, j] = Console.ReadLine();
                }
            }
        }
    }
}
