using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public static class QuickSort
    {



        public static List<int> SortASC(List<int> numbers)
        {
            // 7 , 4 , 2 , 8 , 1 , 3 , 5
            var anotherList = new List<int>();
            int tracker = 0;
            for (int i = 0; i <= numbers.Count(); i++)
            {
                Console.WriteLine(i);
                //if (i == 0 || i == numbers.Count())
                //{
                //    if (numbers[i] < numbers[i + 1])
                //    {

                //    }
                //    else
                //    {
                //        tracker = numbers[i];
                //        numbers[i] = numbers[i + 1];
                //        numbers[i + 1] = tracker;
                //    }
                //}
                //else
                //{

                //    if (numbers[i] > numbers[i -1 ] && numbers[i] < numbers[i +1 ])


                //    if (numbers[i] < numbers[i + 1])
                //    {

                //    }
                //    else
                //    {
                //        tracker = numbers[i];
                //        numbers[i] = numbers[i + 1];
                //        numbers[i + 1] = tracker;
                //    }

                //}
            }
            



            return new List<int>();
        }






        public static List<int> SortDESC(List<int> numbers)
        {
            return new List<int>();
        }
    }
}
