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

namespace Day7
{
    class Solution
    {

        static int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for(int i = array.Length - 1; i >= 0; i-- )
            {
                int revIdx = array.Length - i - 1;
                reverseArray[revIdx] = array[i];
            }
            return reverseArray;
        }

        static void PrintArray(int[] array)
        {
            foreach(int a in array)
            {
                Console.Write($"{a.ToString()} ");
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            var reversedArray = ReverseArray(arr);
            PrintArray(reversedArray);
            Console.ReadLine();
        }
    }
}
