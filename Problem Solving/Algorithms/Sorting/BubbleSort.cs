using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.Algorithms.Sorting
{
    public class BubbleSort
    {



        public List<int> Bubbles(List<int> list)
        {
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
                    }
                    newValue = 0;
                }
            }
            return list;
        }

    }
}
