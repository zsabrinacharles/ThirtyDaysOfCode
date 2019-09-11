using System;
using System.Collections.Generic;
using System.IO;

namespace Day8
{
    class Solution
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string,string>();
        static string SearchPhonebook(string name)
        {
            return phoneBook.ContainsKey(name) ? $"{name}={phoneBook[name]}" : "Not found";
        }
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int numOfEntries = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numOfEntries; i++)
            {
                var entry = Console.ReadLine().Split(' ');
                string name = entry[0];
                string number = entry[1];

                phoneBook.Add(name, number);
            }

            var searchEntry = Console.ReadLine();

            while(!string.IsNullOrEmpty(searchEntry))
            {
                Console.WriteLine(SearchPhonebook(searchEntry));

                searchEntry = Console.ReadLine();
            }


        }
    }
}
