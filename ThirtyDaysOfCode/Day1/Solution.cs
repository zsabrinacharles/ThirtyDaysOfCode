using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class Solution
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int one;
            double two;
            string three;
            // Read and save an integer, double, and String to your variables.
            one = Convert.ToInt32(Console.ReadLine());
            two = Convert.ToDouble(Console.ReadLine());
            three = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + one);
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + two).ToString("F1"));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(String.Concat(s, three));
            // The 's' variable above should be printed first.
        }
    }
}
