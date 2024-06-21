using Problem_Solving;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class ProblemSolving
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>() { 6, 5, 3, 1, 8, 7, 2, 4 };


            int newValue = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        newValue = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = newValue;
                        //newValue = list[j];
                        //oldValue = list[j + 1];
                        //list[j] = oldValue;
                        //list[j + 1] = newValue;




                    }
                    //oldValue = 0;
                    newValue = 0;
                }
            }






            Console.WriteLine(list);






            //List<int> list = new List<int>() { 256741038, 623958417, 467905213, 714532089 ,938071625 };

            ////list.Add(1);
            ////list.Add(2);
            ////list.Add(3);
            ////list.Add(4);
            ////list.Add(5);
            ////HackerRank.miniMaxSum(list);

            ////int[] nums = { 1, 1, 2 };
            //int[] nums = { 1, 3 };
            ////var result = LeetCode.RemoveDuplicates(nums);
            //var result = LeetCode.SearchRange(nums,1);

            //Console.WriteLine(result);



            //var ar = new List<int>();
            //ar.Add(256741038);
            //ar.Add(623958417);
            //ar.Add(467905213);
            //ar.Add(714532089);
            //ar.Add(938071625);
            //ar.Sort();
            //int min = 0;
            //int max = 0;
            //bool isMini = true;
            //bool isMaxi = true;
            //for (int i = 0; i < ar.Count; i++)
            //{
            //    if (isMini)
            //    {
            //        if (i != ar.Count - 1)
            //        {
            //            min += ar[i];
            //        }
            //    }
            //    if (isMaxi)
            //    {
            //        if (i != 0)
            //        {
            //            max+= ar[i];
            //        }
            //    }

            //}

            //Console.WriteLine(min + " " + max);
            //int count = ar.Count();


            //int min = ar.Sum() - ar[ar.Count - 1] ;
            //int max = ar.Sum() - ar[0];

            //Console.WriteLine(min + " " + max);

            Console.ReadLine();
        }
    }
}




