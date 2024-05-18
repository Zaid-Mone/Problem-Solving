using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class HackerRank
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            int sum =0;
            var x = arr.Min();
            var x1 = arr.Max();
            arr.ForEach(i =>
            {
                sum += i;
            });
            int min = Math.Abs(sum - x1);
            int max = Math.Abs(sum - x);
            Console.WriteLine(min + " " + max);


        }
    }
}
