using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class LeetCode
    {
        static void Main(string[] args)
        {
            string[] words = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

            var result = MaximumNumberofWords.MostWordsFound(words);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}




