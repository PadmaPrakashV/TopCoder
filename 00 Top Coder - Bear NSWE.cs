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
            Console.Write("Enter int array: ");
            String s = Console.ReadLine();

            int[] arr = Array.ConvertAll(s.Split(' ').ToArray(), Int32.Parse);            

            Console.WriteLine("Directions");
            String dir = Console.ReadLine();            

            totalDistance(arr, dir);

            Console.ReadLine();
        }

        static void totalDistance(int[] arr, String dir)
        {
            int northLen = 0;
            int eastLen = 0;
            int westLen = 0;
            int southLen = 0;
            double distance = 0;
            double totalSum = 0;

            for (int i = 0; i < dir.Length; i++)
            {
                totalSum = totalSum + arr[i];

                if (dir[i] == 'N')
                    northLen = northLen + arr[i];
                else if (dir[i] == 'E')
                    eastLen = eastLen + arr[i];
                else if (dir[i] == 'W')
                    westLen = westLen + arr[i];
                else
                    southLen = southLen + arr[i];
            }

            int horLen = Math.Abs(eastLen - westLen);
            int verLen = Math.Abs(northLen - southLen);

            if (horLen != 0 && verLen != 0)
                distance = totalSum + Math.Sqrt(Math.Pow((double)horLen, 2d) + Math.Pow((double)verLen, 2d));
            else
                distance = totalSum + horLen + verLen;

            Console.WriteLine("Distance: {0}", distance);

            Console.WriteLine("Hor Len: {0}", horLen);
            Console.WriteLine("Ver Len: {0}", verLen);
        }
    }
}
