using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Day3
{
    public class Solution
    {
        static void PrintWeird()
        {
            Console.WriteLine("Weird");
        }

        static void PrintNotWeird()
        {
            Console.WriteLine("Not Weird");
        }

        static void Solve(int input)
        {
            if (input % 2 == 1)
            {
                PrintWeird();
            }
            else if (input % 2 == 0 && input <= 5 && input >= 2)
            {
                PrintNotWeird();
            }
            else if (input % 2 == 0 && input <= 20 && input >= 6)
            {
                PrintWeird();
            }
            else if (input % 2 == 0 && input > 20)
            {
                PrintNotWeird();
            }
            else
            {
                PrintWeird();
            }
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Solve(N);
        }

    }
}
