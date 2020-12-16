using System;

namespace Sorting
{
    public class QuickSort
    {
        static int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (Compare(items[i], pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }
            Swap(items, storeIndex, right);
            return storeIndex;
        }

        public static int[] Sort(int[] items, int left, int right)
        {
            if (left < right)
            {
                Random pivotRange = new Random();
                int pivotIndex = pivotRange.Next(left, right);


                int newPivotIndex = partition(items, left, right, pivotIndex);

                // Recursively sort elements before 
                // partition and after partition 
                Sort(items, left, newPivotIndex - 1);
                Sort(items, newPivotIndex + 1, right);
            }
            return items;
        }

        static int Compare(int left, int right)
        {
            return left.CompareTo(right);
        }

        static void Swap(int[] data, int left, int right)
        {
            int temp = data[left];
            data[left] = data[right];
            data[right] = temp;
        }

    }
}
