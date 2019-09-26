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

namespace Day10
{
    class Solution
    {
        static List<int> ConvertBase10ToBase2(int number)
        {
            List<int> list = new List<int>();

            if(number == 0)
            {
                list.Add(number);
                return list;
            }

            while(number > 0)
            {
                var bit = number % 2;
                list.Add(bit);
                number = number / 2;
            }
            return list;
        }

        static int CountConsecOnes(List<int> bits)
        {
            int max = 0;
            int count = 0;

            foreach(int bit in bits)
            {
                count = bit == 1 ? count + 1 : 0;
                max = count > max ? count : max;
            }
            return max;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var bits = ConvertBase10ToBase2(n);
            var result = CountConsecOnes(bits);
            Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
