using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class LeetCode
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>();
            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && roman[s[i]] < roman[s[i + 1]])
                {
                    result -= roman[s[i]];
                }
                else
                {
                    result += roman[s[i]];
                }
            }

            return result;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            //var listo = new List<int>();
            //foreach (var item in nums)
            //{
            //    var check = listo.Any(q => q == item);
            //    if (!check)
            //        listo.Add((int)item);
            //}
            //return listo.Count();
            int k = 1;
            int previouse = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != previouse)
                {
                    nums[k] = nums[i];
                    k++;
                }
                previouse = nums[i];
            }
            return k;
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] arr = new int[2];
            if (nums.Length == 0)
            {
                arr[0] = -1;
                arr[1] = -1;
                return arr;
            }
            else if (!nums.Contains(target))
            {
                arr[0] = -1;
                arr[1] = -1;
                return arr;
            }
            else if (nums.Length == 1 && nums.Contains(target))
            {
                arr[0] = 0;
                arr[1] = 0;
                return arr;
            }
            else if (nums.Length == 2 && nums.Contains(target))
            {
                arr[0] = 0;
                arr[1] = 0;
                return arr;
            }
            else if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        arr[0] = i;
                        arr[1] = i + 1;
                        return arr;
                    }
                }
            }
            return arr;
        }
    }
}
