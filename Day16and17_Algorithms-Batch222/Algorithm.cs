using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16and17_Algorithms_Batch222
{
    class SortingClass
    {
        public static void InsertionSort()
        {
            string[] arr = { "cv", "yz", "ab", "cd", "ef" };
            int n = arr.Length - 1, flag;
            string val;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(arr[j]) < 0)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array after insertion sort is:\n ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}


