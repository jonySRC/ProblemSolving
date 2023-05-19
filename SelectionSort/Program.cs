using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            arr = SelectionSort(arr);
            Console.WriteLine("Hello World!");
        }

        static int[] SelectionSort(int[] arr) {

            for (int i = 0; i < arr.Length; i++)
            {              
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }

                }                    

            }

            return arr;
        }
    }
}
