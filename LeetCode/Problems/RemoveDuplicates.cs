namespace LeetCode.Problems
{
    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var listo = new List<int>();
            //foreach (var number in nums)
            //{
            //    if (!listo.Any(q => q.Contains(number)))
            //    {
            //        listo.Add(number);
            //    }
            //}


            foreach (var item in nums)
            {
                var check = listo.Any(q => q == item);
                if (!check)
                    listo.Add((int)item);
            }


            return listo.Count();

        }
    }
}
