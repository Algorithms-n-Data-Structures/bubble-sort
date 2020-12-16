namespace Sorting
{
    public static class MergeSort
    {
        static void Merge(int[] arr, int left, int middle, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temp arrays
            int[] leftSize = new int[n1];
            int[] rightSize = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                leftSize[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                rightSize[j] = arr[middle + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftSize[i] <= rightSize[j])
                {
                    arr[k] = leftSize[i];
                    i++;
                }
                else
                {
                    arr[k] = rightSize[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = leftSize[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = rightSize[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle
                // point
                int middle = (left + right) / 2;

                // Sort first and
                // second halves
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }
    }
}
