namespace Algorithms.SortAlgorithms
{
    public class BubbleSort
    {
        public List<int> Bubbles()
        {
            var lst = new List<int>() { 6, 5, 3, 1, 8, 7, 2, 4 };

            int oldValue = 0;
            int newValue = 0;

            for (int i = 0; i < lst.Count() - 1; i++)
            {
                if (lst[i] > lst[i + 1])
                {
                    newValue = lst[i];
                    oldValue = lst[i+1];
                    lst[i] = oldValue;
                    lst[i + 1] = newValue;
                }
            }
            return lst;
        }
    }

}
