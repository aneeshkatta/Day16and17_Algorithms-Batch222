﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16and17_Algorithms_Batch222
{
    class SortingClass
    {
        public static void BubbleSort()
        {
            int[] arr = { 898, 555, 455, 988, 153 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}


