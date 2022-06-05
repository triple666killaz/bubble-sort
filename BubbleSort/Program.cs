using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
            }
                
            BubbleSort.Sort(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
