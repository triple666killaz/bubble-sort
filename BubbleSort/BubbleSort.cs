using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        temp =arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

    }
}
