using System;
using System.IO;
using System.Collections.Generic;

namespace TopCoderProgram
{
    class ThreeIncreasing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find ThreeIncreasing");
            Console.Write("Enter the value of a: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Min Eaten Candies: {0}", minEaten(a,b,c));

            Console.ReadLine();
        }

        public static int minEaten(int a, int b, int c)
        {
            int returnValue = -1;

            if(b > c)
            {
                returnValue = b - (c-1);
                b = c - 1;                
                if(a > b)
                {
                    returnValue = a - (b - 1);
                    a = b - 1;
                }
            }
            else
            {
                if(a > b)
                {
                    a = b - 1;
                }
            }
                            

            return returnValue;
        }

    }
}
