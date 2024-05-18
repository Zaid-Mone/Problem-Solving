using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public static class MaximumNumberofWords
    {
        // Problem Link : https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/description/
        // Array - Easy
        public static int MostWordsFound(string[] sentences)
        {
            int count = 0;
            string[] str = new string[0];
            foreach (var sentence in sentences)
            {
                str = sentence.Split(' ');
                if (count < str.Length)
                    count = str.Length;
            }
            return count;
        }
    }
}
