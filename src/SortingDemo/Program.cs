using Sorting;
using System;
using System.Diagnostics;

namespace SortingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 64, 34, 25, 12, 12, 22, 11, 90 };
            int[] arr = { 1, 5, 2, 4, 3, 6 };

            //int[] arr = RandomArray(20000);


            Stopwatch timer = Stopwatch.StartNew();
            //BubbleSort.Sort(arr);
            //timer.Stop();
            //Console.WriteLine("Bubble sorted array");
            ////SortingMetrics.PrintArray(arr);

            //Console.WriteLine("Time elapsed " + timer.Elapsed.TotalSeconds);

            //timer.Reset();
            //timer = Stopwatch.StartNew();
            //MergeSort.Sort(arr, 0, arr.Length - 1);
            //timer.Stop();
            //Console.WriteLine("Merge sorted array");
            ////SortingMetrics.PrintArray(arr);

            //Console.WriteLine("Time elapsed " + timer.Elapsed.TotalSeconds);



            timer.Reset();
            timer = Stopwatch.StartNew();
            QuickSort.Sort(arr, 0, arr.Length - 1);
            timer.Stop();
            Console.WriteLine("Quick sorted array");
            SortingMetrics.PrintArray(arr);

            Console.WriteLine("Time elapsed " + timer.Elapsed.TotalSeconds);

        }

        private static Random _rng = new Random();
        private static int[] RandomArray(int length)
        {
            int[] data = new int[length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = _rng.Next();
            }

            return data;
        }
    }
}
