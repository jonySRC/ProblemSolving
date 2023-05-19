using System;
using System.IO;

namespace Counting_Sort_2
{
    class Solution
    {

        // Complete the countingSort function below.
        static int[] countingSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i];
                 
                if (i > 0)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (item < arr[j])
                        {
                            arr[j + 1] = arr[j];
                            arr[j] = item;
                        }
                    }
                }
               
                
            }
            return arr;

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = countingSort(arr);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
