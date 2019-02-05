using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 4, 3, 5, 2 };
            var sorter = new QuickSortGeneric<int>(A);
            sorter.Sort();
            foreach (var i in sorter.A)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
        static int[] QuickSortInt(int[] arr)
        {
            int pivot = arr[0];
            List<int> smallerItems = new List<int>();
            List<int> equalItems = new List<int>();
            List<int> biggerItems = new List<int>();
            int[] outputArr = new int[arr.Length];

            equalItems.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    smallerItems.Add(arr[i]);
                }                   
                else if (arr[i] > pivot)
                {
                    biggerItems.Add(arr[i]);
                }
                else
                {
                    equalItems.Add(arr[i]);
                }
            }

            if (smallerItems.Count > 1)
            {
                smallerItems = QuickSortInt(smallerItems.ToArray()).ToList();
            }
            if (biggerItems.Count > 1)
            {
                biggerItems = QuickSortInt(biggerItems.ToArray()).ToList();
            }

            int j = 0;

            foreach (int item in smallerItems)
            {
                outputArr[j++] = item;
            }
            foreach (int item in equalItems)
            {
                outputArr[j++] = item;
            }
            foreach (int item in biggerItems)
            {
                outputArr[j++] = item;
            }

            return outputArr;
        }
        static char[] QuickSortChar(char[] arr)
        {
            char pivot = arr[0];
            List<char> smallerItems = new List<char>();
            List<char> equalItems = new List<char>();
            List<char> biggerItems = new List<char>();
            char[] outputArr = new char[arr.Length];

            equalItems.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    smallerItems.Add(arr[i]);
                }
                else if (arr[i] > pivot)
                {
                    biggerItems.Add(arr[i]);
                }
                else
                {
                    equalItems.Add(arr[i]);
                }
            }

            if (smallerItems.Count > 1)
            {
                smallerItems = QuickSortChar(smallerItems.ToArray()).ToList();
            }
            if (biggerItems.Count > 1)
            {
                biggerItems = QuickSortChar(biggerItems.ToArray()).ToList();
            }

            int j = 0;

            foreach (char item in smallerItems)
            {
                outputArr[j++] = item;
            }
            foreach (char item in equalItems)
            {
                outputArr[j++] = item;
            }
            foreach (char item in biggerItems)
            {
                outputArr[j++] = item;
            }

            return outputArr;
        }       
    }
}
