using System;
using System.IO;

namespace Counting_Sort_1
{
    class Solution
    {

        // Complete the countingSort function below.
        static int[] countingSort(int[] arr)
        {
            int max = GetMax(arr);
            int[] result = new int[arr.Length];

            if ((100 <= arr.Length || arr.Length <= 1000000) && (max <= 0 || max < 100))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    result[arr[i]]++;
                }
            }


            return countingSort2(result);
        }

        static int[] countingSort2(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i] + arr[i + 1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];
            }
            return arr;
        }
        static int GetMax(int[] arr)
        {

            var max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;

        }

        static void Main(string[] args)
        {
            object a = "Hello";
            MyClass myClass = new MyClass();
            int num = 25;
            bool res = num.IsGraterThan(100);
            Console.WriteLine(num.IsGraterThan(10));

            

           // TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);
           // var asdf = new MyClass();
           //var ddd = asdf.ToModel();
           // int n = Convert.ToInt32(Console.ReadLine());

           // int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
           // int[] result = countingSort(arr);

            //textWriter.WriteLine(string.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
    public class MyClass
    {
        public MyClass()
        {

        }
        public MyClass(string a,string b)
        {
            this.fName = a;
            this.lNmae = b;
        }

       public Jony ToModel()
        {
            return new Jony() { 
            Boy=this.fName
            };
        }
        public string fName { get;set;}
        public string lNmae { get; set; }
    }

    public class Jony
    {
        public string Boy { get; set; }
    }

}
