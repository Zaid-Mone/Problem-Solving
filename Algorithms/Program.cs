
using Algorithms.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Algorithms
    {
        static void Main(string[] args)
        {
          
            List<int> nums = new List<int>();
            
            nums.Add(7);
            nums.Add(4);
            nums.Add(2);
            nums.Add(8);
            nums.Add(1);
            nums.Add(3);
            nums.Add(5);

           var result =  QuickSort.SortASC(numbers:nums);


            Console.WriteLine(result);



            Console.ReadLine();
            Console.ReadKey();
        }
    }
}




