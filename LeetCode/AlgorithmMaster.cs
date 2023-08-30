using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class AlgorithmMaster
    {
        internal static List<int> BinarySearchAllIndexes(int[] array, int target)
        {
            List<int> indexes = new List<int>();

            int index = Array.BinarySearch(array, target);
            if (index >= 0)
            {
                // Add the initial index to the list
                indexes.Add(index);

                // Search for additional occurrences to the left
                int leftIndex = index - 1;
                while (leftIndex >= 0 && array[leftIndex] == target)
                {
                    indexes.Add(leftIndex);
                    leftIndex--;
                }

                // Search for additional occurrences to the right
                int rightIndex = index + 1;
                while (rightIndex < array.Length && array[rightIndex] == target)
                {
                    indexes.Add(rightIndex);
                    rightIndex++;
                }
            }

            return indexes;
        }


        internal static int IsMore(IList<int> l1, IList<int> l2)
        {
            // Return a negative value if l1 is considered less than l2,
            // zero if they are equal, or a positive value if l1 is considered greater than l2
            if (l1[0] > l2[0])
                return 1;
            if (l1[0] < l2[0])
                return -1;

            if (l1[1] > l2[1])
                return 1;
            if (l1[1] < l2[1])
                return -1;

            if (l1[2] > l2[2])
                return 1;
            if (l1[2] < l2[2])
                return -1;

            return 0;
        }


        internal static int BinarySearch(IList<IList<int>> list, IList<int> target, Comparison<IList<int>> comparison)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparisonResult = comparison(list[mid], target);

                if (comparisonResult == 0)
                {
                    return int.MaxValue;
                    // return mid; // Found a match
                }
                else if (comparisonResult < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ~left; // Not found
        }


        internal static void AddToSortedList(IList<IList<int>> main, IList<int> addition)
        {
            int index = BinarySearch(main, addition, IsMore);
            if (index == int.MaxValue)
                return;

            if (index < 0)
                index = ~index;

            main.Insert(index, addition);
        }


        internal static void CombSort(ref int[] arr)
        {
            int l = arr.Length;
            const double factor = 1.247;
            double gapFactor = l / factor;
            while (gapFactor > 1)
            {
                int gap = Convert.ToInt32(Math.Round(gapFactor));
                for (int i = 0, j = gap; j < l; i++, j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int a = arr[j];
                        arr[j] = arr[i];
                        arr[i] = a;
                    }
                }
                gapFactor = gapFactor / factor;
            }
        }


        internal static void CombSort(ref int[,] arr)
        {
            int l = arr.GetLength(1);
            int h = arr.GetLength(0);
            const double factor = 1.247;
            double gapFactor = l / factor;
            while (gapFactor > 1)
            {
                int gap = Convert.ToInt32(Math.Round(gapFactor));
                for (int i = 0, j = gap; j < l; i++, j++)
                {
                    if (arr[0, i] > arr[0, j])
                    {
                        for (int k = 0; k < h; k++)
                        {
                            int a = arr[k, j];
                            arr[k, j] = arr[k, i];
                            arr[k, i] = a;
                        }
                    }
                }
                gapFactor = gapFactor / factor;
            }
        }


        internal static void ArraySwipe(int[] arr, int ind1, int ind2)
        {
            int temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;
        }
    }
}
