using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class OutputMaster
    {
        internal static void PrintList(IList<string> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        internal static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        internal static void PrintArray(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int[] arr = a[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        internal static void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        internal static void PrintKeyValuePair(KeyValuePair<int[], int> p)
        {
            foreach (var e in p.Key)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine($"   {p.Value}");
        }


        internal static void PrintListOfList(IList<IList<int>> l)
        {
            foreach (IList<int> innerList in l)
            {
                foreach (int value in innerList)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }


        internal static bool CompareListsOfList(IList<IList<int>> list1, IList<IList<int>> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].SequenceEqual(list2[i]))
                    return false;
            }

            return true;
        }


        internal static void PrintListOfList(IList<string> list)
        {
            foreach (var value in list)
            {
                Console.Write(value + " ");
            }
        }


        internal static bool CompareLists(IList<string> list1, IList<string> list2)
        {
            return list1.SequenceEqual(list2);
        }
    }
}
