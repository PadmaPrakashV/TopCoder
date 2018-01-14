using System;
using System.Collections.Generic;
using System.IO;

namespace CodeChefProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four sides of a square");
            Console.Write("Enter Value a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Value b:");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Value c:");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Value d:");
            int d = Int32.Parse(Console.ReadLine());

            int minPrice = getMinimalPrice(a, b, c, d);

            Console.WriteLine("Minimal Price: {0}", minPrice);
            Console.ReadLine();
        }

        public static int getMinimalPrice(int a, int b, int c, int d)
        {
            int returnValue = 0;
            int[] result = new int[4];

            int[] minPrice = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int a1 = a;
                int b1 = b;
                int c1 = c;
                int d1 = d;

                result[i] = compareValues(a1, b1, c1, d1, i);

            }

            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                    returnValue = result[i];

                Console.WriteLine("Result[{0}]: {1}", i, result[i]);
                int r = result[i];
                if (r < returnValue)
                    returnValue = r;

            }

            return returnValue;
        }

        public static int compareValues(int a, int b, int c, int d, int pos)
        {
            int returnValue = 0;
            int[] arrList = new int[4];
            arrList[0] = a;
            arrList[1] = b;
            arrList[2] = c;
            arrList[3] = d;

            int[] indexArr = new int[3];
            int counter = 0;
            for (int i = 0; i < arrList.Length; i++ )
            {
                if(i != pos)
                {
                    indexArr[counter] = i;
                    counter++;
                }
            }

            foreach(int i in indexArr)
            {
                returnValue = returnValue  + Math.Abs(arrList[pos] - arrList[i]);
            }

            return returnValue;
        }
    }
}
