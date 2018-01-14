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
            string s = Console.ReadLine();

            initials(s);

            Console.ReadLine();
        }
        
        static void initials(string s)
        {
            string[] splitString = s.Split(' ');
            string acronym = "";

            for (int i = 0; i < splitString.Length; i++)
            {
                acronym = acronym + splitString[i][0];
            }

            Console.WriteLine("Acronym: {0}",acronym);

        }
    }
}
