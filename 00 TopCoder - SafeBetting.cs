using System;
using System.IO;
using System.Collections.Generic;

namespace TopCoderProgram
{
    class MagicSubset
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the magic subset");
            Console.Write("Enter the array value: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] arrValue = new int[n];

            buildArray(arrValue, n);
            findBest(arrValue);

            Console.ReadLine();
        }

        public static void buildArray(int[] arrValue, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the value of arrValue[{0}]: ", i);
                arrValue[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void findBest(int[] arrValue)
        {
            List<int> listPos = new List<int>();
            List<int> listNeg = new List<int>();
            int firstVal = arrValue[0];
            int sumPos = 0;
            int sumNeg = 0;

            for (int i = 1; i < arrValue.Length; i++)
            {
                if (arrValue[i] > 0)
                    listPos.Add(arrValue[i]);
                else
                    listNeg.Add(arrValue[i]);
            }

            foreach(int i in listPos)
            {
                Console.WriteLine("Positive: {0}", i);
                sumPos = sumPos + i;
            }
                
            Console.WriteLine();

            foreach(int i in listNeg)
            {
                Console.WriteLine("Negative: {0}", i);
                sumNeg = sumNeg + i;
            }

            sumNeg = (sumNeg + firstVal) * (-1);

            Console.WriteLine("Sum of Positive: {0}", sumPos);
            Console.WriteLine("Sum of Negative: {0}", sumNeg);

            if(sumPos > sumNeg)
                Console.WriteLine("Sum of Max Values: {0}", sumPos);
            else
                Console.WriteLine("Sum of Max Values: {0}", sumNeg);
        }
    }
}
