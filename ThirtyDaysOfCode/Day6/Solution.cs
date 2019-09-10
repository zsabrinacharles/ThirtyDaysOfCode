using System;
using System.Collections.Generic;
using System.IO;

namespace Day6
{
    class Solution
    {
        public static List<Tuple<string, string>> DivideCharacters(List<string> words)
        {
            var brokenWords = new List<Tuple<string, string>>();
            foreach (string word in words)
            {
                var evenCharaters = string.Empty;
                var oddCharaters = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    char current = word[i];
                    if (i % 2 == 0)
                        evenCharaters = String.Concat(evenCharaters, word[i]);
                    else
                        oddCharaters = String.Concat(oddCharaters, word[i]);
                }

                brokenWords.Add(new Tuple<string, string>(evenCharaters, oddCharaters));
            }
            return brokenWords;
        }

        static void Main(String[] args)
        {
            var words = new List<string>();
            var testCases = Convert.ToInt32(Console.ReadLine());
            
            for(int c = 0; c < testCases; c++)
            {
                var userInput = Console.ReadLine();
                words.Add(userInput);
            }

            var result = DivideCharacters(words);

            foreach(Tuple<string,string> divWord in result)
            {
                Console.WriteLine($"{divWord.Item1} {divWord.Item2}");
            }
            Console.ReadLine();
        }
    }
}
