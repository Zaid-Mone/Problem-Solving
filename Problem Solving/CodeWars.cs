using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{

    public class CodeWars
    {
        public static string SortMyString(string s)
        {
            string even = string.Empty;
            string odd = string.Empty;
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += s[i].ToString();
                }
                else
                {
                    odd += s[i].ToString();
                }
            }

            result = even + " " + odd;
            return result;
        }

        public static string TitleCase(string title, string minorWords = "")
        {
            var str = title.Split(' ');

            return "";
        }
    }
}
