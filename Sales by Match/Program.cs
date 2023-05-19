using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sales_by_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }


        public static int sockMerchant(int n, List<int> ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                int count = 1;

                for (int j=1+i;j< ar.Count; j++)
                {
                    if (ar[i] > 0)
                    {
                        if (ar[i] == ar[j])
                        {
                            count++;
                            ar[j] = -1;
                           
                        }
                    }
                }
                ar[i] = -1;
                sum = sum + (count / 2);

            }
           

            return sum;
        }
    }
}
